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

namespace Projectbat
{
    public partial class FrmInformationMark : Form
    {
        private string code;
        private FrmMarkList frm;
        public FrmInformationMark(FrmMarkList fMarkList,string StCode)
        {
            this.frm = fMarkList;
            code = StCode;
            InitializeComponent();
        }

        private void FrmInformationMark_Load(object sender, EventArgs e)
        {
            string curDic = Directory.GetCurrentDirectory();
            curDic = curDic.Substring(0, curDic.Length - 9);
            int countTC = 0;
            using (StreamReader sr = new StreamReader(curDic + "../Project/listStudentNotFullMark/lsStudentNotFullMark.txt"))
            {
                /*vi du
                 * he130139.txt
                   he141175.txt
                   he141523.txt
                 */
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    if (str.Trim().Length==0)
                    {
                        continue;
                    }
                    if (str.ToLower().Contains(code))
                    {
                        using (StreamReader srr = new StreamReader(curDic + "../Project/listStudentNotFullMark/" + str))
                        {

                            bool gotCode = false;
                            bool gotName = false;
                            bool gotExam = false;
                            bool gotLsQ_TC = false;
                            while ((str = srr.ReadLine()) != null)
                            {
                                
                                if (gotCode)
                                {
                                    txtCodeStudent.Text = str;
                                    gotCode = false;
                                }
                                if (gotName)
                                {
                                    txtName.Text = str;
                                    gotName = false;
                                }
                                if (gotExam)
                                {
                                    txtExamCode.Text = str;
                                    gotExam = false;
                                }
                                if (gotLsQ_TC)
                                {
                                    rtxtTestCase.Text += "\n"+str;
                                    countTC += 1;
                                }
                                if (str.Equals("Code"))
                                {
                                    gotCode = true;
                                }
                                if (str.Equals("Name"))
                                {
                                    gotName = true;
                                }
                                if (str.Equals("Exam"))
                                {
                                    gotExam = true;
                                }
                                if (str.Equals("lsQ_TC"))
                                {
                                    gotLsQ_TC = true;
                                }
                            }
                        }
                        txtTestCaseError.Text = countTC.ToString();
                        return;
                    }
                }
            }
        }

        private void txtReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }
    }
}
