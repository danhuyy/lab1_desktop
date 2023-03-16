namespace BTWindowsForms
{
    partial class frmBai3
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
            this.txta = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTongn = new System.Windows.Forms.RadioButton();
            this.btnXemkq = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.rdTongAB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a= ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số b= ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = " Kết quả là:";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(126, 136);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(87, 20);
            this.txta.TabIndex = 1;
            this.txta.Text = "0";
            this.txta.TextChanged += new System.EventHandler(this.txta_TextChanged);
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(126, 185);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(87, 20);
            this.txtn.TabIndex = 1;
            this.txtn.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(87, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "0";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(126, 159);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(87, 20);
            this.txtb.TabIndex = 1;
            this.txtb.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTongAB);
            this.groupBox1.Controls.Add(this.rbTongn);
            this.groupBox1.Location = new System.Drawing.Point(84, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 93);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán";
            // 
            // rbTongn
            // 
            this.rbTongn.AutoSize = true;
            this.rbTongn.Location = new System.Drawing.Point(6, 54);
            this.rbTongn.Name = "rbTongn";
            this.rbTongn.Size = new System.Drawing.Size(124, 17);
            this.rbTongn.TabIndex = 0;
            this.rbTongn.Text = "Tính tổng từ 1 đến n";
            this.rbTongn.UseVisualStyleBackColor = true;
            // 
            // btnXemkq
            // 
            this.btnXemkq.Location = new System.Drawing.Point(110, 327);
            this.btnXemkq.Name = "btnXemkq";
            this.btnXemkq.Size = new System.Drawing.Size(91, 23);
            this.btnXemkq.TabIndex = 3;
            this.btnXemkq.Text = "Xem kết quả";
            this.btnXemkq.UseVisualStyleBackColor = true;
            this.btnXemkq.Click += new System.EventHandler(this.btnXemkq_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(140, 368);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(10, 13);
            this.lblKetQua.TabIndex = 0;
            this.lblKetQua.Text = " ";
            this.lblKetQua.UseMnemonic = false;
            // 
            // rdTongAB
            // 
            this.rdTongAB.AutoSize = true;
            this.rdTongAB.Checked = true;
            this.rdTongAB.Location = new System.Drawing.Point(6, 31);
            this.rdTongAB.Name = "rdTongAB";
            this.rdTongAB.Size = new System.Drawing.Size(90, 17);
            this.rdTongAB.TabIndex = 0;
            this.rdTongAB.TabStop = true;
            this.rdTongAB.Text = "Tính tổng a,b";
            this.rdTongAB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số n= ";
            this.label4.UseMnemonic = false;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXemkq);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "Bài 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTongn;
        private System.Windows.Forms.Button btnXemkq;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.RadioButton rdTongAB;
        private System.Windows.Forms.Label label4;
    }
}