using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Person
    {
        public int INN { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string ContactPhone { get; set; }
        public string RegistrationCity { get; set; }
        public DateTime DataRogdeniya { get; set; }

        public Person(int iNN, string surname, string name, string middleName, string contactPhone, string registrationCity, DateTime dataRogdeniya)
        {
            INN = iNN;
            Surname = surname;
            Name = name;
            MiddleName = middleName;
            ContactPhone = contactPhone;
            RegistrationCity = registrationCity;
            DataRogdeniya = dataRogdeniya;
        }

        public Person(Person person)
        {
            INN = person.INN;
            Surname = person.Surname;
            Name = person.Name;
            MiddleName = person.MiddleName;
            ContactPhone = person.ContactPhone;
            RegistrationCity = person.RegistrationCity;
            DataRogdeniya = person.DataRogdeniya;

        }

        public override string ToString()
        {
            return INN +"    "+Surname + " " + Name + " " + MiddleName;
        }
    }

}
