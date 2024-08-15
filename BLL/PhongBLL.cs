using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class PhongBLL
    {
        PhongDAL pDAL = new PhongDAL();
        public string thempbll(PhongDTO phongDTO)
        {
            
            if (phongDTO.TenPhong == "")
            {
                return "requeid_tenphong";
            }
            string info = pDAL.themp(phongDTO);
            return info;
        }
        public string themhdbll(PhongDTO phongDTO )
        {
            
            if (phongDTO.TenPhong == "")
            {
                return "requeid_tenphong";
            }
            string info = pDAL.themhdDAL(phongDTO);
            return info;
        }
        public string suapbll(PhongDTO phongDTO,int id)
        {
            
            if (phongDTO.TenPhong == "")
            {
                return "requeid_tenphong";
            }
            string info = pDAL.suapdal(phongDTO,id);
            return info;
        }
        //public void xoapBLL(string id)
        //{
            
            
        //    pDAL.xoapdal(id);
            
        //}

    }
}
