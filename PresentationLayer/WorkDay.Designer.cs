namespace PresentationLayer
{
    partial class WorkDay
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_CaLam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btt_Tao = new System.Windows.Forms.Button();
            this.comboBox_NhanVien = new System.Windows.Forms.ComboBox();
            this.dgv_NgayCong = new System.Windows.Forms.DataGridView();
            this.btt_Xoa = new System.Windows.Forms.Button();
            this.btt_SuaCaLam = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NgayCong)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(323, 914);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(188, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quản lý ca làm việc";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btt_Xoa);
            this.panel1.Controls.Add(this.btt_SuaCaLam);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dgv_NgayCong);
            this.panel1.Controls.Add(this.comboBox_CaLam);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.btt_Tao);
            this.panel1.Controls.Add(this.comboBox_NhanVien);
            this.panel1.Location = new System.Drawing.Point(193, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1543, 669);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tạo ngày công";
            // 
            // comboBox_CaLam
            // 
            this.comboBox_CaLam.AllowDrop = true;
            this.comboBox_CaLam.BackColor = System.Drawing.Color.Silver;
            this.comboBox_CaLam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CaLam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_CaLam.FormattingEnabled = true;
            this.comboBox_CaLam.Items.AddRange(new object[] {
            "CA01",
            "CA02",
            "CA03"});
            this.comboBox_CaLam.Location = new System.Drawing.Point(150, 48);
            this.comboBox_CaLam.Name = "comboBox_CaLam";
            this.comboBox_CaLam.Size = new System.Drawing.Size(170, 30);
            this.comboBox_CaLam.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày làm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(729, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ca làm:";
            // 
            // datePicker
            // 
            this.datePicker.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.datePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(470, 48);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 30);
            this.datePicker.TabIndex = 3;
            // 
            // btt_Tao
            // 
            this.btt_Tao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btt_Tao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Tao.Location = new System.Drawing.Point(1076, 595);
            this.btt_Tao.Name = "btt_Tao";
            this.btt_Tao.Size = new System.Drawing.Size(147, 60);
            this.btt_Tao.TabIndex = 1;
            this.btt_Tao.Text = "Tạo";
            this.btt_Tao.UseVisualStyleBackColor = false;
            this.btt_Tao.Click += new System.EventHandler(this.btt_Tao_Click);
            // 
            // comboBox_NhanVien
            // 
            this.comboBox_NhanVien.AllowDrop = true;
            this.comboBox_NhanVien.BackColor = System.Drawing.Color.Silver;
            this.comboBox_NhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_NhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_NhanVien.FormattingEnabled = true;
            this.comboBox_NhanVien.Location = new System.Drawing.Point(831, 48);
            this.comboBox_NhanVien.Name = "comboBox_NhanVien";
            this.comboBox_NhanVien.Size = new System.Drawing.Size(170, 30);
            this.comboBox_NhanVien.TabIndex = 0;
            // 
            // dgv_NgayCong
            // 
            this.dgv_NgayCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NgayCong.Location = new System.Drawing.Point(72, 98);
            this.dgv_NgayCong.MultiSelect = false;
            this.dgv_NgayCong.Name = "dgv_NgayCong";
            this.dgv_NgayCong.RowHeadersWidth = 51;
            this.dgv_NgayCong.RowTemplate.Height = 24;
            this.dgv_NgayCong.Size = new System.Drawing.Size(1457, 491);
            this.dgv_NgayCong.TabIndex = 10;
            this.dgv_NgayCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NgayCong_CellClick);
            // 
            // btt_Xoa
            // 
            this.btt_Xoa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btt_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Xoa.Location = new System.Drawing.Point(1382, 595);
            this.btt_Xoa.Name = "btt_Xoa";
            this.btt_Xoa.Size = new System.Drawing.Size(147, 60);
            this.btt_Xoa.TabIndex = 9;
            this.btt_Xoa.Text = "Xóa";
            this.btt_Xoa.UseVisualStyleBackColor = false;
            this.btt_Xoa.Click += new System.EventHandler(this.btt_Xoa_Click);
            // 
            // btt_SuaCaLam
            // 
            this.btt_SuaCaLam.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btt_SuaCaLam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_SuaCaLam.Location = new System.Drawing.Point(1229, 595);
            this.btt_SuaCaLam.Name = "btt_SuaCaLam";
            this.btt_SuaCaLam.Size = new System.Drawing.Size(147, 60);
            this.btt_SuaCaLam.TabIndex = 10;
            this.btt_SuaCaLam.Text = "Sửa";
            this.btt_SuaCaLam.UseVisualStyleBackColor = false;
            this.btt_SuaCaLam.Click += new System.EventHandler(this.btt_SuaCaLam_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(136, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1788, 914);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1788, 130);
            this.panel3.TabIndex = 9;
            // 
            // WorkDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 914);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "WorkDay";
            this.Text = "WorkDay";
            this.Load += new System.EventHandler(this.WorkDay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NgayCong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btt_Tao;
        private System.Windows.Forms.ComboBox comboBox_NhanVien;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_CaLam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_NgayCong;
        private System.Windows.Forms.Button btt_Xoa;
        private System.Windows.Forms.Button btt_SuaCaLam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}