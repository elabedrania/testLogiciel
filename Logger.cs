using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testlogiciel
{
  public class Logger
    {
       

        public bool IsValidLogFile(string FileName)
        {
            if (FileName.ToUpper().EndsWith("SDF"))
                return true;
            return false;
            
        }
    }
}
