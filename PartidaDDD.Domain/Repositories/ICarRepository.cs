using PartidaDDD.Domain.Entities;
using System;
using System.Collections.Generic;

namespace PartidaDDD.Domain.Repositories
{
    public interface ICarRepository
    {
        void NewCar(Car car);
        List<Car> GetAll();
        Car Details(int id);
        List<Car> FindByModel(string model);
        List<Car> FindByYear(int year);
        List<Car> FindByColor(string color);
        List<Car> FindByOrigin(string origin);
    }
}
