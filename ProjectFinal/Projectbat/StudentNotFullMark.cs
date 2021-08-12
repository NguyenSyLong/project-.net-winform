using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectbat
{
    class StudentNotFullMark
    {
        private string _code;

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _exam;

        public string Exam
        {
            get { return _exam; }
            set { _exam = value; }
        }
        private List<TestCase> ltestcase;

        public List<TestCase> LTestcase
        {
            get { return ltestcase; }
            set { ltestcase = value; }
        }

        public StudentNotFullMark()
        {

        }
        public StudentNotFullMark(string code, string name, string exam, List<TestCase> Q_TC)
        {
            this.Code = code;
            this.Name = name;
            this.Exam = exam;
            this.LTestcase = Q_TC;
        }
    }
}
