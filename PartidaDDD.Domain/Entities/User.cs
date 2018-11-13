using PartidaDDD.Domain.ValueObjects;
using PartidaDDD.Shared.Entities;

namespace PartidaDDD.Domain.Entities
{
    public class User : Entity
    {
        public string Name { get; private set; }
        public Email Email { get; private set; }
        public string Phone { get; private set; }
        public string Password { get; private set; }
        public string Details { get; private set; }
        public string Sex { get; private set; }
        public Document CPF { get; private set; }
        public Document RG { get; private set; }
        public string FunctionName { get; private set; }

        public User(string name, Email email, string phone, string password, string details, string sex, Document cPF, Document rG, string functionName)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Password = password;
            Details = details;
            Sex = sex;
            CPF = cPF;
            RG = rG;
            FunctionName = functionName;
        }
    }
}
