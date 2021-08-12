using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectbat
{
    public partial class FrmMarkList : Form
    {
        FrmMark fMark;
        public FrmMarkList(FrmMark f)
        {
            this.fMark = f;
            InitializeComponent();
        }

      
       
        List<StudentMark> listST = new List<StudentMark>();
        private void Mark_Load(object sender, EventArgs e)
        {
            string curDic = Directory.GetCurrentDirectory();
            curDic = curDic.Substring(0, curDic.Length - 9);
            using (StreamReader sr = new StreamReader(curDic + "../Project/Mark.txt"))
            {
                string str = "";
                int count = 0;
                while ((str = sr.ReadLine()) != null)
                {
                    if (str.Length == 0)
                    {
                        continue;
                    }
                    count++;
                }
            }
            string[] result;
            using (StreamReader sr = new StreamReader(curDic + "../Project/Mark.txt"))
            {
                string str = "";
                int count = 0;
                while ((str = sr.ReadLine()) != null)
                {
                    if (str.Length == 0)
                    {
                        continue;
                    }
                    string pattern = @"\s+";
                    result = Regex.Split(str, pattern,
                                          RegexOptions.IgnoreCase);
                    gvMark.Rows.Add(result[0], result[1], result[2], result[3]);
                    List<Question> list = new List<Question>();

                    listST.Add(new StudentMark(result[0],result[1],result[2],list,double.Parse(result[3])));
                    count++;
                }
            }
        }
        public void mark()
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Alert","Do you want to exit",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            gvMark.Rows.Clear();
            bool filter = false;
            foreach (var item in listST)
            {
                if (item.Code.ToLower().Contains(txtCode.Text.ToLower()))
                {
                    gvMark.Rows.Add(item.Code,item.Name,item.Exam,item.Mark);
                    filter = true;
                }
            }
            if (filter == false)
            {
                MessageBox.Show("mã sinh viên không tồn tại", "Alert", MessageBoxButtons.OK);
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void gvMark_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // truyen thong tin cham diem cua sinh vien sang ben formInfo
            FrmInformationMark fInfo = new FrmInformationMark(this,gvMark.Rows[e.RowIndex].Cells["CodeStudent"].FormattedValue.ToString());
            this.Hide();
            fInfo.Show();
        }
    }
}
