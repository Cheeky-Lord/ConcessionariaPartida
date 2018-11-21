using PartidaDDD.Shared.Commands;

namespace PartidaDDD.Domain.Commands.Results
{
    public class RegisterCustomerCommandResult : ICommandResult
    {
        public string Message { get; set; }
    }
}
