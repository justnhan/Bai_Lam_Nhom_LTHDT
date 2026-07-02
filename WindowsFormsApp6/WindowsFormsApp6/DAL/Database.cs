using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.DAL
{
    public static class Database
    {
        private const string CONN = "Data Source=CSDL.sqlite";

        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(CONN);
        }
    }
}
