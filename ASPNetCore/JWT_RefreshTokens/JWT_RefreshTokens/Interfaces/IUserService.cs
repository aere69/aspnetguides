using JWT_RefreshTokens.Requests;
using JWT_RefreshTokens.Responses;

namespace JWT_RefreshTokens.Interfaces
{
    public interface IUserService
    {
        Task<TokenResponse> LoginAsync(LoginRequest loginRequest);
        Task<SignUpResponse> SignupAsync(SignUpRequest signupRequest);

        Task<LogOutResponse> LogoutAsync(int userId);
        Task<UserResponse> GetInfoAsync(int userId);
    }
}
