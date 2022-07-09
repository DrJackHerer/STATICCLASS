using System;

namespace StaticKeyword
{
     class Program
    {
        private static object rng;

        static void Main(string[] args)
        {
            var Celsius = TempConverter.FahrenheitToCelsius(68);
            var farenheit = TempConverter.CelsiusToFarenheit(40);


            Console.WriteLine("After Conversion:");
            Console.WriteLine($"{farenheit}");
        }
    }
}
