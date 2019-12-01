using System;

namespace DellChallenge.A
{
    class Program
    {
        static void Main(string[] args)
        {
            // State and explain console output order.
            /*1. When class B is called, the constructor for class A is called, because of the inheritance (B:A) => A.A()
             2. The constructor for class B is called => B.B()
             3. Then, we are setting a value for the "Age" property, so, the "set" property is called, and it contains a Console.Writeline => A.Age*/
            new B();
            Console.ReadKey();
        }
    }

    class A
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                Console.WriteLine("A.Age");
            }
        }


        public A()
        {
            Console.WriteLine("A.A()");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("B.B()");
            Age = 0;
        }
    }
}
