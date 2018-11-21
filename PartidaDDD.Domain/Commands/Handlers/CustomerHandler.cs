using PartidaDDD.Domain.Commands.Inputs;
using PartidaDDD.Domain.Commands.Results;
using PartidaDDD.Domain.Entities;
using PartidaDDD.Domain.Repositories;
using PartidaDDD.Domain.ValueObjects;
using PartidaDDD.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidaDDD.Domain.Commands.Handlers
{
    public class CustomerHandler : ICommandHandler<RegisterCustomer>
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public ICommandResult Handler(RegisterCustomer command)
        {
            // Instancia objetos de valor.
            Document document = new Document(command.Document);
            Email email = new Email(command.Email);
            Address address = new Address(command.Number, command.CEP, command.Street, command.Neighborhood, command.City, command.State);

            // Instancia entidade.
            Customer customer = new Customer(command.Name, command.SocialName, document, command.Phone1, command.Phone2, command.Phone3, email, command.Type, command.Image, address, command.Description, command.About);

            // Persiste no banco.
            _customerRepository.Create(customer);


            RegisterCustomerCommandResult result = new RegisterCustomerCommandResult();
            result.Message = "Cliente cadastrado com sucesso.";

            // Retorna o resultado.
            return result;
        }
    }
}
