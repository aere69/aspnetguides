using Microsoft.AspNetCore.Authorization;

namespace SecureWebApi.Requirements
{
    public class CustomerStatusRequirement : IAuthorizationRequirement
    {
        public bool IsBlocked { get; }

        public CustomerStatusRequirement(bool isBlocked)
        {
            IsBlocked = isBlocked;
        }
    }
}
