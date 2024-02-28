using Microsoft.AspNetCore.Authorization;
using SecureWebApi.Helpers;
using SecureWebApi.Requirements;
using System;
using System.Threading.Tasks;

namespace SecureWebApi.Handlers
{
    public class CustomerStatusHandler : AuthorizationHandler<CustomerStatusRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, CustomerStatusRequirement requirement)
        {
            var claim = context.User.FindFirst(c => c.Type == "IsBlocked" && c.Issuer == TokenHelper.Issuer);

            if (!context.User.HasClaim(c => c.Type == "IsBlocked" && c.Issuer == TokenHelper.Issuer))
            {
                return Task.CompletedTask;
            }

            string value = claim.Value;

            var customerBlockedStatus = Convert.ToBoolean(value);

            if (customerBlockedStatus == requirement.IsBlocked)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
