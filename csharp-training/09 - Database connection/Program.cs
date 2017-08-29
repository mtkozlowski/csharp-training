namespace _09___Database_connection
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbSqlCommand = new DbCommand(new SqlConnection("connectionSqlString"), "SqlInstruction");
            var dbOracleCommand = new DbCommand(new OracleConnection("connectionOracleString"), "OracleInstruction");
            dbSqlCommand.Execute();
            dbOracleCommand.Execute();
        }
    }
}
