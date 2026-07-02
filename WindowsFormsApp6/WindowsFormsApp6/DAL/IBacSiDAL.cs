using Bai_Lam_Nhom_LTHDT.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.DAL
{
    public interface IBacSiDAL
    {
        List<BacSi> GetAllBacSi();
        BacSi GetByMaBS(string maBS);
        bool Add(BacSi bacSi);
        bool Update(BacSi bacSi);
        bool DeleteByMaBS(string maBS);

        string GetError();

    }
}
