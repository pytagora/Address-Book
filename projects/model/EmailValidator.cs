using FluentValidation;

namespace Model
{
    public class EmailValidator : AbstractValidator<Email>
    {
        public EmailValidator()
        {
            RuleFor(email => email.Address).NotNull().EmailAddress().WithMessage("Please specify email address.");
            RuleFor(email => email.Type).NotEmpty().Length(1,15).WithMessage("Please specify email type.");
        }
    }
}