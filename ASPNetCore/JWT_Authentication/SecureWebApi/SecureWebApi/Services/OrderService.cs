using SecureWebApi.Entities;
using SecureWebApi.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SecureWebApi.Services
{
    public class OrderService : IOrderService
    {
        private readonly CustomersDbContext _customersDbContext;

        public OrderService(CustomersDbContext customersDbContext)
        {
            _customersDbContext = customersDbContext;
        }

        public async Task<List<Order>> GetOrdersByCustomerId(int id)
        {
            var orders = await _customersDbContext.Orders.Where(order => order.CustomerId == id).ToListAsync();
            return orders;
        }
    }
}
