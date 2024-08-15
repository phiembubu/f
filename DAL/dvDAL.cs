using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dvDAL:Database
    {
        public List<string> listDataDAL() {
                List<String> info = loadComboboxdv();
                return info;
          
        }
        public string themdvDAL(dvDTO dvDTO)
        {
            string info = themdvDatabase(dvDTO);
            return info;
        }
        public string suadvDAL(dvDTO dvDTO)
        {
            string info = suadvDatabase(dvDTO);
            return info;
        }public void xoadvDAL(dvDTO dvDTO)
        {
             xoadvDatabase(dvDTO);
            
        }
        public string layidthueDAL(string phong)
        {
            string info = layidthueDatabase(phong);
            return info;
        }
    }
}
