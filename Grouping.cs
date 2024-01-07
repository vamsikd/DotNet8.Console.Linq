using DotNet8.Console.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Con = System.Console;


namespace DotNet8.Conole.Linq
{
    public class Grouping
    {

        
        public static void GrpBySimple(IList<Person> persons)
        {
            // look up at top level class 
            var personGrp = persons
                .GroupBy(p => p.LastName, p => p);
            foreach (var g in personGrp)
            {
                Con.WriteLine(g.Key);
                foreach (var person in g)
                {
                    Con.WriteLine(person);
                }
            }

        }
        public static void LookUpSimple(IList<Person> persons)
        {
            // look up at top level class 
            var personLookUp = persons
            .ToLookup(p => p.LastName, p => p);
            foreach (var g in personLookUp)
            {
                Con.WriteLine(g.Key);
                foreach (var person in g)
                {
                    Con.WriteLine(person);
                }
            }
        }
        public static void ToDictionarySimple(IList<Person> persons)
        {
            // dictionary at top level class 
            var personDict1 = persons
                .GroupBy(p => p.LastName!)
                .ToDictionary(g => g.Key);
            foreach (var g in personDict1)
            {
                Con.WriteLine(g.Key);
                foreach (var person in g.Value)
                {
                    Con.WriteLine(person);
                }
            }
        }
        public static void GrpByCompnayNameWithMultiSelect(IList<Person> persons)
        {
            var grpList = persons
                .GroupBy(p => p.Company.Name)
                .Select(g => new
                {
                    Company = g.First().Company,
                    Peoplw = g
                });
            foreach (var g in grpList)
            {
                Con.WriteLine(g.Company.Name);
                foreach (var person in g.Peoplw)
                {
                    Con.WriteLine(person);
                }
            }
        }
        public static void GrpByCompnayNameWithSelect(IList<Person> persons)
        {
            // this is same as plain group by
            var grpList = persons
                .GroupBy(p => p.Company.Name)
                .Select(g => g);
            foreach (var g in grpList)
            {
                Con.WriteLine(g.Key);
                Con.WriteLine(g.First().Company.Name);
                foreach (var person in g)
                {
                    Con.WriteLine(person);
                }
            }
        }
        public static void GrpByCompnayNameWithSelectMany(IList<Person> persons)
        {
            // this is same as plain group by
            var grpList = persons
                .GroupBy(p => p.Company.Name)
                .SelectMany(g => g);
            foreach (var person in grpList)
            {
                Con.WriteLine(person);
            }
        }
        public static void GrpByWithSelectManyOrdering(IList<Person> persons)
        {
            var list = persons
                .GroupBy(p => p.LastName)
                .SelectMany(g => g.OrderByDescending(p => p.Age).Skip(1).Take(2));
            foreach (var p in list)
            {
                Con.WriteLine(p);
            }
        }
    }
}
