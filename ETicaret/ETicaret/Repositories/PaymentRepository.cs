using ETicaret;
using Microsoft.EntityFrameworkCore;
public class PaymentRepository:IPaymentRepository
{
 private readonly ETicaretContext _context;
    public PaymentRepository(ETicaretContext context)
    {
        _context=context;
    }
    public PaymentRepository()
    {
                                                                           
    }

   async Task<List<PaymentTransaction>> IPaymentRepository.GetAllPaymentCards()
    {
         return  await _context.Set<PaymentTransaction>().ToListAsync();
    }

     async Task<PaymentTransaction> IPaymentRepository.FindCardByID(PaymentTransaction card)
    {
         var findedCard= await _context.Cards.FindAsync(card.ID);
         return card;
        
       
    }

    async Task<PaymentTransaction> IPaymentRepository.CreateNewCard(PaymentTransaction card)
    {
         await _context.AddAsync(card);
             _context.SaveChangesAsync();
            return card;
    }

    void IPaymentRepository.DeleteCardFromSystem(PaymentTransaction card)
    {
        var findedCard=_context.Cards.Find(card.ID);   
         _context.Cards.Remove(findedCard);
        _context.SaveChanges();
    }

    async Task<PaymentTransaction> IPaymentRepository.UpdateCardInfos(PaymentTransaction card)
    {
        var findedCard= await _context.Cards.FindAsync(card.ID);
        _context.Cards.Update(findedCard);          //veya direkt update(card.ID); YAPSAK ÇALIŞMAZ MI ? DENE BAKALIM Bİ
             _context.SaveChanges();
            return card;
    }
}