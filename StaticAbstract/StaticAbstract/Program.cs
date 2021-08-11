using System;

namespace StaticAbstract
{
    //Student.cs olsun, Name, Surname, Age olsun
    //Neche defe instance aldigimi mene qaytarsin

    class Program
    {
        static void Main(string[] args)
        {
            #region Static

            //Person.Count = 10;
            //Person.Count = 10;
            //Person.Count = 10;
            //Person.Count = 10;
            //Person.Count = 10;
            //Person.Count = 10;
            //Person.Count = 10;
            //Console.WriteLine(Person.Count);

            //Person.Print();

            //Person p1 = new Person();
            //Person p2 = new Person();
            //Person p3 = new Person();
            //Person p4 = new Person();
            //p1.Count = 10;
            //p1.Print();
            //p1.Test();

            //Program pr1 = new Program();
            //pr1.Test();

            //Test();

            //Helper h1 = new Helper();
            //Helper.Print("Salam P318");
            //Helper.Print("Salam P318");
            //Helper.Print("Salam P318");
            //Helper.Print("Salam P318");
            //Helper.Print("Salam P318");

            //double pi = Math.PI;

            //Person elnur = new Person("Elnur", "Suleymanzade", 31);
            //Console.WriteLine(elnur.Id);

            //Person fagan = new Person("Fagan", "Eyvazov", 24);
            //Console.WriteLine(fagan.Id);

            #endregion

            #region Abstract

            //Animal a1 = new Animal();
            //Shark s1 = new Shark();
            //s1.Eat();
            //s1.Swim();
            //s1.Drink();

            //Eagle e1 = new Eagle();
            //e1.Eat();
            //e1.Fly();
            //e1.Drink();

            //Print(s1);
            //Print(e1);

            //Circle c = new Circle();
            //Rectangle r = new Rectangle();

            //Calculate(c);
            //Calculate(r);

            #endregion
        }

        #region Abstract

        public static void Print(Animal animal)
        {
            animal.Eat();
        }

        public static void Calculate(Figure f)
        {
            Console.WriteLine("Area = " + f.CalculateArea()); 
        }

        #endregion

        #region Static

        public static void Test()
        {
            Console.WriteLine("Test");
        }

        #endregion
    }

    #region Abstract

    //Abstract class-da methodlar abstract olmalidir ve ya virtual.
    //Instance almaq olmur
    abstract class Animal
    {
        public abstract int Age { get; set; }    

        public abstract void Eat();

        public virtual void Drink()
        {
            Console.WriteLine("Drink as Animal");
        }
    }

    abstract class Bird : Animal
    {
        public abstract void Fly();
    }

    class Eagle : Bird
    {
        public override int Age { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }
    }

    abstract class Fish : Animal
    {
        public abstract void Swim();

        //public override void Drink()
        //{
        //    Console.WriteLine("Drink as Fish");
        //}
    }

    class Shark : Fish
    {
        public override int Age { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim as Shark");
        }
    }

    abstract class Figure
    {
        public abstract double CalculateArea();
    }

    class Circle : Figure
    {
        public override double CalculateArea()
        {
            return Math.PI * 10 * 10;
        }
    }

    class Rectangle : Figure
    {
        public override double CalculateArea()
        {
            return 10 * 20;
        }
    }

    #endregion
}
