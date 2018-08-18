using FluentValidation;

namespace Model
{
    public class PhoneNumberValidator : AbstractValidator<PhoneNumber>
    {
        public PhoneNumberValidator()
        {
            RuleFor(phoneNumber => phoneNumber.Number).NotNull().WithMessage("Please specify contact's phone number.");
            RuleFor(phoneNumber => phoneNumber.Type).NotEmpty().WithMessage("Please specify contact's phone type.");
        }
    }
}