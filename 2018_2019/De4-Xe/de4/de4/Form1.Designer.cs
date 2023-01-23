namespace de4
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
            this.txtmaxe = new System.Windows.Forms.TextBox();
            this.txttenxe = new System.Windows.Forms.TextBox();
            this.txtlaixe = new System.Windows.Forms.TextBox();
            this.txtphuxe = new System.Windows.Forms.TextBox();
            this.txtsocho = new System.Windows.Forms.TextBox();
            this.rdxedi = new System.Windows.Forms.RadioButton();
            this.rdxecho = new System.Windows.Forms.RadioButton();
            this.dgvxe = new System.Windows.Forms.DataGridView();
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttkten = new System.Windows.Forms.TextBox();
            this.txttklaixe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvxe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lái xe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phụ xe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số chỗ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tình Trạng";
            // 
            // txtmaxe
            // 
            this.txtmaxe.Location = new System.Drawing.Point(94, 24);
            this.txtmaxe.Name = "txtmaxe";
            this.txtmaxe.Size = new System.Drawing.Size(100, 20);
            this.txtmaxe.TabIndex = 6;
            // 
            // txttenxe
            // 
            this.txttenxe.Location = new System.Drawing.Point(94, 60);
            this.txttenxe.Name = "txttenxe";
            this.txttenxe.Size = new System.Drawing.Size(100, 20);
            this.txttenxe.TabIndex = 7;
            // 
            // txtlaixe
            // 
            this.txtlaixe.Location = new System.Drawing.Point(94, 95);
            this.txtlaixe.Name = "txtlaixe";
            this.txtlaixe.Size = new System.Drawing.Size(100, 20);
            this.txtlaixe.TabIndex = 8;
            // 
            // txtphuxe
            // 
            this.txtphuxe.Location = new System.Drawing.Point(315, 24);
            this.txtphuxe.Name = "txtphuxe";
            this.txtphuxe.Size = new System.Drawing.Size(100, 20);
            this.txtphuxe.TabIndex = 9;
            // 
            // txtsocho
            // 
            this.txtsocho.Location = new System.Drawing.Point(315, 60);
            this.txtsocho.Name = "txtsocho";
            this.txtsocho.Size = new System.Drawing.Size(100, 20);
            this.txtsocho.TabIndex = 10;
            // 
            // rdxedi
            // 
            this.rdxedi.AutoSize = true;
            this.rdxedi.Location = new System.Drawing.Point(330, 98);
            this.rdxedi.Name = "rdxedi";
            this.rdxedi.Size = new System.Drawing.Size(50, 17);
            this.rdxedi.TabIndex = 11;
            this.rdxedi.TabStop = true;
            this.rdxedi.Text = "Xe đi";
            this.rdxedi.UseVisualStyleBackColor = true;
            // 
            // rdxecho
            // 
            this.rdxecho.AutoSize = true;
            this.rdxecho.Location = new System.Drawing.Point(398, 98);
            this.rdxecho.Name = "rdxecho";
            this.rdxecho.Size = new System.Drawing.Size(59, 17);
            this.rdxecho.TabIndex = 12;
            this.rdxecho.TabStop = true;
            this.rdxecho.Text = "Xe chờ";
            this.rdxecho.UseVisualStyleBackColor = true;
            // 
            // dgvxe
            // 
            this.dgvxe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvxe.Location = new System.Drawing.Point(34, 165);
            this.dgvxe.Name = "dgvxe";
            this.dgvxe.Size = new System.Drawing.Size(346, 129);
            this.dgvxe.TabIndex = 13;
            this.dgvxe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvxe_CellContentClick);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(34, 136);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 14;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(132, 136);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 15;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(222, 136);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 16;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(305, 136);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 17;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttklaixe);
            this.groupBox1.Controls.Add(this.txttkten);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(398, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 158);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tên xe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Lái xe";
            // 
            // txttkten
            // 
            this.txttkten.Location = new System.Drawing.Point(22, 54);
            this.txttkten.Name = "txttkten";
            this.txttkten.Size = new System.Drawing.Size(100, 20);
            this.txttkten.TabIndex = 10;
            this.txttkten.TextChanged += new System.EventHandler(this.txttkten_TextChanged);
            // 
            // txttklaixe
            // 
            this.txttklaixe.Location = new System.Drawing.Point(22, 111);
            this.txttklaixe.Name = "txttklaixe";
            this.txttklaixe.Size = new System.Drawing.Size(100, 20);
            this.txttklaixe.TabIndex = 11;
            this.txttklaixe.TextChanged += new System.EventHandler(this.txttklaixe_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 306);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.dgvxe);
            this.Controls.Add(this.rdxecho);
            this.Controls.Add(this.rdxedi);
            this.Controls.Add(this.txtsocho);
            this.Controls.Add(this.txtphuxe);
            this.Controls.Add(this.txtlaixe);
            this.Controls.Add(this.txttenxe);
            this.Controls.Add(this.txtmaxe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvxe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtmaxe;
        private System.Windows.Forms.TextBox txttenxe;
        private System.Windows.Forms.TextBox txtlaixe;
        private System.Windows.Forms.TextBox txtphuxe;
        private System.Windows.Forms.TextBox txtsocho;
        private System.Windows.Forms.RadioButton rdxedi;
        private System.Windows.Forms.RadioButton rdxecho;
        private System.Windows.Forms.DataGridView dgvxe;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttklaixe;
        private System.Windows.Forms.TextBox txttkten;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

