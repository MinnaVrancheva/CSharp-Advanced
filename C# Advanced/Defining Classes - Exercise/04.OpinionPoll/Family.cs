using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> persons;

        public Family()
        {
            this.persons = new();
        }

        public List<Person> Persons { get { return this.persons; } set { this.persons = value; } }

        public void AddMember(Person member)
        {
            this.persons.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.persons.MaxBy(x => x.Age);
        }
    }
}
