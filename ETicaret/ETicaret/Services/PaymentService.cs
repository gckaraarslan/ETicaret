using ETicaret;
using Microsoft.EntityFrameworkCore;
public class PaymentService : IPaymentService
{
    private readonly IPaymentRepository _paymentRepository;
    public PaymentService(IPaymentRepository paymentRepository)
    {
        _paymentRepository=paymentRepository;
    }
    public PaymentService()
    {
                                                                           
    }    public async Task<PaymentTransaction> CreateNewCard(PaymentTransaction card)
    {
        await _paymentRepository.CreateNewCard(card);
        return card;
    }

    public async void DeleteCardFromSystem(PaymentTransaction card)
    {
        var findedCard=await _paymentRepository.FindCardByID(card);     //business logicler atılacak
        

    }

    public async Task<PaymentTransaction> FindCardByID(PaymentTransaction card)
    {
        var findedCard=await _paymentRepository.FindCardByID(card);
        return findedCard;
    }

    public async Task<List<PaymentTransaction>> GetAllPaymentCards()
    {
        return await _paymentRepository.GetAllPaymentCards();
    }

    public async Task<PaymentTransaction> UpdateCardInfos(PaymentTransaction card)
    {
        var findedCard=await _paymentRepository.FindCardByID(card);
        _paymentRepository.UpdateCardInfos(findedCard);
        return findedCard;      //veya sadece card yazarsak rreturn kısmına bir fark var mı ? BİRİ ESKİ, DİĞERİ YENİ HALİNİ Mİ GETİRİYOR, DENE ???
    }
}
