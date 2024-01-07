using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.Console.Linq
{
    public class Person
    {
        public int Id { get; set; } = 0;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public IList<Address>? Addresses { get; set; }
        public Company Company { get; set; } = default!;

        public override string ToString()
        {
            return @$"Id: { Id }, Name: { FirstName } { LastName }, Address-Count: { Addresses?.Count }"; 
        }

        public static IList<Person> GetSeedData()
        {
            IList<Person> persons = new List<Person>
            {
               new Person
               {
                   Id = 1,
                   FirstName = "Vamsi",
                   LastName = "Doddapaneni",
                   Age = 37,
                   DateOfBirth = new DateOnly(1986, 12, 7),
                   Company = new Company
                   {
                       Name = "Infosys",
                       City = "Hyderabad"

                   },
                   Addresses = new List<Address>()
                   {
                       new Address
                       {
                           AddressType = AddressType.Perminent,
                           Apartment = "AVL Prakrithi",
                           Street1 = "Sri Lakshmi Nagar",
                           Street2 = "Manikonda",
                           City = "Hyderabad"
                       }
                   }
               },
               new Person
               {
                   Id = 2,
                   FirstName = "Naganjani",
                   LastName = "Paladugu",
                   Age = 34,
                   DateOfBirth = new DateOnly(1989, 11, 1),
                   Company = new Company
                   {
                       Name = "TCS",
                       City = "Hyderabad"

                   },
                   Addresses = new List<Address>()
                   {
                       new Address
                       {
                           AddressType = AddressType.Present,
                           Apartment = "VAL Prakruthi",
                           Street1 = "Sri Lakshmi Nagar",
                           Street2 = "Manikonda",
                           City = "Hyderabad"

                       }
                   }
               },
               new Person
               {
                   Id = 2,
                   FirstName = "Venkat",
                   LastName = "Doddapaneni",
                   Age = 40,
                   DateOfBirth = new DateOnly(1985, 3, 1),
                   Company = new Company
                   {
                       Name = "Black Knight",
                       City = "Hyderabad"

                   },
                   Addresses = new List<Address>()
                   {
                       new Address
                       {
                           AddressType = AddressType.Present,
                           Apartment = "Sai SreeLakshmi Homes",
                           Street1 = "KPHB 6 Phase",
                           Street2 = "Manikonda",
                           City = "Hyderabad"

                       }
                   }
               }
            };
            return persons;
        }
        
    }

    public class Company
    {
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
    }
    public class Address 
    {
        public AddressType AddressType{ get; set;}
        public string Apartment { get; set; } = string.Empty;
        public string Street1 { get; set; } = string.Empty;
        public string? Street2 { get; set; }
        public string City { get; set; }
    }

    public enum AddressType
    {
        Present,
        Perminent
    }
}
