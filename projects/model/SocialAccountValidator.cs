using FluentValidation;

namespace Model
{
    public class SocialAccountValidator : AbstractValidator<SocialAccount>
    {
        public SocialAccountValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Please specify social account id.");
            RuleFor(x => x.SocialNetwork).NotEmpty().MaximumLength(15).WithMessage("Please specify social account network.");
        }
    }
}
