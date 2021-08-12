using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectbat
{
    class StudentMark
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
        private List<Question> lquestions;

        public List<Question> LQuestions
        {
            get { return lquestions; }
            set { lquestions = value; }
        }
        private double _mark;

        public double Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }


        public StudentMark()
        {

        }
        public StudentMark(string code,string name,string exam, List<Question> Q,double mark)
        {
            this.Code = code;
            this.Name = name;
            this.Exam = exam;
            this.LQuestions = Q;
            this.Mark = mark;
        }

    }
}
