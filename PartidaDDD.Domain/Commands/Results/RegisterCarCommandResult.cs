using PartidaDDD.Shared.Commands;

namespace PartidaDDD.Domain.Commands.Results
{
    public class RegisterCarCommandResult : ICommandResult
    {
        public string Message { get; set; }
    }
}
