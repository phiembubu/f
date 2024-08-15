using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class khachBLL
    {
        khachDAL khachDAL = new khachDAL(); 
        public string themkBLL(khachDTO khachDTO) {


            if (khachDTO.Tenkhach == null)
                return "ten";
            if (khachDTO.Nghenghiep == null)
                return "diachi";
            if (khachDTO.Diachi == null)
                return "nghenghiep";


            string info = khachDAL.themkDAL(khachDTO);
            return info;
        }
        public string suakbll(khachDTO khachDTO,int idk) {


            if (khachDTO.Tenkhach == null)
                return "ten";
            if (khachDTO.Nghenghiep == null)
                return "diachi";
            if (khachDTO.Diachi == null)
                return "nghenghiep";


            string info = khachDAL.suakdal(khachDTO,idk);
            return info;
        }
        public void xoakBLL(string idk)
        {
            khachDAL.xoakDAL(idk);
            
        }

    }
}
