using BLL;
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
using Guna.UI2.WinForms;
using System.Collections;
namespace BH_Management
{
    public partial class fHoaDon : Form
    {
        int tiendien, tiennuoc, tienwifi,mhd;
        string ngay;
        hdBLL hdBLL = new hdBLL();
        hdDTO hdDTO = new hdDTO();
        dvDTO dvDTO = new dvDTO();
        public fHoaDon()
        {
            InitializeComponent();
            pnAddhoaDon.Hide();
            
            ngay = dateTimePicker1.Value.ToLongDateString();
            
            
            timer1.Start();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {


           pnAddhoaDon.Show();
        }

        private void guna2ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            //string[] tien = hdBLL.tienBLL(guna2ComboBox1.Text);
            //guna2TextBox5.Text = tien[0];
            //guna2TextBox1.Text = tien[1];
            //guna2TextBox2.Text = tien[2];
            //tiendien = Convert.ToInt32(tien[0]);
            //tiennuoc = Convert.ToInt32(tien[1]);
            //tienwifi = Convert.ToInt32(tien[2]);
            //int sum = tiendien+tiennuoc+tienwifi;
            //guna2TextBox4.Text = sum.ToString();

        }

        private void themHD(object sender, EventArgs e)
        {


            //if (guna2CheckBox1.Checked == false)
            //    hdDTO.TrangThai = "Da Thanh Toan";
            //else
            //    hdDTO.TrangThai = "Chua Thanh Toan";

            //hdDTO.TenPhong = guna2ComboBox1.Text;
            hdDTO.NgayLap = guna2DateTimePicker1.Value;
            
            hdDTO.Tongtien = Convert.ToInt32(guna2TextBox4.Text);


            string info = hdBLL.lhd(hdDTO);
            if (info == "Tong Tien Khong Duoc Trong")
                MessageBox.Show(info);
            else
            {
                MessageBox.Show("Them thanh cong");
                this.hoaDonTableAdapter1.Fill(this.qLNTDataSet12.HoaDon);
            }
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2TextBox4.Text == "")
                guna2TextBox4.Text = "0";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string mhd = guna2DataGridView1.SelectedCells[4].Value.ToString();
            hdBLL.xoahdBLL(mhd);
            MessageBox.Show("Xoa thanh cong");
            this.hoaDonTableAdapter2.Fill(this.qLNTDataSet26.HoaDon);
        }

      

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string info;
            hdDTO.TenPhong = guna2DataGridView1.SelectedCells[0].Value.ToString();
            mhd = Convert.ToInt32(guna2DataGridView1.SelectedCells[4].Value.ToString());
            hdDTO.NgayLap = Convert.ToDateTime(guna2DataGridView1.SelectedCells[1].Value.ToString());
            hdDTO.Tongtien = Convert.ToInt32(guna2DataGridView1.SelectedCells[2].Value.ToString());
            hdDTO.TrangThai = guna2DataGridView1.SelectedCells[3].Value.ToString();

            if (guna2DataGridView1.SelectedCells[1].Value.ToString() == "")
                info = "Ngay lap khong duoc trong";
            if (guna2DataGridView1.SelectedCells[2].Value.ToString() == "")
                info = "Tong tien khong duoc trong";

            info = hdBLL.suahdbll(hdDTO,mhd);
            switch (info)
            {
                case "Ngay lap khong duoc trong":
                    MessageBox.Show(info);
                    return;
                case "Tong tien khong duoc trong":
                    MessageBox.Show(info);
                    return;
                case "Ten Phong Khong Duoc Trong":
                    MessageBox.Show(info);
                    return;
                case "Trang Thai Khong Duoc Trong":
                    MessageBox.Show(info);
                    return;
            }
            MessageBox.Show("Sua Thanh Cong ");
            this.hoaDonTableAdapter2.Fill(this.qLNTDataSet26.HoaDon);
        }

        private void guna2CircleButton2_Click_1(object sender, EventArgs e)
        {
            pnAddhoaDon.Hide();
        }

        private void fHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNTDataSet43.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter4.Fill(this.qLNTDataSet43.HoaDon);
            // TODO: This line of code loads data into the 'qLNTDataSet42.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter3.Fill(this.qLNTDataSet42.HoaDon);
            // TODO: This line of code loads data into the 'qLNTDataSet41.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.qLNTDataSet41.Phong);
            // TODO: This line of code loads data into the 'qLNTDataSet26.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter2.Fill(this.qLNTDataSet26.HoaDon);
            // TODO: This line of code loads data into the 'qLNTDataSet12.HoaDon' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'qLNTDataSet4.HoaDon' table. You can move, or remove it, as needed.
            //this.hoaDonTableAdapter.Fill(this.qLNTDataSet4.HoaDon);

        }
    }
}
