using PartidaDDD.Domain.ValueObjects;
using PartidaDDD.Shared.Entities;

namespace PartidaDDD.Domain.Entities
{
    public class User : Entity
    {
        public string Name { get; private set; }
        public string NickName { get; private set; }
        public Email Email { get; private set; }
        public string Password { get; private set; }
        public string Phone { get; private set; }
        public Document Document { get; private set; }

        public User(string name, string nickName, Email email, string password, string phone, Document document)
        {
            Name = name;
            NickName = nickName;
            Email = email;
            Password = password;
            Phone = phone;
            Document = document;
        }
    }
}
