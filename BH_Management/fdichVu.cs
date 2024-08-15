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

namespace BH_Management
{
    public partial class fdichVu : Form
    {
        dvDTO dvDTO = new dvDTO();
        dvBLL dvBLL = new dvBLL();
        double tiendien, tiendient;
        int sodiencu, sodienmoi;
        public fdichVu()
        {
            InitializeComponent();
            pnThemDV.Hide();
            timer1.Start();
            //guna2ComboBox1.DataSource = dvBLL.listData();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            pnThemDV.Show();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            pnThemDV.Hide();
        }

        private void fdichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNTDataSet40.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.qLNTDataSet40.Phong);
            // TODO: This line of code loads data into the 'qLNTDataSet39.ChiTietDV' table. You can move, or remove it, as needed.
            this.chiTietDVTableAdapter5.Fill(this.qLNTDataSet39.ChiTietDV);
            // TODO: This line of code loads data into the 'qLNTDataSet37.ChiTietDV' table. You can move, or remove it, as needed.
            this.chiTietDVTableAdapter4.Fill(this.qLNTDataSet37.ChiTietDV);
            // TODO: This line of code loads data into the 'qLNTDataSet31.ChiTietDV' table. You can move, or remove it, as needed.
            this.chiTietDVTableAdapter3.Fill(this.qLNTDataSet31.ChiTietDV);
            
            // TODO: This line of code loads data into the 'qLNTDataSet5.ChiTietDV' table. You can move, or remove it, as needed.
            //this.chiTietDVTableAdapter.Fill(this.qLNTDataSet5.ChiTietDV);

        }


        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sodiencu = Convert.ToInt32(guna2TextBox2.Text);
                sodienmoi = Convert.ToInt32(guna2TextBox4.Text);
                tiendien = (sodienmoi - sodiencu) * 3.500;
                guna2TextBox1.Text = tiendien.ToString();
            }
            catch { }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            dvDTO.IdThue = Convert.ToInt32(guna2DataGridView1.SelectedCells[1].Value.ToString());
            dvDTO.TenPhong = guna2DataGridView1.SelectedCells[2].Value.ToString();
            dvDTO.ChiSoDienCu = Convert.ToInt32(guna2DataGridView1.SelectedCells[3].Value.ToString());
            dvDTO.ChiSoDienMoi = Convert.ToInt32(guna2DataGridView1.SelectedCells[4].Value.ToString());
            dvDTO.TienDien = Convert.ToInt32(guna2DataGridView1.SelectedCells[5].Value.ToString());
            dvDTO.TienNuoc = Convert.ToInt32(guna2DataGridView1.SelectedCells[6].Value.ToString());
            dvDTO.TienWifi = Convert.ToInt32(guna2DataGridView1.SelectedCells[7].Value.ToString());
            dvDTO.SoNguoiSuDung = Convert.ToInt32(guna2DataGridView1.SelectedCells[8].Value.ToString());
            try
            {
                dvDTO.NgayLap = Convert.ToDateTime(guna2DataGridView1.SelectedCells[9].Value.ToString());
            }catch (Exception ex) { MessageBox.Show("Ngay Lap Khong Duoc Trong "); return; }

            string info = dvBLL.suadvBLL(dvDTO);
            if (info == "Sua thanh cong")
            {

                MessageBox.Show(info);
            }
            else
            {
                MessageBox.Show(info);
                this.chiTietDVTableAdapter1.Fill(this.qLNTDataSet13.ChiTietDV);
            }




        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dvDTO.IdThue = Convert.ToInt32(guna2DataGridView1.SelectedCells[1].Value.ToString());

            dvBLL.xoadvBLL(dvDTO);
            MessageBox.Show("Xoa thanh cong");
            this.chiTietDVTableAdapter1.Fill(this.qLNTDataSet13.ChiTietDV);
        }

        

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sodiencu = Convert.ToInt32(guna2TextBox2.Text);
                sodienmoi = Convert.ToInt32(guna2TextBox4.Text);
                tiendien = (sodienmoi - sodiencu) * 3.500;
                guna2TextBox1.Text = tiendien.ToString();
            }
            catch
            {

            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            tiendient = Math.Round(tiendien);
            dvDTO.ChiSoDienCu = sodiencu;
            dvDTO.ChiSoDienMoi = sodienmoi;
            dvDTO.TienDien = Convert.ToInt32(tiendient);
            dvDTO.TienNuoc = Convert.ToInt32(guna2TextBox3.Text);
            dvDTO.TienWifi = Convert.ToInt32(guna2TextBox5.Text);
            //dvDTO.TenPhong = guna2ComboBox1.Text;
            dvDTO.NgayLap = dateTimePicker2.Value;
            dvDTO.SoNguoiSuDung = Convert.ToInt32(guna2TextBox6.Text);
            //dvDTO.IdThue = Convert.ToInt32(dvBLL.layidthueBLL(guna2ComboBox1.Text));


            string info = dvBLL.themdvBLL(dvDTO);
            if (info == "Them thanh cong")
            {

                MessageBox.Show(info);
            }
            else
            {
                MessageBox.Show(info);
                this.chiTietDVTableAdapter1.Fill(this.qLNTDataSet13.ChiTietDV);
            }
        }
    }
}
