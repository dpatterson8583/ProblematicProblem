using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblematicProblem
{
    internal static class BoolValueHack
    {
        public static bool FixBool(string s)
        {
            switch (s.ToLower())
            {
                case "yes": return true;
              
                case "no" : return false;
                    
                case "keep": return false;

                case "redo": return true;

                case "no thanks": return false;

                case "sure": return true;

                case "n": return false;

                case "y": return true;

                default: return false;

            }
        } 
    }
}
