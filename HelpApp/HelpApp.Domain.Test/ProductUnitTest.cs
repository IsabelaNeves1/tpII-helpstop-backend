using HelpApp.Domain.Entities;
using FluentAssertions;
using Xunit;
namespace HelpApp.Domain.Test
{
    public class ProductUnitTest
    {
        #region Testes Positivos
        [Fact(DisplayName = "Create Product, with parameters Valid")]
        public void CreateProduct_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }
        [Fact(DisplayName = "Create Product, with alone Id")]
        public void CreateProduct_WithAloneId_ResultObjectValidState()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }

        #endregion
        #region Testes Negativos
        [Fact(DisplayName = "Create Product With Negative Id")]
        public void CreateProduct_WithNegativeId_ResultObjectException()
        {
            Action action = () => new Product(-1, "Product Name", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Update Invalid Id value");
        }
        [Fact(DisplayName = "Create Product With Name NUll")]
        public void CreateProduct_WithNameNull_ResultObjetcException()
        {
            Action action = () => new Product(1, null, "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, name is required.");
        }
        [Fact(DisplayName = "Create Product With Name Too Short")]
        public void CreateProduct_WithNameTooShort_ResultObjetcException()
        {
            Action action = () => new Product(1, "Pr", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, too short, minimum 3 characters.");
        }
        [Fact(DisplayName = "Create Product With Name Empty")]
        public void CreateProduct_WithNameIsEmpty_ResultObjetcException()
        {
            Action action = () => new Product(1, "", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, name is required.");
        }
        [Fact(DisplayName = "Create Product With Invalid Description")]
        public void CreateProduct_WithInvalidDescription_ResultObjetcException()
        {
            Action action = () => new Product(1, "Product Name", null, 9.99m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description, description is required.");
        }
        [Fact(DisplayName = "Create Product With Too Short Description")]
        public void CreateProduct_WithTooShortDescription_ResultObjetcException()
        {
            Action action = () => new Product(1, "Product Name", "P", 9.99m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description, too short, minimum 5 characters.");
        }

        #endregion
    }
}
