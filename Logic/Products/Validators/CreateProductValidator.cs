using FluentValidation;
using Logic.Products.Commands;

namespace Logic.Products.Validators
{
    public class CreateProductValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
        }
    }
}
