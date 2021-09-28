using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class ColorLine
    {
        SetColor SetC = new SetColor();
        public void Check(string HourMin)
        {
            string[] s = HourMin.Split(".");

            if (HourMin == "18.06")
            {
                SetC.Color("Such a time does not exist!\n", ConsoleColor.Yellow);
            }
            else if (Convert.ToInt32(s[0]) <= 11)
            {
                SetC.Color(String.Format("{0:yyyy} {1}\n", DateTime.Now, HourMin.Replace(".", ":")), ConsoleColor.Red);
            }
            else if (Convert.ToInt32(s[0]) >= 12)
            {
                SetC.Color(String.Format("{0:yyyy} {1}\n", DateTime.Now, HourMin.Replace(".", ":")), ConsoleColor.Green);
            }
        }

    }
}
