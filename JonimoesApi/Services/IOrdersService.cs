using JonimoesApi.Models;

namespace JonimoesApi.Services
{
    public interface IOrdersService
    {
        ///<summary> Gets a list of orders from the DB</summary>
        Task<List<Order>> GetOrders();
        ///<summary> Create an order in the DB</summary>
        Task CreateOrder(Order order);
    }
}