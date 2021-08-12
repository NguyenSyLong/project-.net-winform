using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FrmQuestion : Form
    {
        FrmExam frm;
        string ExamName;
        public FrmQuestion(FrmExam frmExam, string name)
        {
            this.ExamName = name;
            this.frm = frmExam;
            InitializeComponent();
        }
        List<Question> list = new List<Question>();
        List<TextBox> listT = new List<TextBox>();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void CreateFolder(string folderName)
        {

            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            foreach (var item in list)
            {
                list.Remove(item);
            }
            flpQuestion.Controls.Clear();
            flpMark.Controls.Clear();

            if (!isNum(txtQuantity.Text, 1, int.MaxValue))
            {
                return;
            }
            int number = int.Parse(txtQuantity.Text);
            for (int i = 0; i < number; i++)
            {
                Button bt = new Button();
                bt.Text = "Question " + (i + 1);
                bt.Name = "Q" + (i + 1);
                bt.Size = new Size(100, 30);
                flpQuestion.Controls.Add(bt);
                bt.Click += Bt_Click;
                list.Add(new Question(bt.Name, 0));
                Label lb = new Label();
                lb.Text = "Q" + (i + 1) + ":";
                lb.Size = new Size(40, 30);
                TextBox tb = new TextBox();
                tb.Name = "Q" + (i + 1);
                tb.Size = new Size(20, 20);
                listT.Add(tb);
                flpMark.Controls.Add(lb);
                flpMark.Controls.Add(tb);
                CreateFolder("../../"+ExamName+ "/"+bt.Name);
            }
            
        }

        private bool isNum(string text, int min, int max)
        {
            int number;
            try
            {
                number = int.Parse(text);
                if (number < min || number > max)
                {
                    MessageBox.Show("Điền số tự nhiên lơn hơn 0", "Alert", MessageBoxButtons.OK);
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Điền số tự nhiên lơn hơn 0", "Alert", MessageBoxButtons.OK);
                return false;
            }
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            double Mark = 0;
            foreach (var item in listT)
            {
                try
                {
                    double mark = double.Parse(item.Text);
                    Mark += mark;
                }
                catch (Exception)
                {
                    MessageBox.Show("Re-Enter Input!!!", "Alert", MessageBoxButtons.OK);
                    return;

                }
                
            }
            if (Mark != 10)
            {
                MessageBox.Show("Sum mark Input must be 10!!!", "Alert", MessageBoxButtons.OK);
                return;
            }
            foreach (var item in listT)
            {
                
                if (item.Name.Equals(((Button)sender).Name))
                {
                    
                    
                        double mark = double.Parse(item.Text);
                        if (mark >= 0 && mark <= 10)
                        {
                            foreach (var t in list)
                            {
                                if (t.Code.Equals(((Button)sender).Name))
                                {
                                    t.Mark = mark;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Re-Enter Input!!!", "Alert", MessageBoxButtons.OK);
                            return;
                        }
                    
                        
                    
   
                }
            }
            foreach (var item in list)
            {
                if (item.Code.Equals(((Button)sender).Name))
                {
                    FrmTestCase fr = new FrmTestCase(this,ExamName,item.Mark);
                    fr.Show();
                    fr.label1.Text = ((Button)sender).Name;
                    this.Hide();
                }
            }

            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void flpQuestion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FrmShow f = new FrmShow();
            f.Show();
        }
    }
}
