using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace JonimoesApi.Models
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string customerName { get; set; }
        public string customerPhoneNumber { get; set; }
        public List<Pizza> pizzas {get; set;}
        public int totalPriceUSD { get; set; }
    }

    public class Pizza {
        public int priceUSD { get; set; }
        public string size {get; set;}
        public List<string> toppings { get; set; }
    }
}