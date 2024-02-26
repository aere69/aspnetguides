# API KEY Authentication

Easily secure ASP.NET Core Web API using API Key Authentication.

**API Key Authentication** should be limited to the service clients or well-known clients. It is mainly used to identify and authorize a project or service that is connecting to your APIs.

It will keep a secure link between your APIs and the client of your APIs (other business that is accessing your APIs).

> It is not recommended that you use the API Key Authentication to actually authenticate your users.

## 2 ways to achieve it:

### Using Custom Attributes

We want to introduce a new custom attribute that will inherit from ASP.NET Core Attributes and it will implement the IAsyncActionResult interface

We will verify that the ApiKey header exists, has a value and its value is actually the correct API Key, unless otherwise we will return a 401 Unauthorized response to the client indicating that the request is not authorized to access the endpoint.

1. Add new folder - Attributes

2. Add new file in folder = ApiKeyAttribute.cs

  This attribute will be used to decorate the controller so that any request that is routed to the attributed controller will be redirected to ApiKeyAttribute

  Your custom attribute will be inheriting from the base abstract class Attribute of global System.Attribute, which will transform your class into a custom attribute,

  And also you will be implementing the IAsyncActionFilter Interface so that your custom attribute will be able to intercept the call request, process it and then route the request back to the controller.

3. Insert code:

```c#
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace SecureWebAPIUsingAPIKey.Attributes
{
    [AttributeUsage(validOn:AttributeTargets.Class)]
    public class ApiKeyAttribute : Attribute, IAsyncActionFilter
    {
        private const string APIKEYNAME = "ApiKey";

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if(!context.HttpContext.Request.Headers.TryGetValue(APIKEYNAME, out var extratedApiKey)) 
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "Api Key was not provided."
                };
                return;
            }
            var appSettings = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
            var apiKey = appSettings.GetValue<string>(APIKEYNAME);
            if (!apiKey.Equals(extratedApiKey))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "Api Key is not valid"
                };
                return;
            }
            await next();
        }
    }
}
```

  `[AttributeUsage(validOn:AttributeTargets.Class)]` this decoration is also an Attribute that indicates and specifies where the ApiKeyAttribute will be used, in our case we have specified that ApiKeyAttribute will only be used on classes , like Controllers.
  
  Use `[AttributeUsage(validOn: AttributeTargets.Class | AttributeTargets.Method)]` if you want to use it on classes and/or methods. (Controller and/or action method)

4. Create the ApiKey

Create an API Key. For this sake of this tutorial, we will be adding the API Key inside the appsettings.json file, which is the settings file that resides in your ASP.NET Core Web API Project.

> Choose an API Key that is strong enough. Never share the same API Key with more than 1 client

Add the following line to appsettings.json:

```json
"ApiKey": "YOUR_KEY_VALUE"
```

5. Add the ApiKey validation to the controller.

Decorate our Controller with the ApiKey Attribute so that we can authenticate the client that is calling our endpoint

```c#
namespace SecureWebAPIUsingAPIKey.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ApiKey]
    public class WeatherForecastController : ControllerBase
    {

```

6. Test with Postman

### Using Custom Middleware

With custom ASP.NET Core Middleware you are able to intercept and process the request object in a single place.

Intercept each and every request that comes to your published web APIs and tap into the request headers collection and search for the API key header and validate its value.

1. Add a Middleware folder

2. Add ApiKeyMiddleware.cs file to the folder.

What defines a middleware is its constructor that takes an instance of RequestDelegate Class, this instance is actually the pipeline passed between the ASP.NET Core Middleware collection. so this custom middleware will also receive this instance of pipeline and do some operations on it.

The next important thing is the InvokeAsync method that you need to define in this middleware so that it will contain the main process and in our case the main process will be to search and validate the ApiKey header name and value within the httpcontext request headers collection, so this need to be passed in the method argument.

3. Add code:

```c#
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace SecureWebApiUsingApiKey_Middleware.Middleware
{
    public class ApiKeyMiddleware
    {
        private readonly RequestDelegate _next;
        private const string APIKEYNAME = "ApiKey";

        public ApiKeyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.Request.Headers.TryGetValue(APIKEYNAME, out var extractedApiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Api Key was not provided. (Using ApiKeyMiddleware) ");
                return;
            }

            var appSettings = context.RequestServices.GetRequiredService<IConfiguration>();
            var apiKey = appSettings.GetValue<string>(APIKEYNAME);

            if (!apiKey.Equals(extractedApiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Unauthorized client. (Using ApiKeyMiddleware)");
                return;
            }
            await _next(context);
        }
    }
}
```
4. Create the ApiKey

Create an API Key. For this sake of this tutorial, we will be adding the API Key inside the appsettings.json file, which is the settings file that resides in your ASP.NET Core Web API Project.

> Choose an API Key that is strong enough. Never share the same API Key with more than 1 client

Add the following line to appsettings.json:

```json
"ApiKey": "YOUR_KEY_VALUE"
```

5. Middleware has to be injected to the pipeline in program.cs

```c#
//Inject the API Key check to all controllers
app.UseMiddleware<ApiKeyMiddleware>();
```

This way you will be applying this custom API Key Middleware over your every single controller in your project, not just specific controller or method like the custom attributes.

6. Test with Postman.

[Ref](https://codingsonata.com/secure-asp-net-core-web-api-using-api-key-authentication/)