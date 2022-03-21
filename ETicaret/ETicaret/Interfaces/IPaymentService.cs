public interface IPaymentService
{
    Task<List<PaymentTransaction>> GetAllPaymentCards();
    Task<PaymentTransaction> FindCardByID(PaymentTransaction card);
    Task<PaymentTransaction> CreateNewCard(PaymentTransaction card);
    void DeleteCardFromSystem(PaymentTransaction card);
    Task<PaymentTransaction> UpdateCardInfos(PaymentTransaction card);
}