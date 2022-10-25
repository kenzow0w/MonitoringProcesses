using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormMonitoring
{
    public class Utils
    {

        public static bool itHasDigital(String text)
        {
            char[] ch = text.ToCharArray();
            foreach (char s in ch)
            {
                if (char.IsDigit(s))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
