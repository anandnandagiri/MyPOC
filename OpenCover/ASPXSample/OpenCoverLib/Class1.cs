using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCoverDemoLib
{
    public class Class1
    {

        public int Add(int a ,int b)
        {
            return a + b;
        }

        public string ifConditiontest(bool val)
        {
             if(val)
            {
                return "If condition true";
            }
                else
            {
                return "If condition false";
            }
        }

        public string NoCallProcedure(bool val)
        {
            return "NoCallProcedure";
        }
    }
}
