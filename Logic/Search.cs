using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Search
    {
        public static string[] SerchString(string subString, string[] stroka)
        {
            string str = subString.ToLower();
            List<string> res = new List<string>();

            foreach(string comp in stroka)
            {
                if (comp.ToLower().Contains(str))
                {
                    res.Add(comp);
                }      
            }

            return res.ToArray();
        }
    }
}
