using FluentValidation;

namespace Model
{
    public class SocialAccountValidator : AbstractValidator<SocialAccount>
    {
        public SocialAccountValidator()
        {
            RuleFor(socialAccount => socialAccount.Id).NotEmpty().WithMessage("Please specify social account id.");
            RuleFor(socialAccount => socialAccount.Network).NotEmpty().MaximumLength(15).WithMessage("Please specify social account network.");
        }
    }
}