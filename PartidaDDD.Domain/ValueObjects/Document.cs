using FluentValidator;

namespace PartidaDDD.Domain.ValueObjects
{
    public class Document : Notifiable
    {
        public string Number { get; private set; }

        public Document(string number)
        {
            Number = number;
        }

        public bool ValidateCPF(string document)
        {
            // TODO
            return true;
        }
    }
}
