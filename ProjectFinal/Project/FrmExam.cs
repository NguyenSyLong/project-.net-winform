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
using Projectbat;

namespace Project
{
    public partial class FrmExam : Form
    {
        public FrmExam()
        {
            InitializeComponent();
        }
        List<Exam> list = new List<Exam>();
        public void CreateFolder(string folderName)
        {

            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            flpExam.Controls.Clear();
            if (!isNum(txtQuantity.Text,1,int.MaxValue))
            {
                return;
            }
            int number = int.Parse(txtQuantity.Text);
            
            for (int i = 0; i < number; i++)
            {
                Button bt = new Button();
                bt.Text = "Exam " + (i + 1);
                bt.Name = "Exam" + (i + 1);
                bt.Size = new Size(100, 30);
                flpExam.Controls.Add(bt);
                bt.Click += Bt_Click; ;
                list.Add(new Exam(bt.Name));
                CreateFolder("../../" + bt.Name);
            }
            string curDic = Directory.GetCurrentDirectory();
            curDic = curDic.Substring(0, curDic.Length - 9);
            using (StreamWriter sw = new StreamWriter(curDic + "listPathOfTestCase.txt"))
            {
                sw.WriteLine("");
            }
            using (StreamWriter sw = new StreamWriter(curDic + "../Projectbat/allBatLocation.txt"))
            {
                sw.WriteLine("");
            }
        }

        private bool isNum(string text,int min, int max)
        {
            int number;
            try
            {
                number = int.Parse(text);
                if (number<min||number>max)
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
           
            foreach (var item in list)
            {
                if (item.Code.Equals(((Button)sender).Name))
                {
                    FrmQuestion fr = new FrmQuestion(this, ((Button)sender).Name);
                    fr.Show();
                    fr.label2.Text = ((Button)sender).Name;
                    this.Hide();
                }
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Alert","Finish fill testCase for exam?",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                FrmMark f1 = new FrmMark();
                this.Hide();
                f1.Show();
            }

        }

        private void flpExam_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
