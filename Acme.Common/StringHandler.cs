using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public class StringHandler
    {
        public string InsertSpaces(string source)
        {
            string result = string.Empty;
            if (!String.IsNullOrWhiteSpace(source))
            {
                //Boolean isFirstLetter = true;
                foreach (char letter in source)
                {                                  
                    if (char.IsUpper(letter))   // && !isFirstLetter
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                    //isFirstLetter = false;
                }
            }
            return result.Trim();
        }
    }
}
