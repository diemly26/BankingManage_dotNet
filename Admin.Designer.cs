using dotnetProject.All_User_Control;
using System.Threading;
using System.Windows.Forms;

namespace dotnetProject
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ucState1 = new dotnetProject.All_User_Control.UcState();
            this.ucManage1 = new dotnetProject.All_User_Control.UcManage();
            this.ucAdd1 = new dotnetProject.All_User_Control.UcAdd();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ucAdd1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.ucState1);
            this.panel1.Controls.Add(this.ucManage1);
            this.panel1.Controls.Add(this.ucAdd1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(48, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2000, 1200);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.btn4);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Location = new System.Drawing.Point(12, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 636);
            this.panel2.TabIndex = 4;
            // 
            // btn4
            // 
            this.btn4.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(17, 499);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(225, 95);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "Thoát";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(17, 90);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(225, 104);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Thêm người dùng";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn3
            // 
            this.btn3.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(17, 374);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(225, 90);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Sao kê";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(17, 234);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(225, 112);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Quản lý người dùng";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 3;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(90, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(749, 345);
            this.panel3.TabIndex = 2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this;
            // 
            // ucState1
            // 
            this.ucState1.BackColor = System.Drawing.Color.Lavender;
            this.ucState1.Enabled = false;
            this.ucState1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ucState1.Location = new System.Drawing.Point(354, 91);
            this.ucState1.Name = "ucState1";
            this.ucState1.Size = new System.Drawing.Size(924, 636);
            this.ucState1.TabIndex = 1;
            this.ucState1.TabStop = false;
            this.ucState1.Load += new System.EventHandler(this.ucState1_Load_1);
            // 
            // ucManage1
            // 
            this.ucManage1.BackColor = System.Drawing.Color.Lavender;
            this.ucManage1.Location = new System.Drawing.Point(354, 91);
            this.ucManage1.Name = "ucManage1";
            this.ucManage1.Size = new System.Drawing.Size(924, 636);
            this.ucManage1.TabIndex = 6;
            this.ucManage1.Load += new System.EventHandler(this.ucManage1_Load_2);
            // 
            // ucAdd1
            // 
            this.ucAdd1.BackColor = System.Drawing.Color.Lavender;
            this.ucAdd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucAdd1.Controls.Add(this.btn6);
            this.ucAdd1.Controls.Add(this.btn5);
            this.ucAdd1.Controls.Add(this.txt5);
            this.ucAdd1.Controls.Add(this.txt4);
            this.ucAdd1.Controls.Add(this.txt3);
            this.ucAdd1.Controls.Add(this.txt2);
            this.ucAdd1.Controls.Add(this.txt1);
            this.ucAdd1.Controls.Add(this.lb5);
            this.ucAdd1.Controls.Add(this.lb4);
            this.ucAdd1.Controls.Add(this.lb3);
            this.ucAdd1.Controls.Add(this.lb2);
            this.ucAdd1.Controls.Add(this.lb1);
            this.ucAdd1.Controls.Add(this.lb);
            this.ucAdd1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ucAdd1.Location = new System.Drawing.Point(354, 91);
            this.ucAdd1.Name = "ucAdd1";
            this.ucAdd1.Size = new System.Drawing.Size(924, 636);
            this.ucAdd1.TabIndex = 5;
            this.ucAdd1.Load += new System.EventHandler(this.ucAdd1_Load);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(666, 558);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(157, 46);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "Đặt lại";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(298, 558);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(157, 46);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "Thêm";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(298, 474);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(525, 31);
            this.txt5.TabIndex = 1;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(298, 392);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(525, 31);
            this.txt4.TabIndex = 1;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(298, 314);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(525, 31);
            this.txt3.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(298, 230);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(525, 31);
            this.txt2.TabIndex = 1;
            // 
            // txt1
            // 
            this.txt1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt1.Location = new System.Drawing.Point(298, 162);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(525, 31);
            this.txt1.TabIndex = 1;
            // 
            // lb5
            // 
            this.lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(41, 474);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(231, 53);
            this.lb5.TabIndex = 5;
            this.lb5.Text = "Ngày mở thẻ";
            this.lb5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb4
            // 
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(41, 392);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(231, 54);
            this.lb4.TabIndex = 4;
            this.lb4.Text = "Mật khẩu";
            this.lb4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb3
            // 
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(41, 314);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(231, 54);
            this.lb3.TabIndex = 4;
            this.lb3.Text = "Số tài khoản";
            this.lb3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb2
            // 
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(41, 230);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(231, 53);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Số CMND/CCCD";
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb1
            // 
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(41, 138);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(251, 73);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Tên chủ tài khoản";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb
            // 
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(200, 54);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(637, 44);
            this.lb.TabIndex = 0;
            this.lb.Text = "Thêm người dùng mới";
            this.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2500, 1500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ucAdd1.ResumeLayout(false);
            this.ucAdd1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Label lb4;
        private Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Control.UcAdd ucAdd1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Control.UcManage ucManage1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_User_Control.UcState ucState1;
    }
}