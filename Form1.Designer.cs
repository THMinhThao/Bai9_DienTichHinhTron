namespace Bai9_DienTichHinhTron
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
            this.lblBK = new System.Windows.Forms.Label();
            this.txtBK = new System.Windows.Forms.TextBox();
            this.btnCV = new System.Windows.Forms.Button();
            this.btnDT = new System.Windows.Forms.Button();
            this.lblKQ = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCV = new System.Windows.Forms.RadioButton();
            this.rdbDT = new System.Windows.Forms.RadioButton();
            this.lblKQmoi = new System.Windows.Forms.Label();
            this.txtKQmoi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(145, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHU VI DIỆN TÍCH HÌNH TRÒN";
            // 
            // lblBK
            // 
            this.lblBK.AutoSize = true;
            this.lblBK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBK.Location = new System.Drawing.Point(22, 91);
            this.lblBK.Name = "lblBK";
            this.lblBK.Size = new System.Drawing.Size(102, 18);
            this.lblBK.TabIndex = 1;
            this.lblBK.Text = "Nhập bán kính";
            // 
            // txtBK
            // 
            this.txtBK.Location = new System.Drawing.Point(151, 92);
            this.txtBK.Name = "txtBK";
            this.txtBK.Size = new System.Drawing.Size(100, 20);
            this.txtBK.TabIndex = 2;
            // 
            // btnCV
            // 
            this.btnCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCV.Location = new System.Drawing.Point(51, 171);
            this.btnCV.Name = "btnCV";
            this.btnCV.Size = new System.Drawing.Size(110, 43);
            this.btnCV.TabIndex = 3;
            this.btnCV.Text = "Chu vi";
            this.btnCV.UseVisualStyleBackColor = true;
            // 
            // btnDT
            // 
            this.btnDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDT.Location = new System.Drawing.Point(197, 171);
            this.btnDT.Name = "btnDT";
            this.btnDT.Size = new System.Drawing.Size(110, 43);
            this.btnDT.TabIndex = 3;
            this.btnDT.Text = "Diện tích";
            this.btnDT.UseVisualStyleBackColor = true;
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblKQ.Location = new System.Drawing.Point(25, 241);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(58, 18);
            this.lblKQ.TabIndex = 4;
            this.lblKQ.Text = "Kết quả";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(124, 242);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 20);
            this.txtKQ.TabIndex = 5;
            this.txtKQ.TextChanged += new System.EventHandler(this.txtKQ_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDT);
            this.groupBox1.Controls.Add(this.rdbCV);
            this.groupBox1.Location = new System.Drawing.Point(414, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 123);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdbCV
            // 
            this.rdbCV.AutoSize = true;
            this.rdbCV.Location = new System.Drawing.Point(25, 32);
            this.rdbCV.Name = "rdbCV";
            this.rdbCV.Size = new System.Drawing.Size(55, 17);
            this.rdbCV.TabIndex = 0;
            this.rdbCV.TabStop = true;
            this.rdbCV.Text = "Chu vi";
            this.rdbCV.UseVisualStyleBackColor = true;
            // 
            // rdbDT
            // 
            this.rdbDT.AutoSize = true;
            this.rdbDT.Location = new System.Drawing.Point(25, 80);
            this.rdbDT.Name = "rdbDT";
            this.rdbDT.Size = new System.Drawing.Size(69, 17);
            this.rdbDT.TabIndex = 1;
            this.rdbDT.TabStop = true;
            this.rdbDT.Text = "Diện tích";
            this.rdbDT.UseVisualStyleBackColor = true;
            // 
            // lblKQmoi
            // 
            this.lblKQmoi.AutoSize = true;
            this.lblKQmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblKQmoi.Location = new System.Drawing.Point(384, 238);
            this.lblKQmoi.Name = "lblKQmoi";
            this.lblKQmoi.Size = new System.Drawing.Size(58, 18);
            this.lblKQmoi.TabIndex = 4;
            this.lblKQmoi.Text = "Kết quả";
            // 
            // txtKQmoi
            // 
            this.txtKQmoi.Location = new System.Drawing.Point(483, 239);
            this.txtKQmoi.Name = "txtKQmoi";
            this.txtKQmoi.Size = new System.Drawing.Size(100, 20);
            this.txtKQmoi.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtKQmoi);
            this.Controls.Add(this.lblKQmoi);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.btnDT);
            this.Controls.Add(this.btnCV);
            this.Controls.Add(this.txtBK);
            this.Controls.Add(this.lblBK);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBK;
        private System.Windows.Forms.TextBox txtBK;
        private System.Windows.Forms.Button btnCV;
        private System.Windows.Forms.Button btnDT;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDT;
        private System.Windows.Forms.RadioButton rdbCV;
        private System.Windows.Forms.Label lblKQmoi;
        private System.Windows.Forms.TextBox txtKQmoi;
    }
}

