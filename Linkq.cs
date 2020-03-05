using System;
using System.Collections;
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



            //===Method Syntax

            //IList<string> stringList = new List<string>() {"C# Tutorials","VB.NET Tutorials","Learn C++","MVC Tutorials","Java"};
            //var result = stringList.Where(s => s.Contains("Tutorials"));
            //foreach (var name in result)
            //   Console.Write(name + " ");

            //IList<Person> personList = new List<Person>()
            //{
            //    new Person() {  Name = "John", Gender = "male"} ,
            //    new Person() {  Name = "Moin", Gender = "female" } ,
            //    new Person() { Name = "Bill",  Gender = "female" } ,
            //    new Person() { Name = "Ram" , Gender = "male"} ,
            //    new Person() {Name = "Ron" , Gender = "male" }
            //      };
            //var result = personList.Where(a=>a.Gender.Contains("male"));
            //foreach (var name in result)
            //   Console.WriteLine("Name:" +name.Name+"  Gender:"+name.Gender);


            //Standard query operators

            //IList mixedList = new ArrayList();
            //mixedList.Add(0);
            //mixedList.Add("One");
            //mixedList.Add("Two");
            //mixedList.Add(3);
            //mixedList.Add(new Person() {  Name = "Bill", Gender = "male" });
            //Console.WriteLine("String Type");
            //var stringResult = from s in mixedList.OfType<string>()
            //                   select s;
            //foreach (var name in stringResult)
            //    Console.WriteLine(name);

            //Console.WriteLine("Integer Type");
            //var intResult = from s in mixedList.OfType<int>()
            //                select s;
            //foreach (var name in intResult)
            //    Console.WriteLine(name);


            //order by
            IList<Person> personList = new List<Person>() {
            new Person() { Name = "John", Age = 18 } ,
            new Person() { Name = "Steve",  Age = 15 } ,
            new Person() { Name = "Bill",  Age = 25 } ,
            new Person() { Name = "Ram" , Age = 20 } ,
            new Person() { Name = "Ron" , Age = 19 }
            };

            // order by using query syntax
            //var orderByResult = from s in personList
            //                    orderby s.Name
            //                    select s;
            //foreach (var name in orderByResult)
            //    Console.WriteLine(name.Name);

            //order by using method syntax
            //var orderByResult = personList.OrderBy(x => x.Name);
            //foreach (var name in orderByResult)
            //    Console.WriteLine(name.Name);

            //order by using method syntax in Descending order
            //var orderByDescendingResult = personList.OrderByDescending(x => x.Name);
            //foreach (var name in orderByDescendingResult)
            //    Console.WriteLine(name.Name);


            //Using ThenBy 
            //var thenByResult = personList.OrderBy(s => s.Name).ThenBy(s => s.Age);
            //foreach (var name in thenByResult)
            //    Console.WriteLine(name.Name+name.Age);

            //Join
            IList<string> strList1 = new List<string>() {
            "One",
            "Two",
            "Three",
            "Four"
             };

            IList<string> strList2 = new List<string>() {
            "One",
            "Two",
            "Five",
            "Six"
             };

            var innerJoin = strList1.Join(strList2,
                                  str1 => str1,
                                  str2 => str2,
                                  (str1, str2) => str1);

            foreach (var name in innerJoin)
               Console.WriteLine(name);
        }
    }
}
