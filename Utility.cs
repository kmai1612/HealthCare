using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimMaiAssign4
{
    public class Utility
    {
        // Utility method for capitalizing a string
        static public string Capitalize(string inputString)
        {
            if (inputString == null)
                return null;

            if (inputString.Length < 2)
                return inputString.ToUpper();
            else
                return inputString.Substring(0, 1).ToUpper() + inputString.Substring(1).ToLower();
        }
    }
}
