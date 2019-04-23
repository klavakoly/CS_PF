using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class TypePensy
    {
        public TypePensy(int id, string name, decimal sizePency )
        {
            ID_ = id;
            Name_ = name;
            SizePency_ = sizePency;
        }

        public override string ToString()
        {
            return Name_ ;
        }

        public string NameSize
        {
            get
            {
                return Name_.PadRight(20)  + SizePency_.ToString().PadLeft(10);
            }
            
        }

        public int ID_ { get; }
        public string Name_ { get; }
        public decimal SizePency_ { get; }

       
        
    }
}
