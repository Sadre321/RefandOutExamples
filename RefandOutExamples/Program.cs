using System;

namespace RefandOutExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int value_1;
            int value_2 = 20;
            int result = Add(out value_1, value_2);
            
            Console.WriteLine(value_1);
            Console.WriteLine("Sonuç :"+result);

            int number1 = 112;
            int number2 = 13;
            int total = Add2(ref number1,number2);

            Console.WriteLine(number1);
            Console.WriteLine("Sonuç2 :"+total);
        }

        static int Add(out int value_1, int value_2)
        {
            value_1 = 12;
            return value_1 + value_2;
        }

        static int Add2(ref int number1,int number2) 
        {
            number1 = 65;
            return number1 + number2;
        }
    }
}
