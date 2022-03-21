using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;    //bunu düzelt
using ETicaret;

public class ETicaretContext : DbContext
{
    public DbSet<Account>? Accounts { get; set; }
   public DbSet<User>? Users { get; set; }
    public DbSet<Address>? Address { get; set; }
    public DbSet<Product>? Products { get; set; }
    public DbSet<Brand>? Brands { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<PaymentTransaction>? Cards { get; set; }

    //DAHA EKLENECEKLER VAR



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
        optionsBuilder.UseMySql("server=localhost;database=can;user=root;port=3306;password=toortoor", serverVersion);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        AccountDatabaseBuilder.TableBuilder(modelBuilder);
        AddressDatabaseBuilder.TableBuilder(modelBuilder);
        ProductDatabaseBuilder.TableBuilder(modelBuilder);
        UserDatabaseBuilder.TableBuilder(modelBuilder);  // accountdb builder içinde zaten role ve user var, ayrıca user db builder açmak gerekli mi ?
        PaymentDatabaseBuilder.TableBuilder(modelBuilder);

    }
}