using Microsoft.EntityFrameworkCore;
public static class UserDatabaseBuilder
{



    static void SetDataToDB(ModelBuilder modelBuilder) => modelBuilder.Entity<User>().HasData(
            new User
            {
                ID = 1,
                FirstName = "Galip Can",
                LastName = "KARAARSLAN",
                Name = "gckaraarslan",
                AccountID=1
                

            },
         new User
         {
             ID = 2,
             FirstName = "Cemal",
             LastName = "Okka",
             Name = "Comolokko",
             AccountID=2

         }  
       );
    public static void TableBuilder(ModelBuilder modelBuilder)
    {
                 modelBuilder.Entity<User>(entity =>
           {
             entity.HasKey(e => e.ID);
             entity.Property(e => e.FirstName).IsRequired();
             entity.Property(e => e.LastName).IsRequired();
             entity.Property(e => e.Name).IsRequired();
             
             });
         
        SetDataToDB(modelBuilder); 
    }
}