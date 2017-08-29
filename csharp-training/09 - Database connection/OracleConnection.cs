using System;

namespace _09___Database_connection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opened OracleConnection.");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closed OracleConnection.");
        }
    }
}