using FluentValidator;
using PartidaDDD.Domain.Helpers;

namespace PartidaDDD.Domain.ValueObjects
{
    public class Document : Notifiable
    {
        ValidateHelper validateHelper = new ValidateHelper();
        public string Number { get; private set; }

        public Document(string number)
        {
            Number = number;
        }

        public bool ValidateCPF(string document)
        {
            bool validated = validateHelper.ValidateCPF(Number);

            return validated;
        }

        public bool validateCNPJ(string cnpj)
        {
            bool validated = validateHelper.ValidateCNPJ(Number);

            return validated;
        }
    }
}
