using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class hdDTO
    {
        private string tenPhong,trangThai;
        private DateTime ngayLap;
        private int tongtien;

        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
    }
}
