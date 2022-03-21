using ETicaret;
public class PaymentDTO
{
public string NameOfCardOwner { get; set; }
public int CardNumber { get; set; }
 public string LastUsageTimeOfCard { get; set; }       //şimdilik int yaptım değiştiricem veya değiştirmicem 
 public int CVV { get; set; }
}