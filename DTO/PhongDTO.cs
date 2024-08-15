using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongDTO
    {
        private string tenPhong,tenKhach;
        private int giaPhong,tienNo;
        private string tinhTrang;
        private DateTime ngayThue, ngayTra;
        private long cccd;
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public int GiaPhong { get => giaPhong; set => giaPhong = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public int TienNo { get => tienNo; set => tienNo = value; }
        public string TenKhach { get => tenKhach; set => tenKhach = value; }
        public DateTime NgayThue { get => ngayThue; set => ngayThue = value; }
        public DateTime NgayTra { get => ngayTra; set => ngayTra = value; }
        public long Cccd { get => cccd; set => cccd = value; }
    }
}
