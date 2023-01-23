namespace WindowsFormsApp1
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
            this.dgvDeTai = new System.Windows.Forms.DataGridView();
            this.colMaDetai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txbMaDeTai = new System.Windows.Forms.TextBox();
            this.txbTenDeTai = new System.Windows.Forms.TextBox();
            this.txbHoTT = new System.Windows.Forms.TextBox();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.txbMaGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFrmTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeTai)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeTai
            // 
            this.dgvDeTai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeTai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDetai,
            this.colTenDT,
            this.colNgayBD,
            this.colNgayKT,
            this.colHoTT,
            this.colMaGV});
            this.dgvDeTai.Location = new System.Drawing.Point(44, 228);
            this.dgvDeTai.MultiSelect = false;
            this.dgvDeTai.Name = "dgvDeTai";
            this.dgvDeTai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeTai.Size = new System.Drawing.Size(645, 281);
            this.dgvDeTai.TabIndex = 0;
            this.dgvDeTai.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeTai_RowEnter);
            // 
            // colMaDetai
            // 
            this.colMaDetai.DataPropertyName = "MaDT";
            this.colMaDetai.HeaderText = "Mã đề tài";
            this.colMaDetai.Name = "colMaDetai";
            // 
            // colTenDT
            // 
            this.colTenDT.DataPropertyName = "TenDT";
            this.colTenDT.HeaderText = "Tên đề tài";
            this.colTenDT.Name = "colTenDT";
            // 
            // colNgayBD
            // 
            this.colNgayBD.DataPropertyName = "NgayBD";
            this.colNgayBD.HeaderText = "Ngày bắt đầu";
            this.colNgayBD.Name = "colNgayBD";
            // 
            // colNgayKT
            // 
            this.colNgayKT.DataPropertyName = "NgayKT";
            this.colNgayKT.HeaderText = "Ngày kết thúc";
            this.colNgayKT.Name = "colNgayKT";
            // 
            // colHoTT
            // 
            this.colHoTT.DataPropertyName = "HoTT";
            this.colHoTT.HeaderText = "HoTT";
            this.colHoTT.Name = "colHoTT";
            // 
            // colMaGV
            // 
            this.colMaGV.DataPropertyName = "MaGV";
            this.colMaGV.HeaderText = "Mã giáo viên";
            this.colMaGV.Name = "colMaGV";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(133, 149);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 32);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(333, 149);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 32);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(544, 149);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 32);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txbMaDeTai
            // 
            this.txbMaDeTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaDeTai.Location = new System.Drawing.Point(82, 33);
            this.txbMaDeTai.Name = "txbMaDeTai";
            this.txbMaDeTai.Size = new System.Drawing.Size(103, 22);
            this.txbMaDeTai.TabIndex = 5;
            // 
            // txbTenDeTai
            // 
            this.txbTenDeTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenDeTai.Location = new System.Drawing.Point(82, 74);
            this.txbTenDeTai.Name = "txbTenDeTai";
            this.txbTenDeTai.Size = new System.Drawing.Size(103, 22);
            this.txbTenDeTai.TabIndex = 7;
            // 
            // txbHoTT
            // 
            this.txbHoTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHoTT.Location = new System.Drawing.Point(565, 33);
            this.txbHoTT.Name = "txbHoTT";
            this.txbHoTT.Size = new System.Drawing.Size(171, 22);
            this.txbHoTT.TabIndex = 9;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBD.Location = new System.Drawing.Point(323, 37);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(105, 20);
            this.dtpNgayBD.TabIndex = 14;
            this.dtpNgayBD.Value = new System.DateTime(2023, 1, 15, 0, 0, 0, 0);
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKT.Location = new System.Drawing.Point(323, 77);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(105, 20);
            this.dtpNgayKT.TabIndex = 15;
            // 
            // txbMaGV
            // 
            this.txbMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaGV.Location = new System.Drawing.Point(565, 74);
            this.txbMaGV.Name = "txbMaGV";
            this.txbMaGV.Size = new System.Drawing.Size(171, 22);
            this.txbMaGV.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã đề tài";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(475, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "HoTT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Mã giáo viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Tên đề tài";
            // 
            // btnFrmTimKiem
            // 
            this.btnFrmTimKiem.Location = new System.Drawing.Point(403, 190);
            this.btnFrmTimKiem.Name = "btnFrmTimKiem";
            this.btnFrmTimKiem.Size = new System.Drawing.Size(142, 32);
            this.btnFrmTimKiem.TabIndex = 34;
            this.btnFrmTimKiem.Text = "Vào trang tìm kiếm";
            this.btnFrmTimKiem.UseVisualStyleBackColor = true;
            this.btnFrmTimKiem.Click += new System.EventHandler(this.btnFrmTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(232, 190);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(83, 32);
            this.btnLamMoi.TabIndex = 35;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 521);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnFrmTimKiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMaGV);
            this.Controls.Add(this.dtpNgayKT);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.txbHoTT);
            this.Controls.Add(this.txbTenDeTai);
            this.Controls.Add(this.txbMaDeTai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDeTai);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeTai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeTai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txbMaDeTai;
        private System.Windows.Forms.TextBox txbTenDeTai;
        private System.Windows.Forms.TextBox txbHoTT;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.TextBox txbMaGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDetai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGV;
        private System.Windows.Forms.Button btnFrmTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
    }
}

