using JonimoesApi.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace JonimoesApi.Services
{
    public class OrdersService : IOrdersService
    {

//dependenices
        private readonly IConfiguration _configuration;


        //class members
        private readonly IMongoCollection<Order> _ordersCollection;

        //DI constructor -- looks up my dependencies
        public OrdersService(IConfiguration configuration)
        {
            _configuration = configuration;

            var mongoClient = new MongoClient(_configuration.GetValue<string>("DB_CONNECTION"));
            var mongoDatabase = mongoClient.GetDatabase("jonimoes");
            _ordersCollection = mongoDatabase.GetCollection<Order>("orders");
        }

        public Task CreateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Order>> GetOrders()
        {
            //get all data in collection
            return await _ordersCollection.Find(_ => true).ToListAsync();
        }
    }
}