﻿namespace BTWindowsForms
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbbai3 = new System.Windows.Forms.ToolStripButton();
            this.tsbbai2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.tsbbai2,
            this.tsbbai3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbbai3
            // 
            this.tsbbai3.Image = ((System.Drawing.Image)(resources.GetObject("tsbbai3.Image")));
            this.tsbbai3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbai3.Name = "tsbbai3";
            this.tsbbai3.Size = new System.Drawing.Size(52, 22);
            this.tsbbai3.Text = "Bài 3";
            this.tsbbai3.Click += new System.EventHandler(this.tsbbai1_Click);
            // 
            // tsbbai2
            // 
            this.tsbbai2.Image = ((System.Drawing.Image)(resources.GetObject("tsbbai2.Image")));
            this.tsbbai2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbai2.Name = "tsbbai2";
            this.tsbbai2.Size = new System.Drawing.Size(52, 22);
            this.tsbbai2.Text = "Bài 2";
            this.tsbbai2.Click += new System.EventHandler(this.tsbbai2_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton2.Text = "Bài 1";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmChinh";
            this.Text = "Chương trình chính";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbbai3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton tsbbai2;
    }
}

