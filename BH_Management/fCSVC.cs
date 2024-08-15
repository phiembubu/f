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
    

    public partial class fCSVC : Form
    {
        csvcBLL csvcBLL = new csvcBLL();
        csvcDTO csvcDTO = new csvcDTO(); 
        public fCSVC()
        {
            InitializeComponent();
            pnCSVC.Hide();
            
            guna2ComboBox1.DataSource = csvcBLL.listData();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            pnCSVC.Show();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            pnCSVC.Hide();
        }

        private void fCSVC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNTDataSet38.CSVC' table. You can move, or remove it, as needed.
            this.cSVCTableAdapter7.Fill(this.qLNTDataSet38.CSVC);
            // TODO: This line of code loads data into the 'qLNTDataSet33.CSVC' table. You can move, or remove it, as needed.
            this.cSVCTableAdapter6.Fill(this.qLNTDataSet33.CSVC);
            // TODO: This line of code loads data into the 'qLNTDataSet32.CSVC' table. You can move, or remove it, as needed.
            this.cSVCTableAdapter5.Fill(this.qLNTDataSet32.CSVC);
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

            csvcDTO.TenCSVC = guna2TextBox2.Text;
            csvcDTO.TinhtrangCSVC = guna2TextBox4.Text;
            csvcDTO.Tenphong = guna2ComboBox1.Text;

            string info = csvcBLL.themCSVCBLL(csvcDTO);

            if (info == "tennull")
            {
                MessageBox.Show("Ten CSVC khong duoc trong");
                return;
            }
            MessageBox.Show("Them thanh cong");
            this.cSVCTableAdapter2.Fill(this.qLNTDataSet19.CSVC);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            csvcDTO.TenCSVC = guna2DataGridView1.SelectedCells[1].Value.ToString();
            csvcDTO.Idcsvc = Convert.ToInt32(guna2DataGridView1.SelectedCells[0].Value.ToString());
            csvcDTO.Tenphong = guna2DataGridView1.SelectedCells[2].Value.ToString();
            csvcDTO.TinhtrangCSVC = guna2DataGridView1.SelectedCells[3].Value.ToString();

            string info = csvcBLL.suaCSVCBLL(csvcDTO);

            if (info == "tennull")
            {
                MessageBox.Show("Ten CSVC khong duoc trong");
                return;
            }
            MessageBox.Show("Sua thanh cong");
            this.cSVCTableAdapter2.Fill(this.qLNTDataSet19.CSVC);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            csvcDTO.Idcsvc = Convert.ToInt32(guna2DataGridView1.SelectedCells[0].Value.ToString());

            csvcBLL.xoacsvcBLL(csvcDTO);
            MessageBox.Show("Xoa thanh cong");
            this.cSVCTableAdapter2.Fill(this.qLNTDataSet19.CSVC);
        }


    }
}
