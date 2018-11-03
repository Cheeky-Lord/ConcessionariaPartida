using System;
using System.Data;

namespace PartidaDDD.Infra.Context
{
    public interface IDB : IDisposable
    {
        IDbConnection GetConnection();
    }
}
