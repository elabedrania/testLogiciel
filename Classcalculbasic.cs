using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculBasic
{
    public class Classcalculbasic
    {
        public bool Add(int x,int y )
        {
            return (( x + y)<0);
            

        }
        public bool Substract(int x, int y)
        {
            return x > y;

        }
        public bool Multiple(int x, int y)
        {
            int r = x * y;
            return r>0 ;

        }
        public bool Div(int x, int y)
        {
            return x / y>0;

        }



    }
}
