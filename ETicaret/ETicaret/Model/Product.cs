using ETicaret;
public class Product{
    public int ID { get; set; }
    public int CategoryID { get; set; }
    public Category Category { get; set; }
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
    public int QuantityPerUnit { get; set; }
    public int BrandID { get; set; }
    public Brand Brand { get; set; }
    public int PaymentCardID { get; set; }
    public PaymentTransaction PaymentCard { get; set; }

}