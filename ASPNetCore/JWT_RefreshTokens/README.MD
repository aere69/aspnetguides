# Access Tokens vs Refresh Tokens

We use an access token to grant a user the proper authorization to access some resources on the server when it is provided in the Authorization header.
An access token is usually short-timed and signed, as for a JWT Token, this will include the signature, claims, headers.

On the other hand, a refresh token is usually a reference that can be used only to refresh the access token. 
Such token is usually persisted in a backend storage and can be used to revoke access for users who, for example, are no longer eligible to access these resources or in the case of a malicious user who stole an access token.

In such cases, you can just remove the refresh token for these devices, so once their access token is expired they won’t be able to renew (refresh) it using the revoked refresh token because their once-valid refresh token is no longer valid and they will no longer be able to access your resources. 
Therefore, the user will be signed out in the app or web and they will have to go through the usual login process again.

[Souce](https://codingsonata.com/apply-jwt-access-tokens-and-refresh-tokens-in-asp-net-core-web-api/)

## Install Nuget Packages

- Microsoft.EntityFramework.Core
- Mircosoft.EntityFramework.Core.SqlServer
- Microsoft.AspNetCore.Authentication.JwtBearer

## Breaking Change in EF Core 7

Important note here about the `TrustServerCertifiicate=True`, this is only an unsecure workaround just for the sake of testing localhost.

You can instead [install a trusted certificate](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/enable-encrypted-connections-to-the-database-engine?view=sql-server-ver16) and then you can remove the TrustServerCertificate=True from the connection string.

## EF Core Power Tools

The extension [EF Core Power Tools](https://marketplace.visualstudio.com/items?itemName=ErikEJ.EFCorePowerTools) in a magical way it can translate a whole database structure and relationships into neat and proper DbContext entities and configurations.
If you are following the design-first model for building your database first and then your EF Core mapping, I would highly recommend that you use this tool to perform such operation, which will therefore boost your productivity and reduce the number of errors that might be introduced from manually creating the entities and configurations.

## Requests and Responses

It is always advised that you accept and return structured objects instead of separated data

## Interfaces

Interfaces that will be implemented within the services. 
The interfaces are the abstractions that the Controllers would use to be able to process the related business logic and database calls.
Each interface would be implemented within a service which would be injected at runtime.

Useful strategy (or design pattern) to make your API loosely coupled and easily testable.

## Services

Services act as the intermediate layer between your Controllers and your DbContext.
Services also include any business related logic that the Controller should not bother about. 
Services implement the interfaces.

## Controllers

First, we need a new Controller that will inherit for the ControllerBase and inside it we will have a small method and property to retrieve the logged in UserId, whenever the access token is provided, from the JWT-based access token claims.
