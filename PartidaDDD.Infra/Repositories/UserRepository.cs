using PartidaDDD.Domain.Entities;
using PartidaDDD.Domain.Repositories;
using PartidaDDD.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace PartidaDDD.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private IDB _DB;

        public UserRepository(IDB db)
        {
            _DB = db;
        }

        public void Create(User user)
        {
            using (var con = _DB.GetConnection())
            {
                string sql = $"insert into [User](Name, Email, Phone, Password, Details, Sex, CPF, RG, Function)" +
                    $"values(@Name, @Email, @Phone, @Password, @Details, @Sex, @CPF, @RG, @FunvtionName)";
                con.Execute(sql, new
                {
                    Name = user.Name,
                    Email = user.Email.Address,
                    Phone = user.Phone,
                    Password = user.Password,
                    Details = user.Details,
                    Sex = user.Sex,
                    CPF = user.CPF.Number,
                    RG = user.RG.Number,
                    FunctionName = user.FunctionName
                });
            }
        }

        public bool Login(string nickname, string password)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }

        public User User(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<User> Users()
        {
            throw new NotImplementedException();
        }
    }
}
