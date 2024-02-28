using SecureWebApi.Entities;
using SecureWebApi.Helpers;
using SecureWebApi.Interfaces;
using SecureWebApi.Requests;
using SecureWebApi.Responses;
using System.Linq;
using System.Threading.Tasks;

namespace SecureWebApi.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly CustomersDbContext _context;

        public CustomerService(CustomersDbContext context)
        {
            _context = context;
        }

        public async Task<LoginResponse> Login(LoginRequest request)
        {
            var customer = _context.Customers.SingleOrDefault(customer => customer.Active && customer.Username == request.Username);
            if (customer == null)
            {
                return null;
            }
            var passwordHash = HashingHelper.HashUsingPbkdf2(request.Password, customer.PasswordSalt);
            if (customer.Password != passwordHash)
            {
                return null; //Invalid Password
            }
            var token = await Task.Run(() => TokenHelper.GenerateToken(customer));
            return new LoginResponse { Username = customer.Username, FirstName = customer.FirstName, LastName = customer.LastName, Token = token };
        }
    }
}
