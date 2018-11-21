using PartidaDDD.Domain.Entities;
using System.Collections.Generic;

namespace PartidaDDD.Domain.Repositories
{
    public interface ICustomerRepository
    {
        void Create(Customer customer);
        void Edit(Customer customer);
        void Delete(int id);
        Customer FindById(int id);
        List<Customer> FindAll();
    }
}
