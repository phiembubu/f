using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class PhongDAL:Database
    {
        public string themp(PhongDTO phongDTO)
        {

            string info = thempDatabase(phongDTO);
            return info;

        }
        public string themhdDAL(PhongDTO phongDTO)
        {

            string info = themhdDatabase(phongDTO);
            return info;

        }
        public string suapdal(PhongDTO phongDTO,int id)
        {

            string info = suapDatabase(phongDTO,id);
            return info;

        }
        //public void xoapdal(string id)
        //{

        //    string info = xoapDatabase(id);
           

        //}

    }
}
