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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucInfor1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ucInfor1.Visible = true;
            ucInfor1.BringToFront();

            
        }

        private void User_Load(object sender, EventArgs e)
        {
            ucInfor1.Visible=false;
            ucBank1.Visible=false;
            ucView1.Visible=false;
            btn1.PerformClick();
            btn2.PerformClick();
            btn3.PerformClick();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ucBank1.Visible = true;
            ucBank1.BringToFront();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ucView1.Visible = true;
            ucView1.BringToFront();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ucView1_Load(object sender, EventArgs e)
        {

        }

        /*private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // User
            // 
            this.ClientSize = new System.Drawing.Size(1002, 582);
            this.Name = "User";
            this.ResumeLayout(false);

        }*/
    }
}
