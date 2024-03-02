using JWT_RefreshTokens.Entities;
using JWT_RefreshTokens.Requests;
using JWT_RefreshTokens.Responses;

namespace JWT_RefreshTokens.Interfaces
{
    public interface ITokenService
    {
        Task<Tuple<string, string>?> GenerateTokensAsync(int userId);
        Task<ValidateRefreshTokenResponse> ValidateRefreshTokenAsync(RefreshTokenRequest refreshTokenRequest);
        Task<bool> RemoveRefreshTokenAsync(User user);
    }
}
