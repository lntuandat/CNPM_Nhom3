namespace QLNS.NhanSu.ChildForm
{
    partial class formHopDongNhanVien
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ThoiHanHD = new System.Windows.Forms.TextBox();
            this.txt_NgayKT = new System.Windows.Forms.MaskedTextBox();
            this.txt_NgayBD = new System.Windows.Forms.MaskedTextBox();
            this.txt_MucLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_HDNV = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuyHD = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HDNV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1745, 342);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnHuyHD);
            this.groupBox2.Controls.Add(this.btnThemHD);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(1113, 112);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(532, 222);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_MaHD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_ThoiHanHD);
            this.groupBox1.Controls.Add(this.txt_NgayKT);
            this.groupBox1.Controls.Add(this.txt_NgayBD);
            this.groupBox1.Controls.Add(this.txt_MucLuong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_HoTen);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_MaNV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(47, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1027, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin họp đồng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHD.Location = new System.Drawing.Point(216, 124);
            this.txt_MaHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(210, 35);
            this.txt_MaHD.TabIndex = 33;
            this.txt_MaHD.TextChanged += new System.EventHandler(this.txt_MaHD_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Mã họp đồng:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_ThoiHanHD
            // 
            this.txt_ThoiHanHD.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThoiHanHD.Location = new System.Drawing.Point(216, 169);
            this.txt_ThoiHanHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ThoiHanHD.Name = "txt_ThoiHanHD";
            this.txt_ThoiHanHD.Size = new System.Drawing.Size(210, 35);
            this.txt_ThoiHanHD.TabIndex = 31;
            this.txt_ThoiHanHD.TextChanged += new System.EventHandler(this.txt_ThoiHanHD_TextChanged);
            // 
            // txt_NgayKT
            // 
            this.txt_NgayKT.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayKT.Location = new System.Drawing.Point(731, 78);
            this.txt_NgayKT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NgayKT.Mask = "00/00/0000";
            this.txt_NgayKT.Name = "txt_NgayKT";
            this.txt_NgayKT.Size = new System.Drawing.Size(216, 35);
            this.txt_NgayKT.TabIndex = 30;
            this.txt_NgayKT.ValidatingType = typeof(System.DateTime);
            this.txt_NgayKT.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_NgayKT_MaskInputRejected);
            // 
            // txt_NgayBD
            // 
            this.txt_NgayBD.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayBD.Location = new System.Drawing.Point(731, 32);
            this.txt_NgayBD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NgayBD.Mask = "00/00/0000";
            this.txt_NgayBD.Name = "txt_NgayBD";
            this.txt_NgayBD.Size = new System.Drawing.Size(216, 35);
            this.txt_NgayBD.TabIndex = 29;
            this.txt_NgayBD.ValidatingType = typeof(System.DateTime);
            this.txt_NgayBD.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_NgayBD_MaskInputRejected);
            // 
            // txt_MucLuong
            // 
            this.txt_MucLuong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MucLuong.Location = new System.Drawing.Point(731, 119);
            this.txt_MucLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MucLuong.Name = "txt_MucLuong";
            this.txt_MucLuong.Size = new System.Drawing.Size(216, 35);
            this.txt_MucLuong.TabIndex = 27;
            this.txt_MucLuong.TextChanged += new System.EventHandler(this.txt_MucLuong_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(511, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "Mức lương:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(511, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ngày ký hợp đồng:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(511, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ngày hết thời hạn:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(216, 78);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(210, 35);
            this.txt_HoTen.TabIndex = 15;
            this.txt_HoTen.TextChanged += new System.EventHandler(this.txt_HoTen_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Thời hạn họp đồng:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Location = new System.Drawing.Point(216, 32);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(210, 35);
            this.txt_MaNV.TabIndex = 4;
            this.txt_MaNV.TextChanged += new System.EventHandler(this.txt_MaNV_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(577, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỌP ĐỒNG NHÂN VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_HDNV
            // 
            this.dgv_HDNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HDNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_HDNV.Location = new System.Drawing.Point(0, 342);
            this.dgv_HDNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_HDNV.Name = "dgv_HDNV";
            this.dgv_HDNV.RowHeadersWidth = 51;
            this.dgv_HDNV.RowTemplate.Height = 24;
            this.dgv_HDNV.Size = new System.Drawing.Size(1745, 577);
            this.dgv_HDNV.TabIndex = 2;
            this.dgv_HDNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HDNV_CellClick);
            this.dgv_HDNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HDNV_CellContentClick);
            this.dgv_HDNV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_HDNV_CellFormatting);
            this.dgv_HDNV.SelectionChanged += new System.EventHandler(this.dgv_HDNV_SelectionChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCapNhat.Image = global::QLNS.Properties.Resources.hire;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(270, 91);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(244, 48);
            this.btnCapNhat.TabIndex = 35;
            this.btnCapNhat.Text = "Lưu cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Red;
            this.btnHuy.Image = global::QLNS.Properties.Resources.business;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(16, 91);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(248, 48);
            this.btnHuy.TabIndex = 34;
            this.btnHuy.Text = "Hủy cập nhật";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Image = global::QLNS.Properties.Resources.user;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(16, 36);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(248, 48);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa thông tin";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuyHD
            // 
            this.btnHuyHD.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyHD.ForeColor = System.Drawing.Color.Red;
            this.btnHuyHD.Image = global::QLNS.Properties.Resources.resign;
            this.btnHuyHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyHD.Location = new System.Drawing.Point(16, 150);
            this.btnHuyHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuyHD.Name = "btnHuyHD";
            this.btnHuyHD.Size = new System.Drawing.Size(248, 48);
            this.btnHuyHD.TabIndex = 2;
            this.btnHuyHD.Text = "Hủy họp đồng";
            this.btnHuyHD.UseVisualStyleBackColor = true;
            this.btnHuyHD.Click += new System.EventHandler(this.btnHuyHD_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHD.ForeColor = System.Drawing.Color.Blue;
            this.btnThemHD.Image = global::QLNS.Properties.Resources.checklist;
            this.btnThemHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHD.Location = new System.Drawing.Point(270, 36);
            this.btnThemHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(248, 48);
            this.btnThemHD.TabIndex = 0;
            this.btnThemHD.Text = "  Thêm họp đồng";
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // formHopDongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1745, 919);
            this.Controls.Add(this.dgv_HDNV);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formHopDongNhanVien";
            this.Text = "HopDongNhanVien";
            this.Load += new System.EventHandler(this.formHopDongNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HDNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHuyHD;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_HDNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_MucLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ThoiHanHD;
        private System.Windows.Forms.MaskedTextBox txt_NgayKT;
        private System.Windows.Forms.MaskedTextBox txt_NgayBD;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnCapNhat;
    }
}