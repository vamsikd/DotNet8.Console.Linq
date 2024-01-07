using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Con = System.Console;

namespace DotNet8.Console.Linq
{
    internal class Filtering
    {
        public static void DistinctElementSimple(IList<Person> persons)
        {
            var list = persons
                .Distinct();
            foreach (var person in list) 
            {
                Con.WriteLine(person);
            }
        }
        public static void DistinctElementComparer(IList<Person> persons)
        {
            // stops when finds the first macthing element
            var list = persons
                .Distinct(new PersonComparer());
            foreach (var person in list)
            {
                Con.WriteLine(person);
            }
        }
        public static void DistinctByElementComparer(IList<Person> persons)
        {
            // stops when finds the first macthing element
            var list = persons
                .DistinctBy(p => p.LastName);
            foreach (var person in list)
            {
                Con.WriteLine(person);
            }
        }
    }

    class PersonComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            if (x is null || y is null) return false;

            if(ReferenceEquals(x, y)) return true;

            return x.LastName == y.LastName;  

        }

       public int GetHashCode(Person p)
        {
            return p.LastName!.GetHashCode();
        }
    }
}
