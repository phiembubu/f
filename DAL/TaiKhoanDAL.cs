using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class TaiKhoanDAL:Database
    {
        public string login(TaiKhoanDTO taiKhoanDTO)
        {
            string info = loginDatabase(taiKhoanDTO);
            return info;

        }

    }
}
