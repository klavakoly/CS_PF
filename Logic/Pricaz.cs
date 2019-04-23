using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Pricaz
    {
        public Pricaz(int iNN, string pency, int iD, string Smonth, string Syear, string sername, string name, string middleName)
        {
            INN = iNN;
            this.pency = pency;
            ID = iD;
            Month = Smonth;
            Year = Syear;
            Sername = sername;
            Name = name;
            MiddleName = middleName;
        }

        public int INN { get; set; }       
        public string pency { get; }
        public int ID { get; }
        public string Month { get; }
        public string Year { get; }
        public string Sername { get; }
        public string Name { get; }
        public string MiddleName { get; }

        public Pricaz(Pricaz pricaz)
        {
            INN = pricaz.INN;
            pency = pricaz.pency;
            ID = pricaz.ID;
            Month = pricaz.Month;
            Year = pricaz.Year;
            Sername = pricaz.Sername;
            Name = pricaz.Name;
            MiddleName = pricaz.MiddleName;
        }

        public override string ToString()
        {
            return INN.ToString().PadRight(5) + " " + Sername + " " + Name + " " + MiddleName;
        }

    }
}
