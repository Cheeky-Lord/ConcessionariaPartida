using FluentValidator;

namespace PartidaDDD.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public string Address { get; private set; }

        public Email(string address)
        {
            Address = address;
            new ValidationContract<Email>(this)
                .IsEmail(x => x.Address, "Inválid email")
                .IsRequired(x => x.Address, "Email is required.");
        }
    }
}
