using PartidaDDD.Domain.Commands.Inputs;
using PartidaDDD.Domain.Commands.Results;
using PartidaDDD.Domain.Entities;
using PartidaDDD.Domain.Repositories;
using PartidaDDD.Domain.ValueObjects;
using PartidaDDD.Shared.Commands;

namespace PartidaDDD.Domain.Commands.Handlers
{
    public class CarHandler : ICommandHandler<RegisterCar>
    {
        private readonly ICarRepository _carRepository;

        public CarHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public ICommandResult Handler(RegisterCar command)
        {
            Factory factory = new Factory(command.Origin, command.Chassis, command.Doors, command.Steering, command.Transmission, command.EletronicWindow, command.Color);

            Car car = new Car(command.Model, command.Brand, factory, command.Year, command.Image, command.Price);

            // Salva no banco.
            _carRepository.NewCar(car);

            // Gera mensagem de resultado.
            RegisterCarCommandResult result = new RegisterCarCommandResult();
            result.Message = "Carro registrado com sucesso";

            return result;
        }
    }
}
