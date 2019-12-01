using System;

namespace DellChallenge.C
{
    class Program
    {
        static void Main(string[] args)
        {
            // Please refactor the code below whilst taking into consideration the following aspects:
            //      1. clean coding
            //      2. naming standards
            //      3. code reusability, hence maintainability
            StartHere();
            Console.ReadKey();
        }

        private static void StartHere()
        {
            Addition myNewObject = new Addition();
            int sum1 = myNewObject.Do(1, 3);
            int sum2 = myNewObject.Do(1, 3, 5);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
        }
    }
}
