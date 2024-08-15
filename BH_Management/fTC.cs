using System;
using System.Windows.Forms;

namespace BH_Management
{
    public partial class fTC : Form
    {
        private fPhong fphong;
        private fTongKet fChiTiet;
        private fHoaDon fhoadon;
        private fKhachHang fkhachhang;
        private fCSVC fcsvc;
        private fdichVu fDV;

        private bool menuPhongActive = false;
        private bool isSideExpanded = true;

        public fTC()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Đặt form hiện tại là một MDI container

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!menuPhongActive)
            {
                menuCon1.Height += 10;
                if (menuCon1.Height >= 127)
                {
                    timer1.Stop();
                    menuPhongActive = true;
                }
            }
            else
            {
                menuCon1.Height -= 10;
                if (menuCon1.Height <= 63)
                {
                    timer1.Stop();
                    menuPhongActive = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (fChiTiet == null)
            {
                fChiTiet = new fTongKet();
                fChiTiet.FormClosed += fChiTiet_FormClosed;
                fChiTiet.MdiParent = this;
                fChiTiet.Dock = DockStyle.Fill;
                fChiTiet.Show();
            }
            else
            {
                fChiTiet.Activate();
            }
        }
        private void fChiTiet_FormClosed(object sender, FormClosedEventArgs e)
        {
            fChiTiet = null;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isSideExpanded)
            {
                container.Width -= 10;
                if (container.Width <= 64)
                {
                    isSideExpanded = false;
                    timer2.Stop();
                }
            }
            else
            {
                container.Width += 10;
                if (container.Width >= 237)
                {
                    isSideExpanded = true;
                    timer2.Stop();
                }
            }
        }

        private void ptMenuContainer_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //đây là buton form thu chi tổng kết
        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            if (fphong == null)
            {
                fphong = new fPhong();
                fphong.FormClosed += fphong_FormClosed;
                fphong.MdiParent = this;
                fphong.Dock = DockStyle.Fill;
                fphong.Show();
            }
            else
            {
                fphong.Activate();
            }
        }
        private void fphong_FormClosed(object sender, FormClosedEventArgs e)
        {
            fphong = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fhoadon == null)
            {
                fhoadon = new fHoaDon();
                fhoadon.FormClosed += fhoadon_FormClosed;
                fhoadon.MdiParent = this;
                fhoadon.Dock = DockStyle.Fill;
                fhoadon.Show();
            }
            else
            {
                fhoadon.Activate();
            }
        }
        private void fhoadon_FormClosed(object sender, FormClosedEventArgs e)
        {
            fhoadon = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (fkhachhang == null)
            {
                fkhachhang = new fKhachHang();
                fkhachhang.FormClosed += fkhachhang_FormClosed;
                fkhachhang.MdiParent = this;
                fkhachhang.Dock = DockStyle.Fill;
                fkhachhang.Show();
            }
            else
            {
                fkhachhang.Activate();
            }
        }
        private void fkhachhang_FormClosed(object sender, FormClosedEventArgs e)
        {
            fkhachhang = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (fcsvc == null)
            {
                fcsvc = new fCSVC();
                fcsvc.FormClosed += fcsvc_FormClosed;
                fcsvc.MdiParent = this;
                fcsvc.Dock = DockStyle.Fill;
                fcsvc.Show();
            }
            else
            {
                fcsvc.Activate();
            }
        }
        private void fcsvc_FormClosed(object sender, FormClosedEventArgs e)
        {
            fcsvc = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (fDV == null)
            {
                fDV = new fdichVu();
                fDV.FormClosed += fDV_FormClosed;
                fDV.MdiParent = this;
                fDV.Dock = DockStyle.Fill;
                fDV.Show();
            }
            else
            {
                fDV.Activate();
            }
        }
        private void fDV_FormClosed(object sender, FormClosedEventArgs e)
        {
            fDV = null;
        }


    }
}
