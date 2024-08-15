using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class csvcBLL
    {
        csvcDAL csvcDAL = new csvcDAL();
        
        public string themCSVCBLL(csvcDTO csvtDTO)
        {
            if (csvtDTO.TenCSVC == null)
            {
                return "tennull";
            }
 
            string info = csvcDAL.themCSVCDAL(csvtDTO);
            return info;

        }
        public string suaCSVCBLL(csvcDTO csvtDTO)
        {
            if (csvtDTO.TenCSVC == null)
            {
                return "tennull";
            }
 
            string info = csvcDAL.suaCSVCDAL(csvtDTO);
            return info;

        }
        public void xoacsvcBLL(csvcDTO csvtDTO)
        {
             csvcDAL.xoaCSVCDAL(csvtDTO);
        }

        public List<string> listData()
        {
            List<string> info = csvcDAL.listDataDAL();
            return info;

        }
    }
}
