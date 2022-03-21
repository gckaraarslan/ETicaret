using FluentValidation;

public class PaymentDTOValidator : AbstractValidator<PaymentDTO>
{
    public PaymentDTOValidator()
    {
        RuleFor(x => x.NameOfCardOwner).NotNull().WithMessage("Kart sahibi ismi doldurulmalıdır.");
        RuleFor(x => x.CardNumber).NotNull().WithMessage("Kart No girilmelidir.");
        RuleFor(x => x.LastUsageTimeOfCard).NotNull().WithMessage("Kart SKT seçilmelidir.");
        RuleFor(x => x.CVV).NotNull().WithMessage("Lütfen CVV giriniz");

    }
}