using PartidaDDD.Domain.Entities;
using PartidaDDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using Dapper;
using PartidaDDD.Infra.Context;

namespace PartidaDDD.Infra.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private IDB _DB;

        public CustomerRepository(IDB DB)
        {
            _DB = DB;
        }

        public void Create(Customer customer)
        {
            using (var con = _DB.GetConnection())
            {
                string sql = $"insert into Customer(Name, SocialName, Document, Phone1, Phone2, Phone3, Email, Type, Image, Number, CEP, Street, Neighborhood, City, State, Description, About) values(@name, @socialName, @document, @phone1, @phone2, @phone3, @email, @type, @image, @number, @cep, @street, @neighborhood, @city, @state, @description, @about)";

                con.Execute(sql, new
                {
                    name = customer.Name,
                    socialName = customer.SocialName,
                    document = customer.Document.Number,
                    phone1 = customer.Phone1,
                    phone2 = customer.Phone2,
                    phone3 = customer.Phone3,
                    email = customer.Email.Address,
                    type = customer.Type,
                    image = customer.Image,
                    number = customer.Address.Number,
                    cep = customer.Address.CEP,
                    street = customer.Address.Street,
                    neighborhood = customer.Address.Neighborhood,
                    city = customer.Address.City,
                    state = customer.Address.State,
                    description = customer.Description,
                    about = customer.About
                });
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> FindAll()
        {
            throw new NotImplementedException();
        }

        public Customer FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
