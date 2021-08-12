using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Question
    {
        private string _code;

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        private double _mark;

        public double Mark      
        {
            get { return _mark; }
            set { _mark = value; }
        }
        private string TC;

        public string TC_code
        {
            get { return TC; }
            set { TC = value; }
        }

        private List<Testcase> _TC;

        public List<Testcase> Testcase
        {
            get { return _TC; }
            set { _TC = value; }
        }
        private string show;

        public string Show
        {
            get { return show; }
            set { show = value; }
        }

        public Question()
        {

        }
        public Question(string code, double mark)
        {
            this.Code = code;
            this.Mark = mark;
            
        }
        public Question(string code,  string tCode, string show)
        {
            this.Code = code;
            this.TC_code = tCode;
            this.Show = show;
        }
    }
}
