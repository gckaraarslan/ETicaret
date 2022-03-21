public class Basket{
    public int ID { get; set; }
    public ICollection<Product>? Products { get; set; }
}