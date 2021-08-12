using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Exam
    {
        private string _code;

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        private List<Question> _Q;

        public List<Question> Question
        {
            get { return _Q; }
            set { _Q = value; }
        }
        public Exam()
        {

        }
        public Exam(string code)
        {
            this.Code = code;
        }
    }
}
