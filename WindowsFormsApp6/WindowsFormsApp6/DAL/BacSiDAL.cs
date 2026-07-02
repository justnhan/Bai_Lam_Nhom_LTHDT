using Bai_Lam_Nhom_LTHDT.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.DAL
{
    public class BacSiDAL : IBacSiDAL
    {
        private readonly SqliteConnection con;
        private string error = "";

        // lấy kết nối trước từ class Database rồi sau đó mới mở sử dụng ở các hàm dưới
        public BacSiDAL()
        {
            con = Database.GetConnection();
        }

        

        public List<BacSi> GetAllBacSi()
        {
            
        }
        
        public BacSi GetByMaBS(string maBS)
        {
            
        }

        public bool Add(BacSi bacSi)
        {
            
        }

        public bool Update(BacSi bacSi)
        {

        }

        public bool DeleteByMaBS(string maBS)
        {

        }

        public string GetError()
        {
            return error;
        }


    }
}
