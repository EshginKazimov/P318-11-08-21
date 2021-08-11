using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAbstract
{
    class Person
    {
        private static int counter = 0;

        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public static int Count { get; set; }

        //Static constructor - yalniz 1 defe ishe dushur, parametrless olmalidir
        static Person()
        {
            //Console.WriteLine("Static constructor created");
        }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            //if (counter % 2 == 0)
            //    counter++;
            //else
            //    counter += 2;
            counter++;
            Id = counter;
            //Id++;
            //Console.WriteLine("Person created");
        }

        public void Test()
        {
            Count = 10;
            Name = "";
        }

        public static void Print()
        {
            Count = 10;
            Console.WriteLine("Print");
        }
    }
}
