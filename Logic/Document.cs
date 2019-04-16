using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Document
    {
        public Document(int id, string name)
        {
            ID_ = id;
            Name_ = name;
        }

        public override string ToString()
        {
            return Name_;
        }

        public int ID_ { get; }
        public string Name_ { get; }
    }
}

