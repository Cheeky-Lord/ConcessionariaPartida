using PartidaDDD.Domain.Entities;
using System;
using System.Collections.Generic;

namespace PartidaDDD.Domain.Repositories
{
    public interface IUserRepository
    {
        bool Login(string nickname, string password);
        List<User> Users();
        User User(Guid id);
    }
}
