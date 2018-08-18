using FluentValidation;

namespace Model
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Street).NotEmpty().Length(5, 25).WithMessage("Please specify street address.");
            RuleFor(x => x.Number).NotNull().LessThan(15000).WithMessage("Please specify address number.");
            RuleFor(x => x.City).NotEmpty().Length(2, 20).WithMessage("Please specify city.");
            RuleFor(x => x.Zip).NotNull().LessThan(20000).WithMessage("Please specify ZIP code.");
            RuleFor(x => x.Country).NotEmpty().Length(3,25).WithMessage("Please specify country");
        }
    }
}
