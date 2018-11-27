using PartidaDDD.Domain.Entities;
using PartidaDDD.Domain.Repositories;
using PartidaDDD.Infra.Context;
using System;
using System.Data;
using System.Collections.Generic;
using Dapper;
using System.Linq;

namespace PartidaDDD.Infra.Repositories
{
    public class CarRepository : ICarRepository
    {
        private IDB _DB;

        public CarRepository(IDB db)
        {
            _DB = db;
        }

        public List<Car> GetAll()
        {
            using (var con = _DB.GetConnection())
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = $"select [Model], [Brand], [Year] from Car";
                
                return con.Query<Car>(sql).ToList();
            }
        }

        public Car Details(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> FindByColor(string color)
        {
            using (var con = _DB.GetConnection())
            {
                string sql = $"select [Model], [Brand], [Year] from Car where Color = '{color}'";
                return con.Query<Car>(sql, commandType: CommandType.Text).ToList();
            }
        }

        public List<Car> FindByModel(string model)
        {
            using (var con = _DB.GetConnection())
            {
                string sql = $"select [Model], [Brand], [Year] from Car where Model = {model}";
                return con.Query<Car>(sql, commandType: CommandType.Text).ToList();
            }
        }

        public List<Car> FindByOrigin(string origin)
        {
            using (var con = _DB.GetConnection())
            {
                string sql = $"select [Model], [Brand], [Year] from Car where Origin = {origin}";
                return con.Query<Car>(sql, commandType: CommandType.Text).ToList();
            }
        }

        public List<Car> FindByYear(int year)
        {
            using (var con = _DB.GetConnection())
            {
                string sql = $"select [Model], [Brand], [Year] from Car where Year = {year}";
                return con.Query<Car>(sql, commandType: CommandType.Text).ToList();
            }
        }

        public void NewCar(Car car)
        {
            using (var con = _DB.GetConnection())
            {
                string sql = $"insert into Car(Origin, Model, Brand, Chassis, Doors, Steering, Transmission, EletronicWindow, Color, Year, Image, Price) values(@origin, @model, @brand, @chassis, @doors, @steering, @transmission, @eletronicWindow, @color, @year, @image, @price)";

                con.Execute(sql, new
                {
                    origin = car.Factory.Origin,
                    model = car.Model,
                    brand = car.Brand,
                    chassis = car.Factory.Chassis,
                    doors = car.Factory.Doors,
                    steering = car.Factory.Steering,
                    transmission = car.Factory.Transmission,
                    eletronicWindow = car.Factory.EletricWindow,
                    color = car.Factory.Color,
                    year = car.Year,
                    image = car.Image,
                    price = car.Price
                });
            }
        }
    }
}
