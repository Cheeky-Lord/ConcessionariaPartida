using PartidaDDD.Domain.Entities;
using System;
using System.Collections.Generic;

namespace PartidaDDD.Domain.Repositories
{
    public interface ICarRepository
    {
        void NewCar(Car car);
        List<Car> Cars();
        Car Details(Guid id);
    }
}
