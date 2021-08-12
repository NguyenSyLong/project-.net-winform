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
    public partial class FrmShow : Form
    {
        public FrmShow()
        {
            InitializeComponent();
        }
        string CurrentDirectory = Directory.GetCurrentDirectory();
        List<Question> lq = new List<Question>();
        private void FrmShow_Load(object sender, EventArgs e)
        {
            int count = CurrentDirectory.ToString().Length - 9;
            CurrentDirectory = CurrentDirectory.Substring(0, count);
            int count1 = 0;
            
            using (StreamReader sr = new StreamReader(CurrentDirectory + "/listPathOfTestCase.txt"))
            {
                string batLocation;
                while ((batLocation = sr.ReadLine()) != null)
                {
                    if (batLocation.Trim().Length == 0)
                    {
                        continue;
                    }
                    string[] s1 = batLocation.Split('/');
                    string tc = s1[2].Split('.')[0];
                    lq.Add(new Question(s1[1],tc,""));
                    count1++;
                    Button bt = new Button();
                    bt.Text = s1[1] + "-" + tc;
                    bt.Name = s1[1] + "-" + tc;
                    bt.Size = new Size(100, 30);
                    flpTestcaseInput.Controls.Add(bt);
                    bt.Click += Bt_Click;
                }
            }
           
                
            
            string s = "";
            foreach (var item in lq)
            {
                s += item.TC_code;
            }
             
           
        }
        public List<string> readFile(string filename)
        {
            List<string> list = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    string str;
                    while ((str = sr.ReadLine()) != null)
                    {
                        if (str.Trim().Length == 0)
                        {
                            continue;
                        }
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
        private void Bt_Click(object sender, EventArgs e)
        {
            List<string> list = readFile(CurrentDirectory + "/listPathOfTestCase.txt");
            string c = "";
            foreach (var item in list)
            {
                string[] s1 = item.Split('/');
                string tc = s1[2].Split('.')[0];
                string q = s1[1];
                string bt = s1[1] + "-" + tc;
                
                string path = CurrentDirectory + "/" + item.ToString();
                if (bt.Equals(((Button)sender).Name))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string batLocation;
                        while ((batLocation = sr.ReadLine()) != null)
                        {
                            if (batLocation.Trim().Length == 0)
                            {
                                continue;
                            }
                            c += batLocation + "\n";

                        }
                    }
                }
                
                
            }
            richTextBox1.Text = c;

        }
    }
}
