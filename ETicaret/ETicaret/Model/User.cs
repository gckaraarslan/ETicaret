using ETicaret;
public class User{
    public int ID { get; set; }
    public string Name { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int AccountID { get; set; }
    public virtual Account Account { get; set; }
}