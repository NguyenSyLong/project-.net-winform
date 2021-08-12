
namespace Project
{
    partial class FrmQuestion
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flpQuestion = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.flpMark = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số câu hỏi muốn test: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(605, 78);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 33);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(260, 86);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(321, 22);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Màn hình tạo câu hỏi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // flpQuestion
            // 
            this.flpQuestion.AutoScroll = true;
            this.flpQuestion.Location = new System.Drawing.Point(37, 219);
            this.flpQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpQuestion.Name = "flpQuestion";
            this.flpQuestion.Size = new System.Drawing.Size(643, 371);
            this.flpQuestion.TabIndex = 4;
            this.flpQuestion.Paint += new System.Windows.Forms.PaintEventHandler(this.flpQuestion_Paint);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(605, 598);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(95, 43);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "Xong";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // flpMark
            // 
            this.flpMark.AutoScroll = true;
            this.flpMark.Location = new System.Drawing.Point(37, 138);
            this.flpMark.Name = "flpMark";
            this.flpMark.Size = new System.Drawing.Size(643, 54);
            this.flpMark.TabIndex = 6;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(338, 598);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(105, 43);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Xem";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // FrmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 668);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.flpMark);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.flpQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmQuestion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.FlowLayoutPanel flpQuestion;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.FlowLayoutPanel flpMark;
        private System.Windows.Forms.Button btnShow;
    }
}

