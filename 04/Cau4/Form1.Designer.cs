
namespace Cau4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_maHV = new System.Windows.Forms.TextBox();
            this.txt_tenHV = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_maLop = new System.Windows.Forms.TextBox();
            this.dtp_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.but_them = new System.Windows.Forms.Button();
            this.but_sua = new System.Windows.Forms.Button();
            this.but_xoa = new System.Windows.Forms.Button();
            this.dgv_hocVien = new System.Windows.Forms.DataGridView();
            this.dtp_ngayVao = new System.Windows.Forms.DateTimePicker();
            this.TenHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hocVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên học viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày vào";
            // 
            // txt_maHV
            // 
            this.txt_maHV.Location = new System.Drawing.Point(110, 6);
            this.txt_maHV.Name = "txt_maHV";
            this.txt_maHV.Size = new System.Drawing.Size(232, 26);
            this.txt_maHV.TabIndex = 1;
            // 
            // txt_tenHV
            // 
            this.txt_tenHV.Location = new System.Drawing.Point(110, 38);
            this.txt_tenHV.Name = "txt_tenHV";
            this.txt_tenHV.Size = new System.Drawing.Size(232, 26);
            this.txt_tenHV.TabIndex = 1;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(110, 70);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(232, 26);
            this.txt_tel.TabIndex = 1;
            // 
            // txt_maLop
            // 
            this.txt_maLop.Location = new System.Drawing.Point(458, 9);
            this.txt_maLop.Name = "txt_maLop";
            this.txt_maLop.Size = new System.Drawing.Size(232, 26);
            this.txt_maLop.TabIndex = 1;
            // 
            // dtp_ngaySinh
            // 
            this.dtp_ngaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaySinh.Location = new System.Drawing.Point(458, 41);
            this.dtp_ngaySinh.Name = "dtp_ngaySinh";
            this.dtp_ngaySinh.Size = new System.Drawing.Size(232, 26);
            this.dtp_ngaySinh.TabIndex = 2;
            // 
            // but_them
            // 
            this.but_them.Location = new System.Drawing.Point(11, 102);
            this.but_them.Name = "but_them";
            this.but_them.Size = new System.Drawing.Size(106, 42);
            this.but_them.TabIndex = 3;
            this.but_them.Text = "Thêm";
            this.but_them.UseVisualStyleBackColor = true;
            this.but_them.Click += new System.EventHandler(this.but_them_Click);
            // 
            // but_sua
            // 
            this.but_sua.Location = new System.Drawing.Point(123, 102);
            this.but_sua.Name = "but_sua";
            this.but_sua.Size = new System.Drawing.Size(106, 42);
            this.but_sua.TabIndex = 3;
            this.but_sua.Text = "Sửa";
            this.but_sua.UseVisualStyleBackColor = true;
            this.but_sua.Click += new System.EventHandler(this.but_sua_Click);
            // 
            // but_xoa
            // 
            this.but_xoa.Location = new System.Drawing.Point(236, 102);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(106, 42);
            this.but_xoa.TabIndex = 3;
            this.but_xoa.Text = "Xoá";
            this.but_xoa.UseVisualStyleBackColor = true;
            this.but_xoa.Click += new System.EventHandler(this.but_xoa_Click);
            // 
            // dgv_hocVien
            // 
            this.dgv_hocVien.AllowUserToAddRows = false;
            this.dgv_hocVien.AllowUserToDeleteRows = false;
            this.dgv_hocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hocVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHV,
            this.MaHV,
            this.NgaySinh,
            this.Tel,
            this.MaLop,
            this.NgayVao});
            this.dgv_hocVien.Location = new System.Drawing.Point(15, 150);
            this.dgv_hocVien.MultiSelect = false;
            this.dgv_hocVien.Name = "dgv_hocVien";
            this.dgv_hocVien.ReadOnly = true;
            this.dgv_hocVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hocVien.Size = new System.Drawing.Size(757, 399);
            this.dgv_hocVien.TabIndex = 4;
            this.dgv_hocVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hocVien_RowEnter);
            // 
            // dtp_ngayVao
            // 
            this.dtp_ngayVao.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngayVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayVao.Location = new System.Drawing.Point(458, 71);
            this.dtp_ngayVao.Name = "dtp_ngayVao";
            this.dtp_ngayVao.Size = new System.Drawing.Size(232, 26);
            this.dtp_ngayVao.TabIndex = 5;
            // 
            // TenHV
            // 
            this.TenHV.DataPropertyName = "TenHV";
            this.TenHV.HeaderText = "Tên học viên";
            this.TenHV.Name = "TenHV";
            this.TenHV.ReadOnly = true;
            this.TenHV.Width = 125;
            // 
            // MaHV
            // 
            this.MaHV.DataPropertyName = "MaHV";
            this.MaHV.HeaderText = "Mã học viên";
            this.MaHV.Name = "MaHV";
            this.MaHV.ReadOnly = true;
            this.MaHV.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "Tel";
            this.Tel.HeaderText = "Tel";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            // 
            // NgayVao
            // 
            this.NgayVao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayVao.DataPropertyName = "NgayVao";
            this.NgayVao.HeaderText = "Ngày vào";
            this.NgayVao.Name = "NgayVao";
            this.NgayVao.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dtp_ngayVao);
            this.Controls.Add(this.dgv_hocVien);
            this.Controls.Add(this.but_xoa);
            this.Controls.Add(this.but_sua);
            this.Controls.Add(this.but_them);
            this.Controls.Add(this.dtp_ngaySinh);
            this.Controls.Add(this.txt_maLop);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_tenHV);
            this.Controls.Add(this.txt_maHV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hocVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_maHV;
        private System.Windows.Forms.TextBox txt_tenHV;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_maLop;
        private System.Windows.Forms.DateTimePicker dtp_ngaySinh;
        private System.Windows.Forms.Button but_them;
        private System.Windows.Forms.Button but_sua;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.DataGridView dgv_hocVien;
        private System.Windows.Forms.DateTimePicker dtp_ngayVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVao;
    }
}

