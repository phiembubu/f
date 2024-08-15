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
    public class dvBLL
    {
        dvDAL dvDAL = new dvDAL();
        public List<string> listData()
        {
            List<string> info = dvDAL.listDataDAL();
            return info;
        }
        public string themdvBLL(dvDTO dvDTO)
        {
            string info = dvDAL.themdvDAL(dvDTO);
            return info;
        }
        public string suadvBLL(dvDTO dvDTO)
        {
            string info = dvDAL.suadvDAL(dvDTO);
            return info;
        }
         public void xoadvBLL(dvDTO dvDTO)
        {
             dvDAL.xoadvDAL(dvDTO);
            
        }

        public string layidthueBLL(string phong)
        {
            string info = dvDAL.layidthueDAL(phong);
            return info;
        }
    }
}
