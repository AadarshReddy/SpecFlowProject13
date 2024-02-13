using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject13
{
    public class Calculator
    {
        public int Fnum { get; set; }
        public int Lnum { get; set; }

        public int Add()
        {
            int res;
            res = Fnum + Lnum;
            return res;
        }
        public int Sub()
        {
            int res;
            res = Fnum - Lnum;
            return res;
        }
        public int Mul()
        {
            int res;
            res = Fnum * Lnum;
            return res;
        }
        public int Div()
        {
            int res;
            res = Fnum / Lnum;
            return res;
        }
    }
}
