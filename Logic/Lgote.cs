using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Lgote
    {
        public Lgote(int iD, string name, string information)
        {
            ID = iD;
            this.name = name;
            this.information = information;
        }

        int ID { get; }
        string name { get; }
        string information { get; }

        public override string ToString()
        {
            return "— "+information;
        }
    }
}
