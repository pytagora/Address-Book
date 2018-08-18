using FluentValidation;

namespace Model
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(contact => contact.FirstName).NotEmpty().Length(3,20).WithMessage("Please specify contact's first name.");
            RuleFor(contact => contact.LastName).NotEmpty().Length(3,20).WithMessage("Please specify contact's last name.");
            RuleFor(contact => contact.BirthPlace).NotEmpty().Length(3, 30).WithMessage("Please specify contact's birth place.");
            RuleFor(contact => contact.Gender).NotNull().WithMessage("Please specify contact's gender.");
            RuleFor(contact => contact.Comment).MaximumLength(200).WithMessage("Please enter comment about contact under 200 characters.");
        }
    }
}