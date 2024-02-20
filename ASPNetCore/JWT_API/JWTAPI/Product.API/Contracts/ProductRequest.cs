namespace Product.API.Contracts
{
    public class ProductRequest
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
