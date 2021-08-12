
namespace Project
{
    partial class FrmTestCase
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
            this.txtQuantityTestCase = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.flpTestcaseInput = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rtxtInput = new System.Windows.Forms.RichTextBox();
            this.rtxtOutput = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.cbxR_Space = new System.Windows.Forms.CheckBox();
            this.cbxCase_Sen = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMarkQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(377, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test case";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số lượng test case trong câu hỏi hiện tại";
            // 
            // txtQuantityTestCase
            // 
            this.txtQuantityTestCase.Location = new System.Drawing.Point(509, 94);
            this.txtQuantityTestCase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantityTestCase.Name = "txtQuantityTestCase";
            this.txtQuantityTestCase.Size = new System.Drawing.Size(215, 22);
            this.txtQuantityTestCase.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(776, 94);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(115, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "CreateTest";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // flpTestcaseInput
            // 
            this.flpTestcaseInput.AutoScroll = true;
            this.flpTestcaseInput.Location = new System.Drawing.Point(59, 122);
            this.flpTestcaseInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpTestcaseInput.Name = "flpTestcaseInput";
            this.flpTestcaseInput.Size = new System.Drawing.Size(832, 50);
            this.flpTestcaseInput.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(397, 604);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 50);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // rtxtInput
            // 
            this.rtxtInput.Location = new System.Drawing.Point(59, 194);
            this.rtxtInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtInput.Name = "rtxtInput";
            this.rtxtInput.Size = new System.Drawing.Size(327, 386);
            this.rtxtInput.TabIndex = 11;
            this.rtxtInput.Text = "";
            // 
            // rtxtOutput
            // 
            this.rtxtOutput.Location = new System.Drawing.Point(563, 194);
            this.rtxtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtOutput.Name = "rtxtOutput";
            this.rtxtOutput.Size = new System.Drawing.Size(327, 386);
            this.rtxtOutput.TabIndex = 12;
            this.rtxtOutput.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Input";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(559, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Output";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(796, 604);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(151, 50);
            this.btnFinish.TabIndex = 15;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(412, 382);
            this.txtMark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(119, 22);
            this.txtMark.TabIndex = 16;
            // 
            // cbxR_Space
            // 
            this.cbxR_Space.AutoSize = true;
            this.cbxR_Space.Location = new System.Drawing.Point(391, 265);
            this.cbxR_Space.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxR_Space.Name = "cbxR_Space";
            this.cbxR_Space.Size = new System.Drawing.Size(142, 21);
            this.cbxR_Space.TabIndex = 17;
            this.cbxR_Space.Text = "REMOVE_SPACE";
            this.cbxR_Space.UseVisualStyleBackColor = true;
            // 
            // cbxCase_Sen
            // 
            this.cbxCase_Sen.AutoSize = true;
            this.cbxCase_Sen.Location = new System.Drawing.Point(391, 308);
            this.cbxCase_Sen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCase_Sen.Name = "cbxCase_Sen";
            this.cbxCase_Sen.Size = new System.Drawing.Size(144, 21);
            this.cbxCase_Sen.TabIndex = 18;
            this.cbxCase_Sen.Text = "CASE_SENSITIVE";
            this.cbxCase_Sen.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Mark:";
            // 
            // lblMarkQ
            // 
            this.lblMarkQ.Location = new System.Drawing.Point(796, 33);
            this.lblMarkQ.Name = "lblMarkQ";
            this.lblMarkQ.Size = new System.Drawing.Size(78, 36);
            this.lblMarkQ.TabIndex = 22;
            this.lblMarkQ.Text = "label3";
            // 
            // FrmTestCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 667);
            this.Controls.Add(this.lblMarkQ);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxCase_Sen);
            this.Controls.Add(this.cbxR_Space);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtxtOutput);
            this.Controls.Add(this.rtxtInput);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.flpTestcaseInput);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtQuantityTestCase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTestCase";
            this.Text = "FrmTestCase";
            this.Load += new System.EventHandler(this.FrmTestCase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantityTestCase;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.FlowLayoutPanel flpTestcaseInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox rtxtInput;
        private System.Windows.Forms.RichTextBox rtxtOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox txtMark;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxR_Space;
        private System.Windows.Forms.CheckBox cbxCase_Sen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMarkQ;
    }
}