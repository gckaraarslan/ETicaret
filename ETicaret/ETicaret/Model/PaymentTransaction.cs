using ETicaret;
public class PaymentTransaction   
{
    public int ID { get; set; }
    public string NameOfCardOwner { get; set; }
    public int CardNumber { get; set; }
    public string LastUsageTimeOfCard { get; set; }        //hasdata kısmı için şimdilik int girdim, datetime veya daha uygun bir şeye dönüştreceğim
    public int CVV { get; set; }
    public virtual ICollection<Product> ProductList { get; set; }          //baskete gerek var mı ???? 
    
    public int AccountID { get; set; }
    public Account Account { get; set; }
    
}