namespace ETicaret{
public class Account{
    public int ID { get; set; }
    public string? EMAIL { get; set; }
    public string? PASSWORD { get; set; }
    public bool IsBlocked { get; set; }
    public bool Visibility { get; set; }
    public int UserID { get; set; }
    public virtual User User { get; set; }
    public int RoleID { get; set; }
    public virtual Role Role { get; set; }
    public virtual ICollection<PaymentTransaction> Cards { get; set; } 
    public int? AddressID { get; set; } 
    public Address? Address { get; set; }
}
}