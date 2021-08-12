
namespace Projectbat
{
    partial class FrmMark
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnMark = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMarkStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đường dẫn Folder chứa bài làm";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(67, 120);
            this.txtPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(462, 20);
            this.txtPath.TabIndex = 2;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(334, 163);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(88, 26);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Chấm Điểm";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnMark
            // 
            this.btnMark.Location = new System.Drawing.Point(189, 163);
            this.btnMark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(98, 26);
            this.btnMark.TabIndex = 9;
            this.btnMark.Text = "Xem Điểm";
            this.btnMark.UseVisualStyleBackColor = true;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(174, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tự Động Chấm";
            // 
            // lblMarkStatus
            // 
            this.lblMarkStatus.AutoSize = true;
            this.lblMarkStatus.Location = new System.Drawing.Point(465, 163);
            this.lblMarkStatus.Name = "lblMarkStatus";
            this.lblMarkStatus.Size = new System.Drawing.Size(0, 13);
            this.lblMarkStatus.TabIndex = 11;
            // 
            // FrmMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 221);
            this.Controls.Add(this.lblMarkStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMark";
            this.Text = "AUTO MARK PE PRO192";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMarkStatus;
    }
}

