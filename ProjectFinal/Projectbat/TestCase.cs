using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectbat
{
    class TestCase
    {
        private string _code;

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        private string _outputTC;

        public string OutPutTC
        {
            get { return _outputTC; }
            set { _outputTC = value; }
        }
        private string _outputST;

        public string OutPutST
        {
            get { return _outputST; }
            set { _outputST = value; }
        }
        private double _mark;

        public double Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }
        private string _RM;

        public string RemoveSpace
        {
            get { return _RM; }
            set { _RM = value; }
        }
        private string _CS;

        public string CaseSen
        {
            get { return _CS; }
            set { _CS = value; }
        }


        public TestCase() { }
        public TestCase(string code, string tc, string st, double mark, string rm, string cs)
        {
            this.Code = code;
            this.OutPutST = st;
            this.OutPutTC = tc;
            this.Mark = mark;
            this.RemoveSpace = rm;
            this.CaseSen = cs;
        }

    }
}
