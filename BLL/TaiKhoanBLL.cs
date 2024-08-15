using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL tkDAL = new TaiKhoanDAL(); 
        public string login(TaiKhoanDTO tk)
        {
            if (tk.Tk == "")
            {
                return "requeid_taikhoan";
            }
            if (tk.Mk == "")
            {
                return "requeid_matkhau";
            }
            string info = tkDAL.login(tk);
            return info;
        }

    }
}
