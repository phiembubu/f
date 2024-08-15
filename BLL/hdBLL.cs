using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class hdBLL
    {
        hdDAL hdDAL = new hdDAL();
        
        public List<string> listData()
        {

            List<string> info = hdDAL.listDataDAL();
            return info;
        }
        public string[] tienBLL(string phong)
        {

            string[] info = hdDAL.tienDAL(phong);
            return info;
        }
        public string lhd(hdDTO hdDTO)
        {
            if ( hdDTO.Tongtien == 0)
                return "Tong Tien Khong Duoc Trong";

            string info = hdDAL.lhd(hdDTO);
            return info;
        }
        public void xoahdBLL(string mhd)
        {
             hdDAL.xoahdDAL(mhd);
        }
        public string suahdbll(hdDTO hdDTO,int mhd)
        {
            if ( hdDTO.TenPhong == "")
                return "Ten Phong Khong Duoc Trong";
            if ( hdDTO.TrangThai == "")
                return "Trang Thai Khong Duoc Trong";

            string info = hdDAL.suahddal(hdDTO, mhd);
            return info;
        }

    }
}
