namespace PresentationLayer
{
    partial class Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Table));
            this.flpnl_Table = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btt_ClearTable = new System.Windows.Forms.Button();
            this.text_TrangThai = new System.Windows.Forms.Label();
            this.text_ThoiGian = new System.Windows.Forms.Label();
            this.text_HoaDon = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_TableNumber = new System.Windows.Forms.Label();
            this.pic_QR = new System.Windows.Forms.PictureBox();
            this.pnl_ThongTin = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Bàn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_QR)).BeginInit();
            this.pnl_ThongTin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flpnl_Table
            // 
            this.flpnl_Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpnl_Table.AutoScroll = true;
            this.flpnl_Table.Location = new System.Drawing.Point(60, 164);
            this.flpnl_Table.Name = "flpnl_Table";
            this.flpnl_Table.Size = new System.Drawing.Size(607, 333);
            this.flpnl_Table.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông tin bàn ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Thời gian vào:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(16, 321);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(112, 26);
            this.label.TabIndex = 3;
            this.label.Text = "Trạng thái:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 26);
            this.label9.TabIndex = 5;
            this.label9.Text = "Chi tiết hóa đơn:";
            // 
            // btt_ClearTable
            // 
            this.btt_ClearTable.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_ClearTable.Location = new System.Drawing.Point(21, 839);
            this.btt_ClearTable.Name = "btt_ClearTable";
            this.btt_ClearTable.Size = new System.Drawing.Size(364, 56);
            this.btt_ClearTable.TabIndex = 6;
            this.btt_ClearTable.Text = "Dọn bàn";
            this.btt_ClearTable.UseVisualStyleBackColor = true;
            this.btt_ClearTable.Click += new System.EventHandler(this.btt_ClearTable_Click);
            // 
            // text_TrangThai
            // 
            this.text_TrangThai.AutoSize = true;
            this.text_TrangThai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_TrangThai.Location = new System.Drawing.Point(184, 318);
            this.text_TrangThai.Name = "text_TrangThai";
            this.text_TrangThai.Size = new System.Drawing.Size(0, 26);
            this.text_TrangThai.TabIndex = 7;
            // 
            // text_ThoiGian
            // 
            this.text_ThoiGian.AutoSize = true;
            this.text_ThoiGian.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ThoiGian.Location = new System.Drawing.Point(184, 359);
            this.text_ThoiGian.Name = "text_ThoiGian";
            this.text_ThoiGian.Size = new System.Drawing.Size(0, 26);
            this.text_ThoiGian.TabIndex = 8;
            // 
            // text_HoaDon
            // 
            this.text_HoaDon.AutoSize = true;
            this.text_HoaDon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_HoaDon.Location = new System.Drawing.Point(186, 402);
            this.text_HoaDon.Name = "text_HoaDon";
            this.text_HoaDon.Size = new System.Drawing.Size(0, 26);
            this.text_HoaDon.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 26);
            this.label8.TabIndex = 10;
            this.label8.Text = "Số bàn:";
            // 
            // text_TableNumber
            // 
            this.text_TableNumber.AutoSize = true;
            this.text_TableNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_TableNumber.Location = new System.Drawing.Point(184, 280);
            this.text_TableNumber.Name = "text_TableNumber";
            this.text_TableNumber.Size = new System.Drawing.Size(0, 26);
            this.text_TableNumber.TabIndex = 11;
            // 
            // pic_QR
            // 
            this.pic_QR.Location = new System.Drawing.Point(99, 95);
            this.pic_QR.Name = "pic_QR";
            this.pic_QR.Size = new System.Drawing.Size(213, 182);
            this.pic_QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_QR.TabIndex = 12;
            this.pic_QR.TabStop = false;
            // 
            // pnl_ThongTin
            // 
            this.pnl_ThongTin.Controls.Add(this.dgv_HoaDon);
            this.pnl_ThongTin.Controls.Add(this.pic_QR);
            this.pnl_ThongTin.Controls.Add(this.text_TableNumber);
            this.pnl_ThongTin.Controls.Add(this.label8);
            this.pnl_ThongTin.Controls.Add(this.text_HoaDon);
            this.pnl_ThongTin.Controls.Add(this.text_ThoiGian);
            this.pnl_ThongTin.Controls.Add(this.text_TrangThai);
            this.pnl_ThongTin.Controls.Add(this.btt_ClearTable);
            this.pnl_ThongTin.Controls.Add(this.label9);
            this.pnl_ThongTin.Controls.Add(this.label);
            this.pnl_ThongTin.Controls.Add(this.label6);
            this.pnl_ThongTin.Controls.Add(this.label3);
            this.pnl_ThongTin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_ThongTin.Location = new System.Drawing.Point(698, 0);
            this.pnl_ThongTin.Name = "pnl_ThongTin";
            this.pnl_ThongTin.Size = new System.Drawing.Size(451, 809);
            this.pnl_ThongTin.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pnl_ThongTin);
            this.panel1.Controls.Add(this.flpnl_Table);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(333, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 809);
            this.panel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(377, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Còn trống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thông tin bàn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản lý bàn phục vụ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(537, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 26);
            this.label10.TabIndex = 10;
            this.label10.Text = "Không trống";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.Bàn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 909);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(333, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1149, 100);
            this.panel3.TabIndex = 11;
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Location = new System.Drawing.Point(21, 441);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.RowHeadersWidth = 51;
            this.dgv_HoaDon.RowTemplate.Height = 24;
            this.dgv_HoaDon.Size = new System.Drawing.Size(360, 294);
            this.dgv_HoaDon.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(24, 430);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(285, 50);
            this.button5.TabIndex = 21;
            this.button5.Text = "Ngày công";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(24, 510);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(285, 50);
            this.button4.TabIndex = 20;
            this.button4.Text = "Nguyên vật liệu";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Bàn
            // 
            this.Bàn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bàn.BackColor = System.Drawing.Color.DimGray;
            this.Bàn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bàn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bàn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bàn.Location = new System.Drawing.Point(24, 349);
            this.Bàn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bàn.Name = "Bàn";
            this.Bàn.Size = new System.Drawing.Size(285, 50);
            this.Bàn.TabIndex = 19;
            this.Bàn.Text = "Bàn phục vụ";
            this.Bàn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(37, 206);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 60);
            this.button2.TabIndex = 23;
            this.button2.Text = "Trang chủ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 909);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Table";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_QR)).EndInit();
            this.pnl_ThongTin.ResumeLayout(false);
            this.pnl_ThongTin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpnl_Table;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btt_ClearTable;
        private System.Windows.Forms.Label text_TrangThai;
        private System.Windows.Forms.Label text_ThoiGian;
        private System.Windows.Forms.Label text_HoaDon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label text_TableNumber;
        private System.Windows.Forms.PictureBox pic_QR;
        private System.Windows.Forms.Panel pnl_ThongTin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Bàn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}