using FluentValidation;

namespace Model
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().Length(3,20).WithMessage("Please specify contact's first name.");
            RuleFor(x => x.LastName).NotEmpty().Length(3,20).WithMessage("Please specify contact's last name.");
            RuleFor(x => x.BirthPlace).NotEmpty().Length(3, 30).WithMessage("Please specify contact's birth place.");
            RuleFor(x => x.Gender).NotNull().WithMessage("Please specify contact's gender.");
            RuleFor(x => x.Comment).MaximumLength(200).WithMessage("Please enter comment about contact under 200 characters.");
        }
    }
}