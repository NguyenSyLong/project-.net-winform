
namespace Projectbat
{
    partial class FrmMarkList
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
            this.gvMark = new System.Windows.Forms.DataGridView();
            this.CodeStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaperNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvMark)).BeginInit();
            this.SuspendLayout();
            // 
            // gvMark
            // 
            this.gvMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMark.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeStudent,
            this.NameStudent,
            this.PaperNo,
            this.MarkStudent});
            this.gvMark.Location = new System.Drawing.Point(31, 51);
            this.gvMark.Name = "gvMark";
            this.gvMark.RowHeadersWidth = 51;
            this.gvMark.Size = new System.Drawing.Size(557, 253);
            this.gvMark.TabIndex = 1;
            this.gvMark.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMark_CellClick);
            // 
            // CodeStudent
            // 
            this.CodeStudent.HeaderText = "Code Student";
            this.CodeStudent.MinimumWidth = 6;
            this.CodeStudent.Name = "CodeStudent";
            this.CodeStudent.ReadOnly = true;
            this.CodeStudent.Width = 125;
            // 
            // NameStudent
            // 
            this.NameStudent.HeaderText = "Name Student";
            this.NameStudent.MinimumWidth = 6;
            this.NameStudent.Name = "NameStudent";
            this.NameStudent.ReadOnly = true;
            this.NameStudent.Width = 125;
            // 
            // PaperNo
            // 
            this.PaperNo.HeaderText = "Paper No";
            this.PaperNo.MinimumWidth = 6;
            this.PaperNo.Name = "PaperNo";
            this.PaperNo.ReadOnly = true;
            this.PaperNo.Width = 125;
            // 
            // MarkStudent
            // 
            this.MarkStudent.HeaderText = "Mark Student";
            this.MarkStudent.MinimumWidth = 6;
            this.MarkStudent.Name = "MarkStudent";
            this.MarkStudent.ReadOnly = true;
            this.MarkStudent.Width = 125;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(513, 331);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(31, 11);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(109, 19);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter Code Student";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(161, 11);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(427, 20);
            this.txtCode.TabIndex = 5;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // FrmMarkList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 377);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gvMark);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMarkList";
            this.Text = "Mark";
            this.Load += new System.EventHandler(this.Mark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvMark;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaperNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkStudent;
    }
}