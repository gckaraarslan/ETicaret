namespace ETicaret{
public class Role{
    public int Id { get; set; }
    public string Name { get; set; }        //buyer seller

    public virtual ICollection<Account> Account { get; set; }
}
}