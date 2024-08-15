using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class hdDAL:Database
    {
        public List<string> listDataDAL() {
            List<String> info = loadComboboxhd();
            return info;
        }
        public string[] tienDAL(string phong) {
            string[] info = tienDV(phong);
            return info;
        }
        public string lhd(hdDTO hdDTO)
        {
            string info = lhdDatabase(hdDTO);
            return info;
        }
        public void xoahdDAL(string mhd)
        {
          xoahdDatabase(mhd);
            
        }

        public string suahddal(hdDTO hdDTO, int mhd)
        {
            string info = suahdDatabase(hdDTO, mhd);
            return info;
        }

    }
}
