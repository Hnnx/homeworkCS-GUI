using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTuts
{
    class Person
    {

        public string firstName { get; set; }
        public string lastName { get; set; }

        public string fullName
        {
            get
            {
                return $"{firstName} {lastName}";
            }
        }

        public List<Person> people = new List<Person>();


    }
}
