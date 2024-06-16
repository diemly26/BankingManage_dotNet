using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;
using BLL;
using DAL;

using dotnetProject.All_User_Control;
using Microsoft.IdentityModel.Tokens;

namespace dotnetProject
{
   public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            ucAdd1.Visible = true;
            ucAdd1.BringToFront();
            DateTime today = DateTime.Today;
            txt5.Text = today.ToString();
        }
        private void btn2_Click(object sender, EventArgs e)
        {

            ucManage1.Visible = true;
            ucManage1.BringToFront();
            // Gọi UserControl từ form
            UcManage um = new UcManage();
            DataGridView dgv = um.GetDataGridView();
            Update ud = new Update();
            dgv.DataSource = ud.UpdateDataSource();
            dgv.Refresh();


        }
        private void btn3_Click(object sender, EventArgs e)
        {
            ucState1.Visible = true;
            ucState1.BringToFront();
            
        }


        private void btn4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            ucAdd1.Visible = false;
            ucManage1.Visible=false;
            ucState1.Visible=false;
            btn1.PerformClick();
            btn2.PerformClick();
            btn3.PerformClick();
        }

        void ucManage1_Load(object sender, EventArgs e)
        {     
            
        }

        private void ucState1_Load(object sender, EventArgs e)
        {

        }

        private void ucManage1_Load_1(object sender, EventArgs e)
        {

        }

        private void ucManage1_Load_2(object sender, EventArgs e)
        {

        }

        private void ucState1_Load_1(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string name = txt1.Text;
            long cccd = long.Parse(txt2.Text);
            long stk = long.Parse(txt3.Text);
            string pin = txt4.Text;
            
            string date = txt5.Text;
            int sodu = 0;
            int status = 1;
            int phanquyen = 1;
            AccountAccess.Instance.AddAccount(stk, pin, phanquyen);
            if(CustomerAccess.Instance.AddCustomer(cccd, name, stk, pin, sodu, status, date))
            {
                MessageBox.Show("Success!");
                
            }
            else
            {
                MessageBox.Show("Loi");
            }


        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
        }

        private void ucAdd1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
