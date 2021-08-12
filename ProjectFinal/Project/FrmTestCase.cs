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
    public partial class FrmTestCase : Form
    {
        private List<Testcase> lTC = new List<Testcase>();
        FrmQuestion f;
        string ExamName;
        double Mark;
        public FrmTestCase(FrmQuestion form1, string examName, double mark)
        {
            this.ExamName = examName;
            this.f = form1;
            this.Mark = mark;
            InitializeComponent();
        }
        public string file;
        public List<string> lst = new List<string>();
        string CurrentDirectory = Directory.GetCurrentDirectory();
        List<double> markcheck = new List<double>();
        private void FrmTestCase_Load(object sender, EventArgs e)
        {
            int count = CurrentDirectory.ToString().Length - 9;
            CurrentDirectory = CurrentDirectory.Substring(0, count);
            
            
            lblMarkQ.Text = "Mark: "+Mark.ToString();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            flpTestcaseInput.Controls.Clear();
            if (!IsInt(txtQuantityTestCase.Text, 1, int.MaxValue))
            {
                return;
            }
            int number = int.Parse(txtQuantityTestCase.Text);

            for (int i = 0; i < number; i++)
            {
                Label lb = new Label();
                lb.Text = "Label " + (i + 1);
                Button bt = new Button();
                bt.Text = "TC " + (i + 1);
                bt.Name = "TestCase" + (i + 1);
                bt.Size = new Size(100, 30);
                flpTestcaseInput.Controls.Add(bt);
                bt.Click += Bt_Click;
                
                lTC.Add(new Testcase(bt.Name, "", "", 0, false, false));
            }
            btnAdd.Click += BtnAdd_Click;
        }

        private bool IsInt(string text, int min, int max)
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
        private bool IsDouble(string text, double min, double max)
        {
            double number;
            try
            {
                number = double.Parse(text);
                if (number <= min || number > max)
                {
                    MessageBox.Show("Điền số lớn hơn 0", "Alert", MessageBoxButtons.OK);
                    return false;
                }
                if (number > Mark)
                {
                    MessageBox.Show("điểm test case không thể lớn hơn " + Mark, "Alert", MessageBoxButtons.OK);
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Điền số lớn hơn 0", "Alert", MessageBoxButtons.OK);
                return false;
            }
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            
            foreach (var item in lTC)
            {
                if (item.Code.Equals(((Button)sender).Name))
                {
                    rtxtInput.Text = item.Input;
                    rtxtOutput.Text = item.Output;
                    txtMark.Text = item.Mark.ToString();
                    cbxCase_Sen.Checked = item.CaseSensitive;
                    cbxR_Space.Checked = item.RemoveSpace;
                }
            }

            btnAdd.Name = ((Button)sender).Name;
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
           
                    if (MessageBox.Show("Lưu lại?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (var item in lTC)
                {
                    if (item.Code.Equals(((Button)sender).Name))
                    {
                        if (!IsDouble(txtMark.Text, 0, double.MaxValue))
                        {
                            MessageBox.Show("Lưu Thất Bại!!!", "Alert", MessageBoxButtons.OK);
                            return;
                        }
                        if (rtxtInput.Text == "")
                        {
                            MessageBox.Show("Input trống!!!", "Alert", MessageBoxButtons.OK);
                            return;
                        }
                        if (rtxtOutput.Text == "")
                        {
                            MessageBox.Show("Output trôngs!!!", "Alert", MessageBoxButtons.OK);
                            return;
                        }
                        markcheck.Add(double.Parse(txtMark.Text));
                        double markc = 0;
                       
                       
                        item.Input = rtxtInput.Text;
                        item.Output = rtxtOutput.Text;
                        item.Mark = double.Parse(txtMark.Text); 
                        item.RemoveSpace = cbxR_Space.Checked;
                        item.CaseSensitive = cbxCase_Sen.Checked;
                        foreach (var t in lTC)
                        {

                            markc += t.Mark;
                        }
                        if (markc > Mark)
                        {
                            MessageBox.Show("Tong lon hon "+ Mark+"!!!", "Alert", MessageBoxButtons.OK);
                            item.Mark = 0;
                            return;
                        }
                       
                    }
                }
               
                
                MessageBox.Show("Lưu Thành Công!!!", "Alert", MessageBoxButtons.OK);
            }
            
        }


        public void readFile(string filename)
        {
            try
            {

                using (StreamReader sr = new StreamReader(filename))
                {
                    string str;
                    while ((str = sr.ReadLine()) != null)
                    {

                        Console.WriteLine(str);
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Read file Error");
                Console.WriteLine(e.Message);

            }
        }
        public void CreateFolder(string folderName)
        {

            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
        }
        public List<string> readFile1(string filename)
        {
            List<string> list = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    string str;
                    while ((str = sr.ReadLine()) != null)
                    {
                        list.Add(str);

                        Console.WriteLine(str);
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Read file Error");
                Console.WriteLine(e.Message);

            }
            return list;
        }
        private void btnFinish_Click(object sender, EventArgs e)
        {
            double MarkT = 0;
            foreach (var item in lTC)
            {
                if (item.Mark == 0)
                {
                    MessageBox.Show(item.Code+" have mark = 0 !!!!", "Alert", MessageBoxButtons.OK);
                    return;
                }
            }
            foreach (var item in lTC)
            {
                MarkT += item.Mark;
            }
            if (MarkT != Mark)
            {
                MessageBox.Show("Tổng điểm testcase phải = "+Mark+" !!!", "Alert", MessageBoxButtons.OK);
                return;
            }
            foreach (var item in lTC)
            {
                try
                {
                    lst.Add(ExamName + "/" + label1.Text + "/" + item.Code.ToString() + ".txt");
                    using (StreamWriter sw = new StreamWriter(CurrentDirectory+ ExamName + "/" + label1.Text + "/" + item.Code.ToString() + ".txt"))
                    {
                        sw.WriteLine(item.Code);
                        sw.WriteLine("INPUT:");
                        sw.WriteLine(item.Input);
                        sw.WriteLine("OUTPUT:");
                        sw.WriteLine(item.Output);
                        sw.WriteLine("REMOVE_SPACES:");
                        if (item.RemoveSpace == true)
                        {
                            sw.WriteLine("YES");
                        }
                        else
                        {
                            sw.WriteLine("NO");
                        }
                        sw.WriteLine("CASE_SENSITIVE:");
                        if (item.CaseSensitive == true)
                        {
                            sw.WriteLine("YES");
                        }
                        else
                        {
                            sw.WriteLine("NO");
                        }
                        sw.WriteLine("Mark:");
                        sw.WriteLine(item.Mark.ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("write file Error");
                    Console.WriteLine(ex.Message);
                }

            }
            this.Close();
            f.Show();
            using (StreamWriter sw = File.AppendText(CurrentDirectory + "/listPathOfTestCase.txt"))
            {
                foreach (var item in lst)
                {
                    sw.WriteLine(item.ToString());
                }
            }
            
        }

      
    }
}
