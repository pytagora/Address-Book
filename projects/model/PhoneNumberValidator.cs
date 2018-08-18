using FluentValidation;

namespace Model
{
    public class PhoneNumberValidator : AbstractValidator<PhoneNumber>
    {
        public PhoneNumberValidator()
        {
            RuleFor(x => x.Number).NotNull().WithMessage("Please specify contact's phone number.");
            RuleFor(x => x.Type).NotEmpty().WithMessage("Please specify contact's phone type.");
        }
    }
}
