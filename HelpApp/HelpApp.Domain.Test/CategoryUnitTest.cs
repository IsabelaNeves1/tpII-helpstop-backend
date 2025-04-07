using HelpApp.Domain.Entities;
using FluentAssertions;
using Xunit;

namespace HelpApp.Domain.Test
{
    public class CategoryUnitTest
    {
        #region Testes Positivos
        [Fact(DisplayName = "Create Category With Valid State")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }
        [Fact(DisplayName = "Create Category With Alone Name")]
        public void CreateCategory_WithAloneName_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }
        #endregion
        #region Testes Negativos
        [Fact(DisplayName ="Create Category With Name Empty")]
        public void CreateCategory_WithNameEmpty_ResultObjetcException()
        {
            Action action = () => new Category(1, "");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, name is required.");
        }
        [Fact(DisplayName = "Create Category With Name Empty")]
        public void CreateCategory_WithIdInvalid_ResultObjetcException()
        {
            Action action = () => new Category(-1, "");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id value.");
        }
        [Fact(DisplayName = "Create Category With Too Short")]
        public void CreateCategory_WithTooShort_ResultObjetcException()
        {
            Action action = () => new Category(1, "Ca");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, too short, minimum 3 characters.");
        }
        #endregion
    }
}
