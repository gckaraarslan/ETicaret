using Microsoft.EntityFrameworkCore;
using ETicaret;
public static class ProductDatabaseBuilder
{
    static void SetDataToDB(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1,
                Name = "T-Shirt"
            },
            new Category
            {
                Id = 2,
                Name = "Pantolon"
            },
             new Category
            {
                Id = 3,
                Name = "Ayakkabı"
            },
             new Category
            {
                Id = 4,
                Name = "Gömlek"
            },
             new Category
            {
                Id = 5,
                Name = "Sweetshirt"
            }
        );
        modelBuilder.Entity<Brand>().HasData(
        new Brand
        {
            Id = 1,
            Name = "Balenciaga"
        },
        new Brand
        {
            Id = 2,
            Name = "Palm Angel"
        },
        new Brand
        {
            Id = 3,
            Name = "Nike"
        },
        new Brand
        {
            Id = 4,
            Name = "Adidas"
        },
        new Brand
        {
            Id = 5,
            Name = "Mavi"
        }
    );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ID = 1,
                Name = "Oversized T-Shirt",
                UnitPrice = 15,
                UnitsInStock = 10,
                BrandID = 1,
                CategoryID = 1,
                PaymentCardID=1
                
            },
            new Product
            {
                ID = 2,
                Name = "Sweetshirt",
                UnitPrice = 20,
                UnitsInStock = 10,
                BrandID = 2,
                CategoryID = 5,
                PaymentCardID=2
            }                                               //DAHA EKLEME YAPILIR...
        );

    }
    public static void TableBuilder(ModelBuilder modelBuilder)
    {
                modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
        });
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ID);
            entity.Property(e => e.Name).IsRequired();
            entity.HasOne(p => p.Category).WithMany(c => c!.Products).HasForeignKey(p => p.CategoryID);               //c! ne alaka ? o ünlem ne iş orda ?
            entity.HasOne(b => b.Brand).WithMany(c => c!.Products).HasForeignKey(b => b.BrandID);
            entity.HasOne(p => p.PaymentCard).WithMany(c => c.ProductList).HasForeignKey(p => p.PaymentCardID);   

        });

    SetDataToDB(modelBuilder);
    }
}