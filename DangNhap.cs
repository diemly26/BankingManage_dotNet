using BUS;
using DAL;
using DTO;
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
    public partial class DangNhap : Form
    {
        public long currentID;
        public static string LoggedInUsername { get; set; }
        


        public DangNhap()
        {
            InitializeComponent();
            GetID();
        }

        private void lb1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           long id = long.Parse((txt1.Text));
            string pass = txt2.Text;
            if(Login0(id, pass))
            {
                Admin ad = new Admin();
        
                ad.Show();
                
            } else if(Login1(id, pass))
            {
                //KhachHang kh = new KhachHang();
                //Customer currentKH = kh.GetUserInformation(id);
                currentID = id;
                LoggedInUsername = id.ToString();
                

                User us = new User();              
                us.Show();
                
            }
            else
            {
                MessageBox.Show("Sai tai khoan hoac mat khau. Hay nhap lai!");
            }
        }
        bool Login0(long id, string pass)
        {
            return AccountAccess.Instance.LoginAdmin(id, pass);
        }
        bool Login1(long id, string pass)
        {
            
            return AccountAccess.Instance.LoginCustom(id, pass);
        }
        public string GetID()
        {
            return currentID.ToString();
        }
        public string CurrentUserName { get { return LoggedInUsername; } }
    }
}
