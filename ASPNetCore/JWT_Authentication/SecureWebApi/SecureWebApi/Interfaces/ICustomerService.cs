using SecureWebApi.Requests;
using SecureWebApi.Responses;
using System.Threading.Tasks;

namespace SecureWebApi.Interfaces
{
    public interface ICustomerService
    {
        Task<LoginResponse> Login(LoginRequest request);
    }
}
