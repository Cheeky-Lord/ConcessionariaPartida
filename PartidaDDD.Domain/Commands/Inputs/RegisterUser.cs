using PartidaDDD.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidaDDD.Domain.Commands.Inputs
{
    public class RegisterUser : ICommand
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Details { get; set; }
        public string Sex { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Function { get; set; }
    }
}
