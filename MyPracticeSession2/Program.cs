using System;

namespace MyPracticeSession2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            const float Pi = 3.14f; 
            decimal number1 = 1.2m;
            var number=2;
            var totalPrice = 1.2f;
            var count = 10;
            var character = 'A';
            var firstName = "Mosh";
            var isWorking = false;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0} {1}", byte.MinValue,byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            byte b = 1;
            int i = b;
            Console.WriteLine(i);
             
            Console.ReadLine();
        }
    }
}
