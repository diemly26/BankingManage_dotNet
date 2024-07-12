namespace dotnetProject
{
    partial class User
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
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ucView1 = new dotnetProject.All_User_Control.UcView();
            this.ucBank1 = new dotnetProject.All_User_Control.UcBank();
            this.ucInfor1 = new dotnetProject.All_User_Control.UcInfor();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.ucView1);
            this.panel1.Controls.Add(this.ucBank1);
            this.panel1.Controls.Add(this.ucInfor1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(42, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2000, 1200);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.btn4);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Location = new System.Drawing.Point(50, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 581);
            this.panel2.TabIndex = 0;
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(40, 458);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(163, 70);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "Thoát";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(40, 327);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(167, 78);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Biến động số dư";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(39, 204);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(168, 86);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Chuyển khoản";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(40, 58);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(169, 102);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Thông tin tài khoản";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // guna2Elipse1
            // 
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
            // ucView1
            // 
            this.ucView1.BackColor = System.Drawing.Color.AliceBlue;
            this.ucView1.Location = new System.Drawing.Point(349, 79);
            this.ucView1.Name = "ucView1";
            this.ucView1.Size = new System.Drawing.Size(1007, 581);
            this.ucView1.TabIndex = 3;
            this.ucView1.Load += new System.EventHandler(this.ucView1_Load);
            // 
            // ucBank1
            // 
            this.ucBank1.BackColor = System.Drawing.Color.AliceBlue;
            this.ucBank1.Location = new System.Drawing.Point(349, 79);
            this.ucBank1.Name = "ucBank1";
            this.ucBank1.Size = new System.Drawing.Size(959, 581);
            this.ucBank1.TabIndex = 2;
            // 
            // ucInfor1
            // 
            this.ucInfor1.BackColor = System.Drawing.Color.AliceBlue;
            this.ucInfor1.Location = new System.Drawing.Point(349, 79);
            this.ucInfor1.Name = "ucInfor1";
            this.ucInfor1.Size = new System.Drawing.Size(959, 581);
            this.ucInfor1.TabIndex = 1;
            this.ucInfor1.Load += new System.EventHandler(this.ucInfor1_Load);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2500, 1500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.User_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Control.UcInfor ucInfor1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Control.UcBank ucBank1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_User_Control.UcView ucView1;
    }
}