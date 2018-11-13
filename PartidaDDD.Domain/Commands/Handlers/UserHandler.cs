using PartidaDDD.Domain.Commands.Inputs;
using PartidaDDD.Domain.Commands.Results;
using PartidaDDD.Domain.Entities;
using PartidaDDD.Domain.Repositories;
using PartidaDDD.Domain.ValueObjects;
using PartidaDDD.Shared.Commands;

namespace PartidaDDD.Domain.Commands.Handlers
{
    public class UserHandler : ICommandHandler<RegisterUser>
    {
        private IUserRepository _userRepository;

        public UserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public ICommandResult Handler(RegisterUser command)
        {
            Email email = new Email(command.Email);
            Document cpf = new Document(command.CPF);
            Document rg = new Document(command.RG);

            User user = new User(command.Name, email, command.Phone, command.Password, command.Details, command.Sex, cpf, rg, command.Function);

            _userRepository.Create(user);

            RegisterUserCommandResult result = new RegisterUserCommandResult();
            result.Message = "Usuário cadastrado com sucesso.";

            return result;
        }
    }
}
