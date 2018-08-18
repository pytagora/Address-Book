using FluentValidation;

namespace Model
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(address => address.Street).NotEmpty().Length(5, 25).WithMessage("Please specify street address.");
            RuleFor(address => address.Number).NotNull().LessThan(15000).WithMessage("Please specify address number.");
            RuleFor(address => address.City).NotEmpty().Length(2, 20).WithMessage("Please specify city.");
            RuleFor(address => address.Zip).NotNull().LessThan(20000).WithMessage("Please specify ZIP code.");
            RuleFor(address => address.Country).NotEmpty().Length(3,25).WithMessage("Please specify country");
        }
    }
}
