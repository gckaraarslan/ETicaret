using Microsoft.AspNetCore.Mvc;
using ETicaret;

[ApiController]
[Route("[controller]")]
public class PaymentController : ControllerBase
{
    private readonly IPaymentService _paymentService;

    public PaymentController(IPaymentService paymentService)
    {
        _paymentService = paymentService;

    }
    [HttpGet("getall")]
     public async Task<List<PaymentTransaction>> GetAllCards()
     {
         return await _paymentService.GetAllPaymentCards();
     }
     [HttpGet("findcardbyid")]
      public async Task<PaymentTransaction> FindCardByID(PaymentTransaction card)
    {
        return await _paymentService.FindCardByID(card);
    }
      [HttpPost]
    public async Task<PaymentTransaction> CreatePaymentCard(PaymentTransaction card)
    {
        return await _paymentService.CreateNewCard(card);
    }
    [HttpPut("delete")]
    public  void CardDelete(PaymentTransaction card)
    {
         _paymentService.DeleteCardFromSystem(card);
        
    }
    [HttpPut("update")]
    public async Task<PaymentTransaction> UpdateCardInfos( PaymentTransaction card)
    {
        var updatedCard = await _paymentService.UpdateCardInfos(card);
        return updatedCard;
        
    }
}