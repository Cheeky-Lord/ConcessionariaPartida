using PartidaDDD.Domain.Entities;
using System;
using System.Collections.Generic;

namespace PartidaDDD.Domain.Repositories
{
    public interface IUserRepository
    {
        void Create(User user);
        void Update(User user);
        bool Login(string nickname, string password);
        List<User> Users();
        User User(Guid id);
    }
}
