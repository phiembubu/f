using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dvDTO
    {
        private string tenPhong;
        private int chiSoDienCu, chiSoDienMoi, tienDien, tienNuoc, tienWifi, soNguoiSuDung,idThue;
        private DateTime ngayLap;
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public int ChiSoDienCu { get => chiSoDienCu; set => chiSoDienCu = value; }
        public int ChiSoDienMoi { get => chiSoDienMoi; set => chiSoDienMoi = value; }
        public int TienDien { get => tienDien; set => tienDien = value; }
        public int TienNuoc { get => tienNuoc; set => tienNuoc = value; }
        public int TienWifi { get => tienWifi; set => tienWifi = value; }
        public int SoNguoiSuDung { get => soNguoiSuDung; set => soNguoiSuDung = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public int IdThue { get => idThue; set => idThue = value; }
    }
}
