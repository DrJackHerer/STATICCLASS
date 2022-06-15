using System;

namespace STATICCLASS
{
     class Program
    {
        private static object rng;

        static void Main(string[] args)
        {
            //Math MyMath = new Math();


            //static class method
            Math.Pow(5, 2);

            //non static
            Random rng = new Random();

            rng.Next(0, 100);

            string myName;
            
            
            Console.WriteLine("Hello World!");
        }
    }
}
