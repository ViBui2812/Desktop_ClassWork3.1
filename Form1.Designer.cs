namespace Desktop_ClassWork3._1
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.rbtnCong = new System.Windows.Forms.RadioButton();
            this.rbtnTru = new System.Windows.Forms.RadioButton();
            this.rbtnNhan = new System.Windows.Forms.RadioButton();
            this.rbtnChia = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chbBinhphuong = new System.Windows.Forms.CheckBox();
            this.chbLamtron = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(112, 56);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(198, 22);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(112, 84);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(198, 22);
            this.txtB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "b";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(112, 112);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(97, 33);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // rbtnCong
            // 
            this.rbtnCong.AutoSize = true;
            this.rbtnCong.Location = new System.Drawing.Point(6, 21);
            this.rbtnCong.Name = "rbtnCong";
            this.rbtnCong.Size = new System.Drawing.Size(60, 20);
            this.rbtnCong.TabIndex = 5;
            this.rbtnCong.TabStop = true;
            this.rbtnCong.Text = "Cộng";
            this.rbtnCong.UseVisualStyleBackColor = true;
            this.rbtnCong.CheckedChanged += new System.EventHandler(this.rbtnCong_CheckedChanged);
            // 
            // rbtnTru
            // 
            this.rbtnTru.AutoSize = true;
            this.rbtnTru.Location = new System.Drawing.Point(6, 47);
            this.rbtnTru.Name = "rbtnTru";
            this.rbtnTru.Size = new System.Drawing.Size(48, 20);
            this.rbtnTru.TabIndex = 6;
            this.rbtnTru.TabStop = true;
            this.rbtnTru.Text = "Trừ";
            this.rbtnTru.UseVisualStyleBackColor = true;
            this.rbtnTru.CheckedChanged += new System.EventHandler(this.rbtnTru_CheckedChanged);
            // 
            // rbtnNhan
            // 
            this.rbtnNhan.AutoSize = true;
            this.rbtnNhan.Location = new System.Drawing.Point(6, 73);
            this.rbtnNhan.Name = "rbtnNhan";
            this.rbtnNhan.Size = new System.Drawing.Size(60, 20);
            this.rbtnNhan.TabIndex = 7;
            this.rbtnNhan.TabStop = true;
            this.rbtnNhan.Text = "Nhân";
            this.rbtnNhan.UseVisualStyleBackColor = true;
            this.rbtnNhan.CheckedChanged += new System.EventHandler(this.rbtnNhan_CheckedChanged);
            // 
            // rbtnChia
            // 
            this.rbtnChia.AutoSize = true;
            this.rbtnChia.Location = new System.Drawing.Point(6, 99);
            this.rbtnChia.Name = "rbtnChia";
            this.rbtnChia.Size = new System.Drawing.Size(55, 20);
            this.rbtnChia.TabIndex = 8;
            this.rbtnChia.TabStop = true;
            this.rbtnChia.Text = "Chia";
            this.rbtnChia.UseVisualStyleBackColor = true;
            this.rbtnChia.CheckedChanged += new System.EventHandler(this.rbtnChia_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(112, 181);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 180);
            this.listBox1.TabIndex = 9;
            // 
            // chbBinhphuong
            // 
            this.chbBinhphuong.AutoSize = true;
            this.chbBinhphuong.Location = new System.Drawing.Point(371, 181);
            this.chbBinhphuong.Name = "chbBinhphuong";
            this.chbBinhphuong.Size = new System.Drawing.Size(124, 20);
            this.chbBinhphuong.TabIndex = 10;
            this.chbBinhphuong.Text = "Bình phương KQ";
            this.chbBinhphuong.UseVisualStyleBackColor = true;
            this.chbBinhphuong.CheckedChanged += new System.EventHandler(this.chbBinhphuong_CheckedChanged);
            // 
            // chbLamtron
            // 
            this.chbLamtron.AutoSize = true;
            this.chbLamtron.Location = new System.Drawing.Point(371, 207);
            this.chbLamtron.Name = "chbLamtron";
            this.chbLamtron.Size = new System.Drawing.Size(101, 20);
            this.chbLamtron.TabIndex = 11;
            this.chbLamtron.Text = "Làm tròn KQ";
            this.chbLamtron.UseVisualStyleBackColor = true;
            this.chbLamtron.CheckedChanged += new System.EventHandler(this.chbLamtron_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Phép tính";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbtnCong);
            this.groupBox1.Controls.Add(this.rbtnChia);
            this.groupBox1.Controls.Add(this.rbtnNhan);
            this.groupBox1.Controls.Add(this.rbtnTru);
            this.groupBox1.Location = new System.Drawing.Point(371, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 126);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chbLamtron);
            this.Controls.Add(this.chbBinhphuong);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.RadioButton rbtnCong;
        private System.Windows.Forms.RadioButton rbtnTru;
        private System.Windows.Forms.RadioButton rbtnNhan;
        private System.Windows.Forms.RadioButton rbtnChia;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox chbBinhphuong;
        private System.Windows.Forms.CheckBox chbLamtron;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

