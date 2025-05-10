namespace PresentationLayer
{
    partial class frmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblogin = new System.Windows.Forms.Label();
            this.lbusername = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.txbusername = new System.Windows.Forms.TextBox();
            this.txbpass = new System.Windows.Forms.TextBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 547);
            this.panel1.TabIndex = 0;
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblogin.Location = new System.Drawing.Point(438, 61);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(136, 27);
            this.lblogin.TabIndex = 0;
            this.lblogin.Text = "Đăng Nhập";
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusername.Location = new System.Drawing.Point(439, 159);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(152, 23);
            this.lbusername.TabIndex = 1;
            this.lbusername.Text = "Tên Đăng Nhập:";
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass.Location = new System.Drawing.Point(439, 253);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(97, 23);
            this.lbpass.TabIndex = 2;
            this.lbpass.Text = "Mật khẩu:";
            // 
            // txbusername
            // 
            this.txbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbusername.Location = new System.Drawing.Point(443, 198);
            this.txbusername.Name = "txbusername";
            this.txbusername.Size = new System.Drawing.Size(389, 30);
            this.txbusername.TabIndex = 3;
            // 
            // txbpass
            // 
            this.txbpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbpass.Location = new System.Drawing.Point(443, 291);
            this.txbpass.Name = "txbpass";
            this.txbpass.Size = new System.Drawing.Size(389, 30);
            this.txbpass.TabIndex = 4;
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btlogin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btlogin.Location = new System.Drawing.Point(443, 376);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(161, 48);
            this.btlogin.TabIndex = 6;
            this.btlogin.Text = "Đăng Nhập";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // btexit
            // 
            this.btexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btexit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btexit.Location = new System.Drawing.Point(678, 376);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(154, 48);
            this.btexit.TabIndex = 7;
            this.btexit.Text = "Thoát";
            this.btexit.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(74, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotline: 01394800197";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "website:cf.ou.it.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(106, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "Coffe Shop";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(844, 470);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.txbpass);
            this.Controls.Add(this.txbusername);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.lblogin);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblogin;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.TextBox txbusername;
        private System.Windows.Forms.TextBox txbpass;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}