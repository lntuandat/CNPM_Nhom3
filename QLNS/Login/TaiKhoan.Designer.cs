namespace QLNS.Login
{
    partial class TaiKhoan
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
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.dgv_TK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenTK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.tx = new System.Windows.Forms.Label();
            this.QUyền = new System.Windows.Forms.Label();
            this.txt_MaTK = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQuyen = new System.Windows.Forms.TextBox();
            this.btnXoaTK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TK)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Image = global::QLNS.Properties.Resources.user;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(14, 29);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(220, 38);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa thông tin";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemTK
            // 
            this.btnThemTK.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTK.ForeColor = System.Drawing.Color.Blue;
            this.btnThemTK.Image = global::QLNS.Properties.Resources.checklist;
            this.btnThemTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTK.Location = new System.Drawing.Point(240, 29);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(220, 38);
            this.btnThemTK.TabIndex = 0;
            this.btnThemTK.Text = "  Thêm Tài Khoản";
            this.btnThemTK.UseVisualStyleBackColor = true;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // dgv_TK
            // 
            this.dgv_TK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TK.Location = new System.Drawing.Point(0, 274);
            this.dgv_TK.Name = "dgv_TK";
            this.dgv_TK.RowHeadersWidth = 51;
            this.dgv_TK.RowTemplate.Height = 24;
            this.dgv_TK.Size = new System.Drawing.Size(1181, 333);
            this.dgv_TK.TabIndex = 4;
            this.dgv_TK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TK_CellClick);
            this.dgv_TK.SelectionChanged += new System.EventHandler(this.dgv_TK_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(513, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // txt_TenTK
            // 
            this.txt_TenTK.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTK.Location = new System.Drawing.Point(192, 62);
            this.txt_TenTK.Name = "txt_TenTK";
            this.txt_TenTK.Size = new System.Drawing.Size(273, 30);
            this.txt_TenTK.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Tài Khoản";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoaTK);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThemTK);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(821, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 178);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQuyen);
            this.groupBox1.Controls.Add(this.txtPassWord);
            this.groupBox1.Controls.Add(this.tx);
            this.groupBox1.Controls.Add(this.QUyền);
            this.groupBox1.Controls.Add(this.txt_TenTK);
            this.groupBox1.Controls.Add(this.txt_MaTK);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(145, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin họp đồng";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(192, 132);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(273, 27);
            this.txtPassWord.TabIndex = 19;
            // 
            // tx
            // 
            this.tx.AutoSize = true;
            this.tx.Location = new System.Drawing.Point(19, 132);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(85, 23);
            this.tx.TabIndex = 18;
            this.tx.Text = "PassWord";
            // 
            // QUyền
            // 
            this.QUyền.AutoSize = true;
            this.QUyền.Location = new System.Drawing.Point(19, 99);
            this.QUyền.Name = "QUyền";
            this.QUyền.Size = new System.Drawing.Size(63, 23);
            this.QUyền.TabIndex = 16;
            this.QUyền.Text = "Quyền";
            // 
            // txt_MaTK
            // 
            this.txt_MaTK.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaTK.Location = new System.Drawing.Point(192, 26);
            this.txt_MaTK.Name = "txt_MaTK";
            this.txt_MaTK.Size = new System.Drawing.Size(273, 30);
            this.txt_MaTK.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 274);
            this.panel1.TabIndex = 3;
            // 
            // txtQuyen
            // 
            this.txtQuyen.Location = new System.Drawing.Point(192, 99);
            this.txtQuyen.Name = "txtQuyen";
            this.txtQuyen.Size = new System.Drawing.Size(273, 27);
            this.txtQuyen.TabIndex = 20;
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.Location = new System.Drawing.Point(143, 73);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(158, 27);
            this.btnXoaTK.TabIndex = 4;
            this.btnXoaTK.Text = "Xóa Tài Khoản";
            this.btnXoaTK.UseVisualStyleBackColor = true;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1181, 607);
            this.Controls.Add(this.dgv_TK);
            this.Controls.Add(this.panel1);
            this.Name = "TaiKhoan";
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TK)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.DataGridView dgv_TK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_MaTK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label QUyền;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label tx;
        private System.Windows.Forms.TextBox txtQuyen;
        private System.Windows.Forms.Button btnXoaTK;
    }
}