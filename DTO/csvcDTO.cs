using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class csvcDTO
    {
        private string tenCSVC;
        private string tinhtrangCSVC;
        private string tenphong;
        private int idcsvc;
        public string TenCSVC { get => tenCSVC; set => tenCSVC = value; }
        public string TinhtrangCSVC { get => tinhtrangCSVC; set => tinhtrangCSVC = value; }
        public string Tenphong { get => tenphong; set => tenphong = value; }
        public int Idcsvc { get => idcsvc; set => idcsvc = value; }
    }
}
