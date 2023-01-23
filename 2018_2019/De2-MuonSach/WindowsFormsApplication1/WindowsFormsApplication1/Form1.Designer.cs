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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.txttheloai = new System.Windows.Forms.TextBox();
            this.txtnamxb = new System.Windows.Forms.TextBox();
            this.txttrangthai = new System.Windows.Forms.TextBox();
            this.cbmanxb = new System.Windows.Forms.ComboBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dgvsach = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.rdtensach = new System.Windows.Forms.RadioButton();
            this.rdnamxb = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten sach";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ma sach";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nam XB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "The loai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Trang thai";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ma NXB";
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(117, 31);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(100, 20);
            this.txtmasach.TabIndex = 1;
            // 
            // txttensach
            // 
            this.txttensach.Location = new System.Drawing.Point(117, 64);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(100, 20);
            this.txttensach.TabIndex = 1;
            // 
            // txttheloai
            // 
            this.txttheloai.Location = new System.Drawing.Point(117, 97);
            this.txttheloai.Name = "txttheloai";
            this.txttheloai.Size = new System.Drawing.Size(100, 20);
            this.txttheloai.TabIndex = 1;
            // 
            // txtnamxb
            // 
            this.txtnamxb.Location = new System.Drawing.Point(117, 130);
            this.txtnamxb.Name = "txtnamxb";
            this.txtnamxb.Size = new System.Drawing.Size(100, 20);
            this.txtnamxb.TabIndex = 1;
            // 
            // txttrangthai
            // 
            this.txttrangthai.Location = new System.Drawing.Point(117, 201);
            this.txttrangthai.Name = "txttrangthai";
            this.txttrangthai.Size = new System.Drawing.Size(100, 20);
            this.txttrangthai.TabIndex = 1;
            // 
            // cbmanxb
            // 
            this.cbmanxb.FormattingEnabled = true;
            this.cbmanxb.Location = new System.Drawing.Point(117, 165);
            this.cbmanxb.Name = "cbmanxb";
            this.cbmanxb.Size = new System.Drawing.Size(121, 21);
            this.cbmanxb.TabIndex = 2;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(12, 272);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Them ";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(117, 314);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 3;
            this.btnluu.Text = "Luu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(12, 314);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sua";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(117, 272);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // dgvsach
            // 
            this.dgvsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsach.Location = new System.Drawing.Point(261, 12);
            this.dgvsach.Name = "dgvsach";
            this.dgvsach.Size = new System.Drawing.Size(640, 316);
            this.dgvsach.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tim kiem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(358, 369);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(100, 20);
            this.txttimkiem.TabIndex = 6;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // rdtensach
            // 
            this.rdtensach.AutoSize = true;
            this.rdtensach.Location = new System.Drawing.Point(508, 358);
            this.rdtensach.Name = "rdtensach";
            this.rdtensach.Size = new System.Drawing.Size(70, 17);
            this.rdtensach.TabIndex = 7;
            this.rdtensach.TabStop = true;
            this.rdtensach.Text = "Ten sach";
            this.rdtensach.UseVisualStyleBackColor = true;
            // 
            // rdnamxb
            // 
            this.rdnamxb.AutoSize = true;
            this.rdnamxb.Location = new System.Drawing.Point(508, 381);
            this.rdnamxb.Name = "rdnamxb";
            this.rdnamxb.Size = new System.Drawing.Size(64, 17);
            this.rdnamxb.TabIndex = 8;
            this.rdnamxb.TabStop = true;
            this.rdnamxb.Text = "Nam XB";
            this.rdnamxb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 427);
            this.Controls.Add(this.rdnamxb);
            this.Controls.Add(this.rdtensach);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvsach);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.cbmanxb);
            this.Controls.Add(this.txttrangthai);
            this.Controls.Add(this.txtnamxb);
            this.Controls.Add(this.txttheloai);
            this.Controls.Add(this.txttensach);
            this.Controls.Add(this.txtmasach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvsach)).EndInit();
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
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.TextBox txttheloai;
        private System.Windows.Forms.TextBox txtnamxb;
        private System.Windows.Forms.TextBox txttrangthai;
        private System.Windows.Forms.ComboBox cbmanxb;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView dgvsach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.RadioButton rdtensach;
        private System.Windows.Forms.RadioButton rdnamxb;
    }
}

