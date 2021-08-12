using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectbat
{
    public partial class FrmMark : Form
    {
        public FrmMark()
        {
            InitializeComponent();
        }
        public void runBat(string pathname)
        {
            /*
            using (StreamWriter sw = File.AppendText(pathname))
            {
                sw.WriteLine("exit");
            }*/
            Process test = new Process();
            try
            {
                test.StartInfo.FileName = pathname;
                test.StartInfo.RedirectStandardError = true;
                test.StartInfo.RedirectStandardOutput = true;
                test.StartInfo.UseShellExecute = false;
                //hide command prompt window
                test.StartInfo.CreateNoWindow = true;
                test.Start();
                test.WaitForExit(10000);
                //Thêm dòng if này vì bị treo cmd.exe khi mà đã chạy hết dòng lệnh cmd trong batfile(Note: Sửa cách chạy, Hết lỗi rồi :))
                //chờ 3 giây rồi buộc tắt cmd.exe
                /*
                if (!test.WaitForExit(5000))
                {
                    test.Kill();
                }
                */
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            //MessageBox.Show("Done");
        }
        List<StudentMark> listST = new List<StudentMark>();
        
       
        private void btnRun_Click(object sender, EventArgs e)
        {
            lblMarkStatus.Text = "đang chấm bài";
            try
            {
                string p = txtPath.Text;
                string[] ps = Directory.GetDirectories(@p, "*", SearchOption.TopDirectoryOnly);//Change path to yours
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK);
                return;
            }
            List<string> lsOutputOfStudent = new List<string>();
            string pathOfListTestCase = Directory.GetCurrentDirectory();
            pathOfListTestCase = pathOfListTestCase.Substring(0,pathOfListTestCase.Length-9);
            string allBatLocation = pathOfListTestCase;
            List<String> allBatCommand = new List<string>();
            //xoa file allBatLocation.txt
            using (StreamWriter sw = new StreamWriter(allBatLocation + "allBatLocation.txt"))
            {
                sw.WriteLine("");
            }
            //path bài làm của sinh viên
            string pathLotsOfExStudents = txtPath.Text;
            string pathOfATestCase = "";
            //get all folder ex of student
            string[] allFiles = Directory.GetDirectories(@pathLotsOfExStudents, "*", SearchOption.TopDirectoryOnly);//Change path to yours
            //duyệt qua tất cả folder bài sinh viên
            for (int i = 0; i < allFiles.Length; i++)
            {
                //lấy mã đề của 1 sinh viên
                int len = allFiles[i].Length;
                int examCode = 0;
                string code ;
                string name ;
                string exam ;
                try
                {
                    //examCode = Int32.Parse(allFiles[i].Substring(len - 2, 2));
                    string[] made = allFiles[i].Split('_');
                    code = made[made.Length - 3];
                    string[] code1 = code.Split('\\');
                    code = code1[code1.Length - 1];
                    name = made[made.Length - 2];
                    exam = made[made.Length - 1];
                    examCode = Int32.Parse(made[made.Length - 1]);
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Alert","Wrong format for examCode",MessageBoxButtons.OK);
                    return;
                }
                List<Question> listQuestions = new List<Question>();
                listST.Add(new StudentMark(code, name, exam, listQuestions,0));
                //allFiles[i] += "/1/run/";
                //danh sach tat ca cac path cua testCase 
                /*
                 *  Exam1/Q1/TestCase1.txt
                    Exam1/Q1/TestCase2.txt
                    Exam1/Q2/TestCase1.txt
                 */
                using (StreamReader sr = new StreamReader(pathOfListTestCase + "../Project/listPathOfTestCase.txt"))
                {
                    //path cua 1 testCase trong 1 câu hỏi của 1 đề bài
                    while ((pathOfATestCase = sr.ReadLine()) != null)
                    {
                        // path = fixedPath(path);
                        //string command = "(echo 1& echo 2& echo awegaw) | java -jar " +path ;
                        //int number = int.Parse(txtTest.Text);
                        if (pathOfATestCase.Trim().Length == 0)
                        {
                            continue;
                        }
                       
                        //lấy những địa chỉ testCase có examCode bằng examCode của bài sinh viên
                        if (pathOfATestCase.Contains("Exam"+examCode))
                        {
                            //pathOfATestCase = pathOfListTestCase + pathOfATestCase;
                            List<string> list = readFile(pathOfListTestCase + "../Project/" + pathOfATestCase);
                            bool gotInput = false;
                            bool gotCase = true;
                            bool gotRM = true;
                            bool gotCS = true;
                            bool Mark = true;
                            int count = 0;
                            string command = "";
                            string outputTC = "";
                            string rm = "";
                            string cs = "";
                            foreach (var item in list)
                            {
                                if (item.ToString().Equals("OUTPUT:"))
                                {
                                    gotInput = false;
                                }
                                if (gotInput)
                                {
                                    if (count == 0)
                                    {
                                        command += "(echo " + item.ToString();
                                        count++;
                                    }
                                    else
                                    {
                                        command += "& echo " + item.ToString();

                                    }
                                }
                                if (item.ToString().Equals("INPUT:"))
                                {
                                    gotInput = true;
                                }
                                if (item.ToString().Equals("REMOVE_SPACES:"))
                                {
                                    gotCase = false;
                                }
                                if (gotInput == false && gotCase==true)
                                {
                                    if (!item.ToString().Equals("OUTPUT:")&&!item.ToString().Equals(list[0]))
                                    {
                                        outputTC += item.ToString() + "\n";
                                    }
                                    
                                }
                                if (gotCase == false)
                                {
                                    if (item.ToString().Equals("CASE_SENSITIVE:"))
                                    {
                                        gotRM = false;
                                    }
                                }
                                if (gotCase == false && gotRM == true)
                                {
                                    if (!item.ToString().Equals("REMOVE_SPACES:"))
                                    {
                                       rm = item.ToString();
                                    }
                                }
                                if (item.ToString().Equals("Mark:"))
                                {
                                    Mark = false;
                                }
                                if (gotRM == false&&Mark==true)
                                {
                                    if (!item.ToString().Equals("CASE_SENSITIVE:"))
                                    {
                                        cs = item.ToString();
                                    }
                                }
                            }
                          
                            foreach (var item in listST)
                            {
                                if (code == item.Code)
                                {
                                    List<TestCase> listTestCases = new List<TestCase>();
                                    listTestCases.Add(new TestCase(list[0], outputTC, "", double.Parse(list[list.Count - 1]),rm,cs));
                                    item.LQuestions.Add(new Question(pathOfATestCase.Substring(7, 1), listTestCases));
                                }
                            }
                            string JarOfQues = "/" + pathOfATestCase.Substring(7, 1) + "/run/Q" + pathOfATestCase.Substring(7, 1) + ".jar";
                            string output = "/" + pathOfATestCase.Substring(7, 1) + "/run/"  + list[0].ToString() + ".txt";
                            string pathJarOfStudent = allFiles[i]+ JarOfQues;
                            string pathOutputTxtOfStudent = allFiles[i] + output;
                            //path ở vị trí file bài làm của sinh viên
                            command += " ) | java -jar " + pathJarOfStudent + ">" + pathOutputTxtOfStudent;
                            //lưu tất cả các path của output sau khi chạy bài sinh viên
                            lsOutputOfStudent.Add(pathOutputTxtOfStudent);
                            //lưu command vào 1 danh sách rồi in vào 1 file bat
                            //allBatCommand.Add(command);
                            //tạo file bat tại địa chỉ allFiles[i]+"/" + pathOfATestCase.Substring(7, 1) + "/run/
                            string batLocation = allFiles[i] + "/" + pathOfATestCase.Substring(7, 1) + "/run/";
                            //viet command vao file bat
                            writeFileTest(list[0].ToString(), batLocation, command);
                        }
                    }
                }
            }
            // luu tat ca lenh bat vao dia chi allBatLocation+ allBatLocation.bat
            //writeFile("allBatCommand", allBatLocation, allBatCommand);
            //lưu tất cả các path của output sau khi chạy bài sinh viên vào text
            using (StreamWriter sw = new StreamWriter(pathOfListTestCase + "../Project/listPathOutputTxtOfStudent.txt"))
            {
                foreach (var item in lsOutputOfStudent)
                {
                    sw.WriteLine(item.ToString());
                }
            }
            
            
            
            
            //run all bat file
            //allBatLocation = Directory.GetCurrentDirectory();
            //allBatLocation = allBatLocation.Substring(0, allBatLocation.Length - 9) + "allBatLocation.txt";
            allBatLocation += "allBatLocation.txt";
            using (StreamReader sr = new StreamReader(allBatLocation))
            {
                string batLocation;
                while ((batLocation = sr.ReadLine()) != null)
                {
                    if (batLocation.Trim().Length == 0)
                    {
                        continue;
                    }
                    runBat(batLocation);
                }
            }
            lblMarkStatus.Text = "Đã chấm xong";
            MessageBox.Show("Tự Động Chấm Xong");
            using (StreamWriter sw = new StreamWriter(pathOfListTestCase+"../Project/Mark.txt"))
            {
                foreach (var item in lsOutputOfStudent)
                {
                    string[] test = item.Split('/');
                    string txt = test[0];
                    string Ques = test[test.Length - 3];
                    string TC = test[test.Length - 1].Split('.')[0];
                    string[] test1 = item.Split('\\');
                    string txt1 = test1[test1.Length - 1];
                    string[] test2 = txt1.Split('_');
                    string codeST = test2[0];
                    foreach (var s in listST)
                    {
                        if (s.Code == codeST)
                        {
                            List<Question> qu = s.LQuestions;
                            foreach (var q in qu)
                            {
                                if (q.Code == Ques)
                                {
                                    List<TestCase> tc = q.LTestCases;
                                    foreach (var t in tc)
                                    {
                                        if (t.Code == TC)
                                        {
                                            string OutPutST="";
                                            using (StreamReader sr = new StreamReader(item.ToString()))
                                            {
                                                string outputST;
                                                bool gotOutput = true;
                                                while ((outputST = sr.ReadLine()) != null)
                                                {
                                                    if (outputST.Trim().Length == 0)
                                                    {
                                                        continue;
                                                    }
                                                    if (outputST.Contains("OUTPUT:"))
                                                    {
                                                        gotOutput = false;
                                                    }
                                                    if (gotOutput == false && !outputST.Contains("OUTPUT:"))
                                                    {
                                                        OutPutST += outputST + "\n";
                                                    }
                                                }
                                            }
                                            t.OutPutST = OutPutST;
                                            sw.WriteLine(OutPutST + t.Code);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void writeFileTest(string name, string filename, string command)
        {
            filename += "/" + name + ".bat";
            try
            {
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    sw.WriteLine(command);
                }
                string allBatLocation = Directory.GetCurrentDirectory();
                allBatLocation = allBatLocation.Substring(0, allBatLocation.Length - 9) + "allBatLocation.txt";
                using (StreamWriter sw = File.AppendText(allBatLocation))
                {
                    sw.WriteLine(filename);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("write file Error");
                Console.WriteLine(ex.Message);
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

        //private string fixedPath(string path)
        //{
        //    int length = path.Length;

        //    string[] part = path.Split["\\"];
        //    for (int i = 0; i < length; i++)
        //    {
        //        path.
        //    }
        //}

        public void writeFile(string name, string filename, List<string> command)
        {
            filename += name+".bat";
            try
            {
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    foreach (var item in command)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }
                string allBatLocation = Directory.GetCurrentDirectory();
                allBatLocation = allBatLocation.Substring(0, allBatLocation.Length - 9)+"allBatLocation.txt";
                using (StreamWriter sw = File.AppendText(allBatLocation))
                {
                    sw.WriteLine(filename);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("write file Error");
                Console.WriteLine(ex.Message);
            }
        }
        List<StudentNotFullMark> lsNotFullMarkStudent = new List<StudentNotFullMark>();
        private void btnMark_Click(object sender, EventArgs e)
        {
            string curDic = Directory.GetCurrentDirectory();
            curDic = curDic.Substring(0, curDic.Length - 9);
            
            using (StreamWriter sw = new StreamWriter(curDic+"../Project/Mark.txt"))
            {
                // duyệt qua từng  student trong list
                foreach (var item in listST)
                {
                    List<TestCase> lsQ_Tescase = new List<TestCase>();
                    double mark = 0;
                    List<Question> ques = item.LQuestions;
                    // duyệt qua từng câu hỏi trong bài làm của student
                    foreach (var q in ques)
                    {
                        
                        List<TestCase> tes = q.LTestCases;
                        //duyệt qua từng testCase trong câu hỏi
                        foreach (var t in tes)
                        {
                            //if (t.OutPutST == t.OutPutTC)
                            //{
                            //mark += t.Mark;
                            //}
                            bool isMark = false;
                            string outputST = t.OutPutST.Trim();
                            string outputTC = t.OutPutTC.Trim();
                            if (t.RemoveSpace.Equals("YES"))
                            {
                                if (outputST.Equals(outputTC))
                                {
                                    isMark = true;
                                }
                            }
                            else
                            {
                                if (t.OutPutST.Equals(t.OutPutTC))
                                {
                                    isMark = true;
                                }
                            }
                            if (t.CaseSen.Equals("YES"))
                            {
                                if (outputST.Equals(outputTC))
                                {
                                    isMark = true;
                                }
                                else
                                {
                                    isMark = false;
                                }
                            }
                            else
                            {
                                if (outputST.ToLower().Equals(outputTC.ToLower()))
                                {
                                    isMark = true;
                                }
                                else
                                {
                                    isMark = false;
                                }
                            }
                            if (isMark)
                            {
                                mark += t.Mark;
                            }
                            else
                            {
                                lsQ_Tescase.Add(new TestCase(q.Code+"_"+t.Code,"","",t.Mark,"",""));
                            }
                        }
                    }
                    //luu tat thong tin diem cua hoc sinh
                    lsNotFullMarkStudent.Add(new StudentNotFullMark(item.Code, item.Name, item.Exam,lsQ_Tescase));
                    item.Mark = mark;
                    sw.WriteLine(item.Code + "\t" + item.Name + "\t" + item.Exam +"\t"+ mark);
                }
            }
            //danh sach cac sinh vien ko full diem
            using (StreamWriter sw = new StreamWriter(curDic + "../Project/listStudentNotFullMark/lsStudentNotFullMark.txt"))
            {
                foreach (var item in lsNotFullMarkStudent)
                {
                    sw.WriteLine(item.Code+".txt");
                }
            }
            //Luu danh sach lsNotFullMarkStudent ra file txt trong folder listStudentNotFullMark
            foreach (var item in lsNotFullMarkStudent)
            {
                using (StreamWriter sw = new StreamWriter(curDic + "../Project/listStudentNotFullMark/"+item.Code+".txt"))
                {
                    sw.WriteLine("Code");
                    sw.WriteLine(item.Code);
                    sw.WriteLine("Name");
                    sw.WriteLine(item.Name);
                    sw.WriteLine("Exam");
                    sw.WriteLine(item.Exam);
                    sw.WriteLine("lsQ_TC");
                    foreach (var qTC in item.LTestcase)
                    {
                        sw.WriteLine("Q"+qTC.Code+" Mark: "+qTC.Mark);
                    }
                }
            }
            FrmMarkList mk = new FrmMarkList(this);
            mk.Show();
            this.Hide();
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
                    
