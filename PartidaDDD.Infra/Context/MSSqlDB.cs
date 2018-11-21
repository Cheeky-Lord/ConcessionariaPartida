using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace PartidaDDD.Infra.Context
{
    public class MSSqlDB : IDB
    {
        private SqlConnection DB;
        private string ConnectionString;

        // SQLite
        private SQLiteConnection sqliteCon;

        public MSSqlDB(IDBConfiguration config)
        {
            ConnectionString = config.ConnectionString;
        }

        public void Dispose()
        {
            DB.Close();
            DB.Dispose();
        }

        public IDbConnection GetConnection()
        {
            DB = new SqlConnection(ConnectionString);
            return DB;
            //sqliteCon = new SQLiteConnection(ConnectionString);
            //return sqliteCon;
        }
    }
}
