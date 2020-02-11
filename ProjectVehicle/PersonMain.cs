using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class PersonMain
    {
        static void Main(string[] args)
        {
            Person objPerson = new Person();
            List<Person> personList = new List<Person>();
            personList.Add(new Person { Name = "rahul", Age = 18 });
            personList.Add(new Person { Name = "ashish", Age = 133 });
            personList.Add(new Person { Name = "prabhat", Age = 21 });
            personList.Add(new Person { Name = "arif", Age = 69 });
            personList.Add(new Person { Name = "vijay", Age = 34 });
            foreach (var el in personList)
                if (el.Age > 60)
            {
                Console.WriteLine(el.Name+" "+el.Age);
            }
            Console.ReadKey();

        }
    }
}
