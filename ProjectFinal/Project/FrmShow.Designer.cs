
namespace Project
{
    partial class FrmShow
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
            this.flpTestcaseInput = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // flpTestcaseInput
            // 
            this.flpTestcaseInput.AutoScroll = true;
            this.flpTestcaseInput.Location = new System.Drawing.Point(103, 78);
            this.flpTestcaseInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpTestcaseInput.Name = "flpTestcaseInput";
            this.flpTestcaseInput.Size = new System.Drawing.Size(615, 51);
            this.flpTestcaseInput.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(103, 165);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(620, 345);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // FrmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 547);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.flpTestcaseInput);
            this.Name = "FrmShow";
            this.Text = "FrmShow";
            this.Load += new System.EventHandler(this.FrmShow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTestcaseInput;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}