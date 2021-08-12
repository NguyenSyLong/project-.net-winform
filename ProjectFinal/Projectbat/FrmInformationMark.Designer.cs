
namespace Projectbat
{
    partial class FrmInformationMark
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
            this.txtCodeStudent = new System.Windows.Forms.TextBox();
            this.txtExamCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTestCaseError = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxtTestCase = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Bài Chấm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đề:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Sinh Viên:";
            // 
            // txtCodeStudent
            // 
            this.txtCodeStudent.Location = new System.Drawing.Point(200, 117);
            this.txtCodeStudent.Name = "txtCodeStudent";
            this.txtCodeStudent.Size = new System.Drawing.Size(164, 20);
            this.txtCodeStudent.TabIndex = 3;
            // 
            // txtExamCode
            // 
            this.txtExamCode.Location = new System.Drawing.Point(200, 142);
            this.txtExamCode.Name = "txtExamCode";
            this.txtExamCode.Size = new System.Drawing.Size(164, 20);
            this.txtExamCode.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số TestCase sai:";
            // 
            // txtTestCaseError
            // 
            this.txtTestCaseError.Location = new System.Drawing.Point(200, 181);
            this.txtTestCaseError.Name = "txtTestCaseError";
            this.txtTestCaseError.Size = new System.Drawing.Size(164, 20);
            this.txtTestCaseError.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "TestCase sai:";
            // 
            // rtxtTestCase
            // 
            this.rtxtTestCase.Location = new System.Drawing.Point(200, 229);
            this.rtxtTestCase.Name = "rtxtTestCase";
            this.rtxtTestCase.Size = new System.Drawing.Size(164, 107);
            this.rtxtTestCase.TabIndex = 10;
            this.rtxtTestCase.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(200, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 20);
            this.txtName.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tên Sinh Viên:";
            // 
            // txtReturn
            // 
            this.txtReturn.Location = new System.Drawing.Point(45, 369);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.Size = new System.Drawing.Size(75, 23);
            this.txtReturn.TabIndex = 13;
            this.txtReturn.Text = "Quay Lai";
            this.txtReturn.UseVisualStyleBackColor = true;
            this.txtReturn.Click += new System.EventHandler(this.txtReturn_Click);
            // 
            // FrmInformationMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 404);
            this.Controls.Add(this.txtReturn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtxtTestCase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTestCaseError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtExamCode);
            this.Controls.Add(this.txtCodeStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmInformationMark";
            this.Text = "FrmInformationMark";
            this.Load += new System.EventHandler(this.FrmInformationMark_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodeStudent;
        private System.Windows.Forms.TextBox txtExamCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTestCaseError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxtTestCase;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button txtReturn;
    }
}