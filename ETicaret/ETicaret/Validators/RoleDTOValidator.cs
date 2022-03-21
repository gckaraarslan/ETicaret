using FluentValidation;

public class RoleDTOValidator : AbstractValidator<RoleDTO>
{
    public RoleDTOValidator()
    {
        RuleFor(x => x.Name).NotNull().WithMessage("Account Role olarak; Buyer veya Seller'dan birini seçiniz.");
    }
}