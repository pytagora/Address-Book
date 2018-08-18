using FluentValidation;

namespace Model
{
    public class EmailValidator : AbstractValidator<Email>
    {
        public EmailValidator()
        {
            RuleFor(x => x.Address).NotNull().EmailAddress().WithMessage("Please specify email address.");
            RuleFor(x => x.Type).NotEmpty().Length(1,15).WithMessage("Please specify email type.");
        }
    }
}