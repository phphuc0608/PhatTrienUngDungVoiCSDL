namespace WindowsFormsApp1
{
    partial class Cau5
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
            this.chbTenDT = new System.Windows.Forms.CheckBox();
            this.chbTenGV = new System.Windows.Forms.CheckBox();
            this.txbTenDT = new System.Windows.Forms.TextBox();
            this.txbTenGV = new System.Windows.Forms.TextBox();
            this.dgvDeTai = new System.Windows.Forms.DataGridView();
            this.colMaDetai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeTai)).BeginInit();
            this.SuspendLayout();
            // 
            // chbTenDT
            // 
            this.chbTenDT.AutoSize = true;
            this.chbTenDT.Location = new System.Drawing.Point(23, 72);
            this.chbTenDT.Name = "chbTenDT";
            this.chbTenDT.Size = new System.Drawing.Size(83, 20);
            this.chbTenDT.TabIndex = 0;
            this.chbTenDT.Text = "Tên đề tài";
            this.chbTenDT.UseVisualStyleBackColor = true;
            // 
            // chbTenGV
            // 
            this.chbTenGV.AutoSize = true;
            this.chbTenGV.Location = new System.Drawing.Point(447, 70);
            this.chbTenGV.Name = "chbTenGV";
            this.chbTenGV.Size = new System.Drawing.Size(101, 20);
            this.chbTenGV.TabIndex = 1;
            this.chbTenGV.Text = "Tên giáo viên";
            this.chbTenGV.UseVisualStyleBackColor = true;
            // 
            // txbTenDT
            // 
            this.txbTenDT.Location = new System.Drawing.Point(148, 70);
            this.txbTenDT.Name = "txbTenDT";
            this.txbTenDT.Size = new System.Drawing.Size(180, 22);
            this.txbTenDT.TabIndex = 2;
            // 
            // txbTenGV
            // 
            this.txbTenGV.Location = new System.Drawing.Point(572, 70);
            this.txbTenGV.Name = "txbTenGV";
            this.txbTenGV.Size = new System.Drawing.Size(189, 22);
            this.txbTenGV.TabIndex = 3;
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
            this.dgvDeTai.Location = new System.Drawing.Point(23, 213);
            this.dgvDeTai.MultiSelect = false;
            this.dgvDeTai.Name = "dgvDeTai";
            this.dgvDeTai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeTai.Size = new System.Drawing.Size(729, 281);
            this.dgvDeTai.TabIndex = 4;
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
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(259, 146);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(97, 32);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(429, 146);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(119, 32);
            this.btnTroLai.TabIndex = 6;
            this.btnTroLai.Text = "Trở lại trang chủ";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // Cau5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvDeTai);
            this.Controls.Add(this.txbTenGV);
            this.Controls.Add(this.txbTenDT);
            this.Controls.Add(this.chbTenGV);
            this.Controls.Add(this.chbTenDT);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cau5";
            this.Text = "Cau5";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeTai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbTenDT;
        private System.Windows.Forms.CheckBox chbTenGV;
        private System.Windows.Forms.TextBox txbTenDT;
        private System.Windows.Forms.TextBox txbTenGV;
        private System.Windows.Forms.DataGridView dgvDeTai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDetai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGV;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTroLai;
    }
}