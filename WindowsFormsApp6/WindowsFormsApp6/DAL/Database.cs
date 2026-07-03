using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Lam_Nhom_LTHDT.DAL
{
    public static class Database
    {
        private const string CONN = "Data Source=CSDL.sqlite";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(CONN);
        }
    }
}
