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
    public partial class Login : Form
    {
        TaiKhoanBLL TaiKhoanBLL = new TaiKhoanBLL();
        TaiKhoanDTO TaiKhoanDTO = new TaiKhoanDTO();
        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO.Tk = txtHoTen.Text;
            TaiKhoanDTO.Mk = guna2TextBox1.Text;

            //string get = TaiKhoanBLL.login(TaiKhoanDTO);
            //switch(get){
            //    case "requeid_taikhoan":
            //        MessageBox.Show("Tai khoan khong duoc trong");
            //        return;
            //    case "requeid_matkhau":
            //        MessageBox.Show("Mat khau khong duoc trong");
            //        return;
            //    case "Sai tai khoan hoac mat khau":
            //        MessageBox.Show("Sai tai khoan hoac mat khau");
            //        return;
            //}
            fTC fTC = new fTC();
            this.Hide();
            fTC.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát chương trình?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNTDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            //this.taiKhoanTableAdapter.Fill(this.qLNTDataSet.TaiKhoan);

        }

    }
}
