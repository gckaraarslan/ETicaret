using Microsoft.EntityFrameworkCore;
public static class PaymentDatabaseBuilder
{



    static void SetDataToDB(ModelBuilder modelBuilder) => modelBuilder.Entity<PaymentTransaction>().HasData(
            new PaymentTransaction
            {
                ID= 1,
                NameOfCardOwner = "Galip Can",
                CardNumber = 88880,
                LastUsageTimeOfCard = "22.12.2025",
                CVV=355,
                AccountID=2
            },
         new PaymentTransaction
         {
             ID = 2,
             NameOfCardOwner = "Cemal",
             CardNumber = 9999,
             LastUsageTimeOfCard = "20.11.2030",
             CVV=122,
             AccountID=1

         }  
       );
    public static void TableBuilder(ModelBuilder modelBuilder)
    {
                 modelBuilder.Entity<PaymentTransaction>(entity =>
           {
             entity.HasKey(e => e.ID);
             entity.Property(e => e.NameOfCardOwner).IsRequired();
             entity.Property(e => e.CardNumber).IsRequired();
             entity.Property(e => e.LastUsageTimeOfCard).IsRequired();
              entity.Property(e => e.CVV).IsRequired();
             entity.HasOne(e=>e.Account).WithMany(e=>e.Cards).HasForeignKey(i=>i.AccountID);
             
             });
         
        SetDataToDB(modelBuilder); 
    }
}