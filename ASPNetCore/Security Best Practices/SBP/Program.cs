var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Enforce HTTPS
// Redirect HTTP requests to HTTPS
builder.Services.AddHttpsRedirection(options =>
{
    options.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
    options.HttpsPort = 443;
});

// Use HTTP Strict Transport Security (HSTS)
// Prevent downgrade protocol attacks and cookie hijacking
// by ensuring that the web server communicates using an HTTPS
// connection and by blocking all insecure HTTP connections.
builder.Services.AddHsts(options =>
{
    options.IncludeSubDomains = true;
    options.MaxAge = TimeSpan.FromDays(7);
});

// Prevent Cross-site request forgery attacks (CSRF)
// Use anti-forgery tokens.
// Two different values are sent to the server with each POST. One of the values is sent as a browser cookie,
// and one is submitted as form data. Unless the server receives both values, it will refuse to allow the request to proceed.
builder.Services.AddAntiforgery(options =>
{
    options.FormFieldName = "ThisIsAnAntiForgeryField";
    options.HeaderName = "ThisIsAnAntiForgeryHeader";
    options.Cookie.Name = "ThisIsAnAntiForgeryCookie";
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
