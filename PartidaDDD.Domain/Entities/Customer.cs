using PartidaDDD.Domain.ValueObjects;
using PartidaDDD.Shared.Entities;

namespace PartidaDDD.Domain.Entities
{
    public class Customer : Entity
    {
        public string Name { get; private set; }
        public string SocialName { get; private set; }
        public Document Document { get; private set; }
        public string Phone1 { get; private set; }
        public string Phone2 { get; private set; }
        public string Phone3 { get; private set; }
        public Email Email { get; private set; }
        public string Type { get; private set; }
        public string Image { get; private set; }
        public Address Address { get; private set; }
        public string Description { get; private set; }
        public string About { get; private set; }

        public Customer(string name, string socialName, Document document, string phone1, string phone2, string phone3, Email email, string type, string image, Address address, string description, string about)
        {
            Name = name;
            SocialName = socialName;
            Document = document;
            Phone1 = phone1;
            Phone2 = phone2;
            Phone3 = phone3;
            Email = email;
            Type = type;
            Image = image;
            Address = address;
            Description = description;
            About = about;
        }
    }
}
