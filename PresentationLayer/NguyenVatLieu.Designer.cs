namespace PresentationLayer
{
    partial class NguyenVatLieu
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btt_XoaBoLoc = new System.Windows.Forms.Button();
            this.comboBox_Loc = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_NguyenVatLieu = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NguyenVatLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 641);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Location = new System.Drawing.Point(233, 12);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1090, 58);
            this.flowLayoutPanel4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(226, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản lý nguyên vật liệu";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(353, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 30);
            this.textBox1.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(728, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // btt_XoaBoLoc
            // 
            this.btt_XoaBoLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_XoaBoLoc.Location = new System.Drawing.Point(1009, 154);
            this.btt_XoaBoLoc.Name = "btt_XoaBoLoc";
            this.btt_XoaBoLoc.Size = new System.Drawing.Size(100, 30);
            this.btt_XoaBoLoc.TabIndex = 12;
            this.btt_XoaBoLoc.Text = "Xoa bo loc";
            this.btt_XoaBoLoc.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btt_XoaBoLoc.UseVisualStyleBackColor = true;
            // 
            // comboBox_Loc
            // 
            this.comboBox_Loc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Loc.FormattingEnabled = true;
            this.comboBox_Loc.Items.AddRange(new object[] {
            "Theo ngày",
            "Theo số lượng"});
            this.comboBox_Loc.Location = new System.Drawing.Point(810, 152);
            this.comboBox_Loc.Name = "comboBox_Loc";
            this.comboBox_Loc.Size = new System.Drawing.Size(180, 30);
            this.comboBox_Loc.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1125, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 14;
            this.button2.Text = "Lay Nguyen Lieu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_NguyenVatLieu);
            this.panel1.Location = new System.Drawing.Point(233, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 502);
            this.panel1.TabIndex = 15;
            // 
            // dgv_NguyenVatLieu
            // 
            this.dgv_NguyenVatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NguyenVatLieu.Location = new System.Drawing.Point(41, 63);
            this.dgv_NguyenVatLieu.Name = "dgv_NguyenVatLieu";
            this.dgv_NguyenVatLieu.RowHeadersWidth = 51;
            this.dgv_NguyenVatLieu.RowTemplate.Height = 24;
            this.dgv_NguyenVatLieu.Size = new System.Drawing.Size(1015, 405);
            this.dgv_NguyenVatLieu.TabIndex = 0;
            // 
            // NguyenVatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 641);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox_Loc);
            this.Controls.Add(this.btt_XoaBoLoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "NguyenVatLieu";
            this.Text = "NguyenVatLieu";
            this.Load += new System.EventHandler(this.NguyenVatLieu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NguyenVatLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btt_XoaBoLoc;
        private System.Windows.Forms.ComboBox comboBox_Loc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_NguyenVatLieu;
    }
}