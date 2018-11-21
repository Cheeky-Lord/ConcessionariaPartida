using PartidaDDD.Shared.Commands;

namespace PartidaDDD.Domain.Commands.Inputs
{
    public class RegisterCustomer : ICommand
    {
        public string Name { get; set; }
        public string SocialName { get; set; }
        public string Document { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public string Number { get; set; }
        public string CEP { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Description { get; set; }
        public string About { get; set; }
    }
}
