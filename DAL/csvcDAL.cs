using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class csvcDAL:Database
    {
        public string themCSVCDAL(csvcDTO csvtDTO)
        {
            string info = themcsvcDatabase(csvtDTO);
            return info;

        }
        public string suaCSVCDAL(csvcDTO csvtDTO)
        {
            string info = suacsvcDatabase(csvtDTO);
            return info;

        }
        public void xoaCSVCDAL(csvcDTO csvtDTO)
        {
             xoacsvcDatabase(csvtDTO);
            

        }

        public List<String> listDataDAL()
        {
            List<String> info = loadCombobox();
            return info;

        }
    }
}
