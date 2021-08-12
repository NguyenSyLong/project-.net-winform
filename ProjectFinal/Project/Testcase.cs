using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Testcase
    {
        private string _code;

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        private string _input;

        public string Input
        {
            get { return _input; }
            set { _input = value; }
        }
        private string _output;

        public string Output
        {
            get { return _output; }
            set { _output = value; }
        }
        private double _mark;

        public double Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }
        private bool _RS;

        public bool RemoveSpace
        {
            get { return _RS; }
            set { _RS = value; }
        }
        private bool _CS;

        public bool CaseSensitive
        {
            get { return _CS; }
            set { _CS = value; }
        }



        public Testcase()
        {

        }
        public Testcase(string code, string input, string output, double mark , bool rs, bool cs)
        {
            this.Code = code;
            this.Input = input;
            this.Output = output;
            this.Mark = mark;
            this.RemoveSpace = rs;
            this.CaseSensitive = cs;
        }
       
    }
}
