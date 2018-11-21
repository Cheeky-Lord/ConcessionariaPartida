using PartidaDDD.Domain.Entities;
using PartidaDDD.Domain.Repositories;
using PartidaDDD.Infra.Context;
using System;
using System.Collections.Generic;
using Dapper;

namespace PartidaDDD.Infra.Repositories
{
    public class CarRepository : ICarRepository
    {
        private IDB _DB;

        public CarRepository(IDB db)
        {
            _DB = db;
        }

        public List<Car> Cars()
        {
            throw new NotImplementedException();
        }

        public Car Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public void NewCar(Car car)
        {
            using (var con = _DB.GetConnection())
            {
                string sql = $"insert into Car(Name, Brand, Chassis, Doors, HydraulicSteering, Automatic, Year) values(@Name, @Brand, @Chassis, @Doors, @HydraulicSteering, @Automatic, @Year)";

                con.Execute(sql, new
                {
                    Name = car.Name,
                    Brand = car.Brand,
                    Chassis = car.Factory.Chassis,
                    Doors = car.Factory.Doors,
                    HydraulicSteering = car.Factory.HydraulicSteering,
                    Automatic = car.Factory.Automatic,
                    Year = car.Year
                });
            }
        }
    }
}
