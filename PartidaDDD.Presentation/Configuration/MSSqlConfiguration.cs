using PartidaDDD.Infra.Context;

namespace PartidaDDD.Presentation.Configuration
{
    public class MSSqlConfiguration : IDBConfiguration
    {
        public string ConnectionString { get => @"Server=DESKTOP-6QC1PQO;Database=ConcessionariaPartida;User Id=sa;Password=123;"; }
    }
}
