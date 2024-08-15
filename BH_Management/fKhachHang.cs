using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace BH_Management
{
    public partial class fKhachHang : Form
    {
        khachBLL khachBLL = new khachBLL();
        khachDTO khachDTO = new khachDTO();
        int idk;
        public fKhachHang()
        {
            InitializeComponent();
            pnThemKH.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            pnThemKH.Show();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            pnThemKH.Hide();
        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNTDataSet27.KhachThue' table. You can move, or remove it, as needed.
            this.khachThueTableAdapter3.Fill(this.qLNTDataSet27.KhachThue);
            // TODO: This line of code loads data into the 'qLNTDataSet23.KhachThue' table. You can move, or remove it, as needed.
           
            

        }

        private void themK(object sender, EventArgs e)
        {
            khachDTO.Tenkhach = guna2TextBox2.Text;
            khachDTO.Gioitinh = guna2TextBox3.Text;
            khachDTO.Cccd = Convert.ToInt64(guna2TextBox4.Text);
            khachDTO.Sdt = Convert.ToInt32(guna2TextBox5.Text);
            khachDTO.Diachi = guna2TextBox6.Text;
            khachDTO.Nghenghiep = guna2TextBox7.Text;
            string info;
            if (guna2TextBox4.Text == "")
            {
                info = "cccd";
            }
            else
                info = khachBLL.themkBLL(khachDTO);

            switch (info)
            {
                case "ten":
                    MessageBox.Show("Ten khong duoc trong");
                    return;
                    case "cccd":
                    MessageBox.Show("CCCD khong duoc trong");
                    return;
                    case "diachi":
                    MessageBox.Show("Dia chi khong duoc trong");
                    return;
                    case "nghenghiep":
                    MessageBox.Show("Nghe nghiep khong duoc trong");
                    return;
            }

            this.khachThueTableAdapter1.Fill(this.qLNTDataSet18.KhachThue);
            MessageBox.Show(info);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string info;
            idk = Convert.ToInt32(guna2DataGridView1.SelectedCells[0].Value.ToString());
            khachDTO.Cccd = Convert.ToInt64(guna2DataGridView1.SelectedCells[1].Value.ToString());
            khachDTO.Tenkhach = guna2DataGridView1.SelectedCells[2].Value.ToString();
            khachDTO.Diachi = guna2DataGridView1.SelectedCells[3].Value.ToString();
            khachDTO.Gioitinh = guna2DataGridView1.SelectedCells[4].Value.ToString();
            khachDTO.Sdt = Convert.ToInt32(guna2DataGridView1.SelectedCells[5].Value.ToString());
            khachDTO.Nghenghiep = guna2DataGridView1.SelectedCells[6].Value.ToString();

            if (guna2DataGridView1.SelectedCells[1].Value.ToString() == "")
            {
                info = "cccd";
            }
            else
                info = khachBLL.suakbll(khachDTO, idk);
            switch (info)
            {
                case "ten":
                    MessageBox.Show("Ten khong duoc trong");
                    return;
                case "cccd":
                    MessageBox.Show("CCCD khong duoc trong");
                    return;
                case "diachi":
                    MessageBox.Show("Dia chi khong duoc trong");
                    return;
                case "nghenghiep":
                    MessageBox.Show("Nghe nghiep khong duoc trong");
                    return;
            }
            MessageBox.Show("Sua Thanh Cong ");
            this.khachThueTableAdapter1.Fill(this.qLNTDataSet18.KhachThue);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string idk =  guna2DataGridView1.SelectedCells[0].Value.ToString();
            khachBLL.xoakBLL(idk);
            MessageBox.Show("Xoa thanh cong");
            this.khachThueTableAdapter1.Fill(this.qLNTDataSet18.KhachThue);
        }

    }
}
