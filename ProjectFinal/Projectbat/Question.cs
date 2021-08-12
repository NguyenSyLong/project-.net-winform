using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectbat
{
    class Question
    {
        private string _code;

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        private List<TestCase> ltestCases;

        public List<TestCase> LTestCases
        {
            get { return ltestCases; }
            set { ltestCases = value; }
        }

        public Question() { }
        public Question(string code, List<TestCase> tc)
        {
            this.Code = code;
            this.LTestCases = tc;
        }
    }
}
