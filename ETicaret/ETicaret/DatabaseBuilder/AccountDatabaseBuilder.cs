using Microsoft.EntityFrameworkCore;
namespace ETicaret
{




    public static class AccountDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasData(
             new Account
             {
                 ID = 1,
                 EMAIL = "gckaraarslan@gmail.com",
                 PASSWORD = "123123",
                 IsBlocked=true,
                 Visibility=true,
                 UserID=1,
                 RoleID=1,
                 AddressID=1


             },
             new Account
             {
                 ID = 2,
                 EMAIL = "galipcan.karaaslan@sahabt.com",
                 PASSWORD = "555555",
                 IsBlocked=true,
                 Visibility=true,
                 UserID=2,
                 RoleID=2,
                 AddressID=2

             }
         );
            modelBuilder.Entity<Role>().HasData(
              new Role
              {
                  Id = 1,
                  Name = "Seller"

              },
              new Role
              {
                  Id = 2,
                  Name = "Buyer"

              }
          );
           
        }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
             {
                 entity.HasKey(e => e.ID);
                 entity.Property(e => e.EMAIL).IsRequired();
                 entity.Property(e => e.PASSWORD).IsRequired();
                 entity.HasOne(e => e.Role).WithMany(e => e.Account).HasForeignKey(x => x.RoleID);//UsingEntity(j => j.ToTable("Account_Role"));
                 entity.Property(x => x.IsBlocked);
                 entity.Property(x => x.Visibility);
                 entity.HasOne(e => e.User).WithOne(x => x.Account).HasForeignKey<Account>(x=>x.UserID); 
                 entity.HasOne(x => x.Address).WithMany(x => x.Account).HasForeignKey(x => x.AddressID);


             });

            modelBuilder.Entity<Role>(entity =>
           {
               entity.HasKey(e => e.Id);
               entity.Property(e => e.Name).IsRequired();
               entity.HasMany(e => e.Account).WithOne(x => x.Role);
           });
          /*  modelBuilder.Entity<User>(entity =>
           {
               entity.HasKey(e => e.ID);
               entity.Property(e => e.Name).IsRequired();
               entity.Property(e => e.FirstName).IsRequired();
               entity.Property(e => e.LastName).IsRequired();
               entity.HasOne(a=>a.Account).WithOne(u=>u.USER);
    

           });*/    //userdatabasebuilder oluşturdum geri


            SetDataToDB(modelBuilder);
        }
    }
}