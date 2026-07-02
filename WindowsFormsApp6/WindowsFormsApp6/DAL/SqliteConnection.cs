namespace WindowsFormsApp6.DAL
{
    public class SqliteConnection
    {
        private string connectionString;

        public SqliteConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}