using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsTask
{
    class Linkq : Person
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
            //IList<Person> personList = new List<Person>() {
            //new Person() { Name = "John", Age = 18 } ,
            //new Person() { Name = "Steve",  Age = 15 } ,
            //new Person() { Name = "Bill",  Age = 25 } ,
            //new Person() { Name = "Ram" , Age = 20 } ,
            //new Person() { Name = "Ron" , Age = 19 }
            //};

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
            //IList<string> strList1 = new List<string>() {
            //"One",
            //"Two",
            //"Three",
            //"Four"
            // };

            //IList<string> strList2 = new List<string>() {
            //"One",
            //"Two",
            //"Five",
            //"Six"
            // };

            //var innerJoin = strList1.Join(strList2,
            //                      str1 => str1,
            //                      str2 => str2,
            //                      (str1, str2) => str1);

            //foreach (var name in innerJoin)
            //   Console.WriteLine(name);


            List<Category> categories = new List<Category>()
       {
           new Category {Name="Beverages", ID=001},
           new Category {Name="Condiments", ID=002},
           new Category {Name="Vegetables", ID=003},
           new Category {Name="Grains", ID=004},
           new Category {Name="Fruit", ID=005}
       };
            List<Product> products = new List<Product>()
      {
         new Product {Name="Cola",  CategoryID=001},
         new Product {Name="Tea",  CategoryID=001},
         new Product {Name="Mustard", CategoryID=002},
         new Product {Name="Pickles", CategoryID=002},
         new Product {Name="Carrots", CategoryID=003},
         new Product {Name="Bok Choy", CategoryID=003},
         new Product {Name="Peaches", CategoryID=005},
         new Product {Name="Melons", CategoryID=005},
       };

            //JOin
            //inner join
            //var innerJoinQuery =
            //    from category in categories
            //    join prod in products on category.ID equals prod.CategoryID
            //    select new { ProductName = prod.Name, Category = category.Name };
            //foreach (var name in innerJoinQuery)
            //    Console.WriteLine(name.ProductName);

            //A join clause with an into
            //var innerGroupJoinQuery =
            // from category in categories
            // join prod in products on category.ID equals prod.CategoryID into prodGroup
            // select new { CategoryName = category.Name, Products = prodGroup };
            //foreach (var name in innerGroupJoinQuery)
            //    Console.WriteLine(name.CategoryName);

            //All & Any
            IList<Person> personList = new List<Person>() {
            new Person() { Name = "John", Age = 18 } ,
            new Person() { Name = "Steve",  Age = 15 } ,
            new Person() { Name = "Bill",  Age = 25 } ,
            new Person() { Name = "Ram" , Age = 20 } ,
            new Person() { Name = "Ron" , Age = 19 }
            };
            // checks whether all the students are teenagers    
            //bool checkAllAreTeenager = personList.All(s => s.Age > 12 && s.Age < 20);
            //Console.WriteLine(checkAllAreTeenager);

            //Any
            //bool checkIsAnyTeenager = personList.Any(s => s.Age > 12 && s.Age < 20);
            //Console.WriteLine(checkIsAnyTeenager);

            //contains
            //IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
            //bool result = intList.Contains(10);
            //Console.WriteLine(result);

            //Person std = new Person() { Name = "Bill" };
            //bool result = personList.Contains(std);
            //    Console.WriteLine(result);


            //Average
            //IList<int> intList = new List<int> () { 10, 20, 30 };
            //var avg = intList.Average();
            //Console.WriteLine("Average: {0}", avg);
            //var avgAge = personList.Average(s => s.Age);
            //Console.WriteLine("Average Age : {0}", avgAge);

            //Count
            //IList<int> intList = new List<int>() { 10, 21, 30, 45, 50 };
            //var totalElements = intList.Count();
            //Console.WriteLine("Total Elements: {0}", totalElements);
            //var evenElements = intList.Count(i => i % 2 == 0);
            //Console.WriteLine("Even Elements: {0}", evenElements);

            //Max method 
            //IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
            //var largest = intList.Max();
            //var largest = intList.Max();
            //Console.WriteLine("Largest Element: {0}", largest);
            //var largestEvenElements = intList.Max(i => {
            //    if (i % 2 == 0)
            //        return i;

            //    return 0;
            //});
            //Console.WriteLine("Largest Even Element: {0}", largestEvenElements);

            //Linkq Sum
            //IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
            //var total = intList.Sum();
            //Console.WriteLine("Sum: {0}", total);
            //var sumOfEvenElements = intList.Sum(i => {
            //    if (i % 2 == 0)
            //        return i;

            //    return 0;
            //});
            //Console.WriteLine("Sum of Even Elements: {0}", sumOfEvenElements);

            //ElementAt() and ElementAtOrDefault()
            //IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
            //IList<string> strList = new List<string>() { "One", "Two", null, "Four", "Five" };

            //Console.WriteLine("1st Element in intList: {0}", intList.ElementAt(0));
            //Console.WriteLine("1st Element in strList: {0}", strList.ElementAt(0));

            //Console.WriteLine("2nd Element in intList: {0}", intList.ElementAt(1));
            //Console.WriteLine("2nd Element in strList: {0}", strList.ElementAt(1));

            //Console.WriteLine("3rd Element in intList: {0}", intList.ElementAtOrDefault(2));
            //Console.WriteLine("3rd Element in strList: {0}", strList.ElementAtOrDefault(2));

            //Console.WriteLine("10th Element in intList: {0} - default int value",
            //                intList.ElementAtOrDefault(9));
            //Console.WriteLine("10th Element in strList: {0} - default string value (null)",
            //                 strList.ElementAtOrDefault(9));
            //Console.WriteLine("intList.ElementAt(9) throws an exception: Index out of range");
            //Console.WriteLine("-------------------------------------------------------------");
            //Console.WriteLine(intList.ElementAt(9));

            //LINQ  FirstOrDefault()
            //IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            //IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            //IList<string> emptyList = new List<string>();

            //Console.WriteLine("1st Element in intList: {0}", intList.FirstOrDefault());
            //Console.WriteLine("1st Even Element in intList: {0}",
            //                                 intList.FirstOrDefault(i => i % 2 == 0));

            //Console.WriteLine("1st Element in strList: {0}", strList.FirstOrDefault());

            //Console.WriteLine("1st Element in emptyList: {0}", emptyList.FirstOrDefault());

            //first()
            //IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            //IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            //IList<string> emptyList = new List<string>();

            //Console.WriteLine("1st Element in intList: {0}", intList.First());
            //Console.WriteLine("1st Even Element in intList: {0}", intList.First(i => i % 2 == 0));

            //Console.WriteLine("1st Element in strList: {0}", strList.First());

            //Console.WriteLine("emptyList.First() throws an InvalidOperationException");
            //Console.WriteLine("-------------------------------------------------------------");
            //Console.WriteLine(emptyList.First());


            //single
            //IList<int> oneElementList = new List<int>() { 7 };
            //IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            //IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            //IList<string> emptyList = new List<string>();

            //Console.WriteLine("The only element in oneElementList: {0}", oneElementList.Single());
            //Console.WriteLine("The only element in oneElementList: {0}",
            //             oneElementList.SingleOrDefault());

            //Console.WriteLine("Element in emptyList: {0}", emptyList.SingleOrDefault());

            //Console.WriteLine("The only element which is less than 10 in intList: {0}",
            //             intList.Single(i => i < 10));


            //group join

            IList<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
    new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
    new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
    new Student() { StudentID = 4, StudentName = "Ram",  StandardID =2 },
    new Student() { StudentID = 5, StudentName = "Ron" }
};

            IList<Standard> standardList = new List<Standard>() {
    new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
};

            var groupJoin = standardList.GroupJoin(studentList,  //inner sequence
                                            std => std.StandardID, //outerKeySelector 
                                            s => s.StandardID,     //innerKeySelector
                                            (std, studentsGroup) => new // resultSelector 
                                {
                                                Students = studentsGroup,
                                                StandarFulldName = std.StandardName
                                            });

            foreach (var item in groupJoin)
            {
                Console.WriteLine(item.StandarFulldName);

                foreach (var stud in item.Students)
                    Console.WriteLine(stud.StudentName);
            }
        }
    }
}
