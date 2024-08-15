using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class khachDAL:Database
    {
        public string themkDAL(khachDTO khachDTO)
        {
            string info = themkDatabase(khachDTO);
            return info;
        }
        public string suakdal(khachDTO khachDTO, int idk)
        {
            string info = suakDatabase(khachDTO,idk);
            return info;
        }
        public void xoakDAL(string idk)
        {
            khachDAL.xoakDatabase(idk);

        }
    }
}
