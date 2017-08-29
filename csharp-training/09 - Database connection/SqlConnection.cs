using System;

namespace _09___Database_connection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opened SqlConnection.");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closed SqlConnection");
        }
    }
}