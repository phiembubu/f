using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace BH_Management
{
    public partial class fPhong : Form
    {
        PhongBLL phongBLL =new PhongBLL();
        PhongDTO phongDTO = new PhongDTO();
        int id;
        public fPhong()
        {
            InitializeComponent();
            guna2Panel1.Hide();
            pnSua.Hide();
            pnXemdanhSachP.Hide();

        }

        private void pnADDPhog_Click(object sender, EventArgs e)
        {
            //phongDTO.TenPhong = comboBox1.Text;
            ////phongDTO.GiaPhong = Convert.ToInt32(guna2TextBox4.Text);
            //phongDTO.TenKhach = guna2TextBox7.Text;
            //phongDTO.TienNo = Convert.ToInt32(guna2TextBox6.Text);
            //phongDTO.NgayThue = guna2DateTimePicker1.Value;
            //phongDTO.NgayTra = guna2DateTimePicker2.Value;
            //phongDTO.Cccd = Convert.ToInt64(guna2TextBox7.Text);
            //string get = phongBLL.suapbll(phongDTO, id);
            //switch (get)
            //{

            //    case "requeid_tenphong":
            //        MessageBox.Show("Ten phong khong duoc trong");
            //        return;
            //    case "requeid_giaphong":
            //        MessageBox.Show("Gia phong khong duoc trong");
            //        return;
            //}
            //MessageBox.Show(get);
            //this.danhSPTableAdapter2.Fill(this.qLNTDataSet17.DanhSP);
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pnSua.Show();
        }



        private void fPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNTDataSet36.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter5.Fill(this.qLNTDataSet36.Phong);
            // TODO: This line of code loads data into the 'qLNTDataSet35.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter4.Fill(this.qLNTDataSet35.Phong);
            // TODO: This line of code loads data into the 'qLNTDataSet34.ThuePhong' table. You can move, or remove it, as needed.
            this.thuePhongTableAdapter4.Fill(this.qLNTDataSet34.ThuePhong);
            // TODO: This line of code loads data into the 'qLNTDataSet30.ThuePhong' table. You can move, or remove it, as needed.
            //this.thuePhongTableAdapter3.Fill(this.qLNTDataSet30.ThuePhong);
            // TODO: This line of code loads data into the 'qLNTDataSet29.Phong' table. You can move, or remove it, as needed.
            //this.phongTableAdapter3.Fill(this.qLNTDataSet29.Phong);



        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            pnXemdanhSachP.Show();
        }



        private void guna2CircleButton6_Click_1(object sender, EventArgs e)
        {
            pnSua.Hide();
        }

        private void guna2CircleButton2_Click_1(object sender, EventArgs e)
        {
            guna2Panel1.Hide();
        }

        private void btThemPhong_Click(object sender, EventArgs e)
        {
            try { 
            phongDTO.TenPhong = guna2TextBox2.Text;
            phongDTO.GiaPhong = Convert.ToInt32(guna2TextBox3.Text);
            }catch(Exception ex) {
                MessageBox.Show("Gia phong khong duoc trong");
                return;
            }
            string get = phongBLL.thempbll(phongDTO);
            switch (get)
            {
                
                case "requeid_tenphong":
                    MessageBox.Show("Ten phong khong duoc trong");
                    return;
                case "requeid_giaphong":
                    MessageBox.Show("Gia phong khong duoc trong");
                    return;
            }
            MessageBox.Show("Them thanh cong !");
            this.danhSPTableAdapter2.Fill(this.qLNTDataSet17.DanhSP);

            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";
        }

        private void guna2CircleButton7_Click_1(object sender, EventArgs e)
        {
            pnXemdanhSachP.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            phongDTO.TenPhong = comboBox1.Text;
            //phongDTO.GiaPhong = Convert.ToInt32(guna2TextBox4.Text);
            phongDTO.TenKhach = guna2TextBox7.Text;
            phongDTO.TienNo = 0;
            phongDTO.NgayThue = guna2DateTimePicker1.Value;
            phongDTO.NgayTra = guna2DateTimePicker2.Value;
            phongDTO.Cccd = Convert.ToInt64(guna2TextBox7.Text);
            string get = phongBLL.themhdbll(phongDTO);
            switch (get)
            {

                case "requeid_tenphong":
                    MessageBox.Show("Ten phong khong duoc trong");
                    return;
                case "requeid_giaphong":
                    MessageBox.Show("Gia phong khong duoc trong");
                    return;
            }
            MessageBox.Show(get);
            this.thuePhongTableAdapter1.Fill(this.qLNTDataSet22.ThuePhong);


        }

        private void guna2DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //guna2TextBox5.Text = guna2DataGridView1.SelectedCells[1].Value.ToString();
                //id = Convert.ToInt32(guna2DataGridView1.SelectedCells[0].Value.ToString());
                //guna2TextBox4.Text = guna2DataGridView1.SelectedCells[2].Value.ToString();
                //guna2TextBox7.Text = guna2DataGridView1.SelectedCells[4].Value.ToString();
                //guna2TextBox6.Text = guna2DataGridView1.SelectedCells[3].Value.ToString();

            }catch (Exception ex) { }
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string id = guna2DataGridView1.SelectedCells[0].Value.ToString();
            //phongBLL.xoapBLL(id);
            MessageBox.Show("Xoa thanh cong");
            this.danhSPTableAdapter2.Fill(this.qLNTDataSet17.DanhSP);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.phongTableAdapter.FillBy(this.qLNTDataSet8.Phong);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.phongTableAdapter.FillBy(this.qLNTDataSet8.Phong);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.phongTableAdapter.FillBy1(this.qLNTDataSet8.Phong);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.phongTableAdapter1.FillBy(this.qLNTDataSet9.Phong);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
