using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsTask
{
    class Linkq:Person
    {
        public void PracLinq()
        {
            //string[] names = { "Bill", "Steve", "James", "Mohan" };

            // LINQ Query 
            //var myLinqQuery = from name in names
            //                  where name.Contains('a')
            //                  select name;


            // Query execution
            //foreach (var name in myLinqQuery)
            //    Console.Write(name + " ");

            //IList<string> stringList = new List<string>() {"C# Tutorials","VB.NET Tutorials","Learn C++","MVC Tutorials","Java"};

            //// LINQ Query Syntax
            //var result = from s in stringList
            //             where s.Contains("Tutorials")
            //             select s;
            //foreach (var name in result)
            //    Console.Write(name + " ");


        //    IList<Person> personList = new List<Person>() {
        //new Person() {  Name = "John", Gender = "male"} ,
        //new Person() {  Name = "Moin", Gender = "female" } ,
        //new Person() { Name = "Bill",  Gender = "female" } ,
        //new Person() { Name = "Ram" , Gender = "male"} ,
        //new Person() {Name = "Ron" , Gender = "male" }
        //  };
        //    var PersonFemale = from s in personList
        //                        where s.Gender.Equals("female")
        //                        select s;
        //    foreach (var nam in PersonFemale)
        //        Console.Write(nam.Name + " ");



            //    IList<Person> personList = new List<Person>() {
            //new Person() {  Name = "John", Gender = "male"} ,
            //new Person() {  Name = "Moin", Gender = "female" } ,
            //new Person() { Name = "Bill",  Gender = "female" } ,
            //new Person() { Name = "Ram" , Gender = "male"} ,
            //new Person() {Name = "Ron" , Gender = "male" }
            //  };
            //    var PersonFemale = (from s in personList
            //                       where s.Gender.Equals("female")
            //                          select s).ToList();
            //    foreach (var nam in PersonFemale)
            //        Console.Write(nam.Name + " ");
        }
    }
}
