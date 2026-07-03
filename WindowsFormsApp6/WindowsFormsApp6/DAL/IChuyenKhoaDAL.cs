using Bai_Lam_Nhom_LTHDT.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.DAL
{
    public interface IChuyenKhoaDAL
    {
        // Validate
        bool ExistsMaCK(string maCK);
        List<ChuyenKhoa> GetAllChuyenKhoa();
        ChuyenKhoa GetByMaCK(string maCK);
        bool Add(ChuyenKhoa chuyenKhoa);
        bool Update(ChuyenKhoa chuyenKhoa);
        bool DeleteByMaCK(string maCK);

        string GetError();
    }
}
