namespace WindowsFormsApplication1
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
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.dgvnv = new System.Windows.Forms.DataGridView();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.radoten = new System.Windows.Forms.RadioButton();
            this.radongaysinh = new System.Windows.Forms.RadioButton();
            this.radonam = new System.Windows.Forms.RadioButton();
            this.radonu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma NV";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(104, 36);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(132, 22);
            this.txtmanv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ten NV";
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(104, 81);
            this.txttennv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(132, 22);
            this.txttennv.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngay sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dia chi";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(104, 197);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(132, 22);
            this.txtdiachi.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "SDT";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(104, 229);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(132, 22);
            this.txtsdt.TabIndex = 1;
            this.txtsdt.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaysinh.Location = new System.Drawing.Point(104, 113);
            this.dtngaysinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(177, 22);
            this.dtngaysinh.TabIndex = 2;
            this.dtngaysinh.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dgvnv
            // 
            this.dgvnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnv.Location = new System.Drawing.Point(459, 15);
            this.dgvnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvnv.Name = "dgvnv";
            this.dgvnv.Size = new System.Drawing.Size(837, 494);
            this.dgvnv.TabIndex = 3;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(183, 304);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 28);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "Xoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(40, 304);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 28);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Them";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(40, 362);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 28);
            this.btnsua.TabIndex = 4;
            this.btnsua.Text = "Sua";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(183, 362);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(100, 28);
            this.btnluu.TabIndex = 4;
            this.btnluu.Text = "Luu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(16, 430);
            this.btntim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(100, 28);
            this.btntim.TabIndex = 4;
            this.btntim.Text = "Tim kiem";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(124, 438);
            this.txttim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(132, 22);
            this.txttim.TabIndex = 1;
            this.txttim.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // radoten
            // 
            this.radoten.AutoSize = true;
            this.radoten.Location = new System.Drawing.Point(265, 430);
            this.radoten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radoten.Name = "radoten";
            this.radoten.Size = new System.Drawing.Size(72, 21);
            this.radoten.TabIndex = 5;
            this.radoten.TabStop = true;
            this.radoten.Text = "ten NV";
            this.radoten.UseVisualStyleBackColor = true;
            // 
            // radongaysinh
            // 
            this.radongaysinh.AutoSize = true;
            this.radongaysinh.Location = new System.Drawing.Point(265, 458);
            this.radongaysinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radongaysinh.Name = "radongaysinh";
            this.radongaysinh.Size = new System.Drawing.Size(92, 21);
            this.radongaysinh.TabIndex = 5;
            this.radongaysinh.TabStop = true;
            this.radongaysinh.Text = "Ngay sinh";
            this.radongaysinh.UseVisualStyleBackColor = true;
            // 
            // radonam
            // 
            this.radonam.AutoSize = true;
            this.radonam.Location = new System.Drawing.Point(104, 162);
            this.radonam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radonam.Name = "radonam";
            this.radonam.Size = new System.Drawing.Size(58, 21);
            this.radonam.TabIndex = 6;
            this.radonam.TabStop = true;
            this.radonam.Text = "Nam";
            this.radonam.UseVisualStyleBackColor = true;
            // 
            // radonu
            // 
            this.radonu.AutoSize = true;
            this.radonu.Location = new System.Drawing.Point(205, 162);
            this.radonu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radonu.Name = "radonu";
            this.radonu.Size = new System.Drawing.Size(47, 21);
            this.radonu.TabIndex = 6;
            this.radonu.TabStop = true;
            this.radonu.Text = "Nu";
            this.radonu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 626);
            this.Controls.Add(this.radonu);
            this.Controls.Add(this.radonam);
            this.Controls.Add(this.radongaysinh);
            this.Controls.Add(this.radoten);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.dgvnv);
            this.Controls.Add(this.dtngaysinh);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private System.Windows.Forms.DataGridView dgvnv;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.RadioButton radoten;
        private System.Windows.Forms.RadioButton radongaysinh;
        private System.Windows.Forms.RadioButton radonam;
        private System.Windows.Forms.RadioButton radonu;
    }
}

