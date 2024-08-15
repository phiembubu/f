using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class khachDTO
    {
        private int sdt;
        private long cccd ;
       private string tenkhach, diachi, nghenghiep,gioitinh;

        public long Cccd { get => cccd; set => cccd = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        public string Tenkhach { get => tenkhach; set => tenkhach = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Nghenghiep { get => nghenghiep; set => nghenghiep = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
    }
}
