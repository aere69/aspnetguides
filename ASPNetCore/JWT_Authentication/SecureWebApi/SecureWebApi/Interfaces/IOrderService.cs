using SecureWebApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SecureWebApi.Interfaces
{
    public interface IOrderService
    {
        Task<List<Order>> GetOrdersByCustomerId(int id);
    }
}
