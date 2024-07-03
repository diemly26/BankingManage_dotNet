using BLL;
using DAL;
using dotnetProject.All_User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnetProject
{
    public partial class Inform : Form
    {
        public Inform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void SetData(string row1, string row2, string row3, string row4, string row5)
        {
            textBox1.Text = row1;
            textBox5.Text = row2;
            textBox4.Text = row3;
            textBox2.Text = row4;
            textBox3.Text = row5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            long cccd = long.Parse(textBox5.Text);
            long stk = long.Parse(textBox4.Text);
            string pin = textBox3.Text;
            int status = int.Parse(textBox2.Text);

            if(CustomerAccess.Instance.EditCustomer(cccd, name, stk, pin, status))
            {
                MessageBox.Show("Update thanh cong.");
               
                UcManage um = new UcManage();
                DataGridView dgv = um.GetDataGridView();
                Update ud = new Update();
                dgv.DataSource = ud.UpdateDataSource();
                dgv.Refresh();
            }
            else
            {
                MessageBox.Show("Loi.");
            }
        }
    }
}
