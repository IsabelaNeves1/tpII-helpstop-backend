using HelpApp.Domain.Validation;
using System.Collections.Generic;

namespace HelpApp.Domain.Entities
{
    public class Category
    {
        #region Atributos
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region Constructors
        public Category(string name)
        {
            Name = name;
        }

        public ICollection<Product> Products { get; set; }
        #endregion
        #region Validação
        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Invalid name, name is required");
            DomainExceptionValidation.When(Name.Length < 3,
                "Invalid name, too short, minum 3 characters. ");

            Name = name;
        }
        #endregion
    }
}
