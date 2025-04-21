using FluentValidation;
using MiniEcommerceServer.Application.ViewModels.Products;

namespace MiniEcommerceServer.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Zehmet olmasa mehsulun adini yazin")
                .MaximumLength(150)
                .MinimumLength(5)
                    .WithMessage("Zehmet olmasa mehsulun adini 5 ve 150 arasinda girin");

            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Zehmet olmasa stock melumatini yazin")
                .Must(s => s >= 0)
                    .WithMessage("Stock melumati menfi ola bilmez");

            RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Zehmet olmasa qiymeti daxil edin")
                .Must(s => s >= 0)
                    .WithMessage("Piymeti menfi ola bilmez");
        }
    }
}
