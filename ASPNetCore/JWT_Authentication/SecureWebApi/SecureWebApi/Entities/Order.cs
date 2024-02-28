using System;
using System.Text.Json.Serialization;

namespace SecureWebApi.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public string Currency { get; set; }
        public DateTime TS { get; set; }
        public int CustomerId { get; set; }

        [JsonIgnore] //hide it when doing Json serialization of the object.
        public Customer Customer { get; set; }
    }
}
