using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Statement
    {

        public Statement(Person person, TypePensy typePensy, List<Document> documents, DateTime date)
        {
            this.person = person;
            this.typePensy = typePensy;
            this.documents = documents;
            Date = date;
        }
        public Person person { get; }
        public TypePensy typePensy { get; }
        public List<Document> documents { get; }
        public DateTime Date { get; }
    }
}
