using PartidaDDD.Shared.Commands;

namespace PartidaDDD.Domain.Commands.Results
{
    public class RegisterUserCommandResult : ICommandResult
    {
        public string Message { get; set; }
    }
}
