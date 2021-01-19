using System;
using System.Collections.Generic;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();

            //var result = Add2(1, 2);
            //Console.WriteLine(result);
            //result = Add2(1);
            //Console.WriteLine(result);

            //int num1=20;
            //int num2 = 100;
            ////var result1 = Add3(ref num1, num2);
            //var result1 = Add3(out num1, num2);

            //Console.WriteLine(result1);
            //Console.WriteLine(num1);

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,5));

            int[] sayilar = { 1, 2, 3, 4, 5,6 };

            Console.WriteLine(Add4(sayilar));

            Console.WriteLine(Add4(1,2,3,4,5));


            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("added");
        }

        static int Add2(int num1, int num2=30)
        {
            return num1 + num2;
        }
        
        //static int Add3(ref int num1, int num2)
        //{
        //    num1 = 30;
        //    return num1 + num2;
        //}
        static int Add3(out int num1, int num2)
        {
            num1 = 30;
            return num1 + num2;
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2* num3;
        }


        static int Add4(params int[] numbers)
        {
            return numbers.Sum(); 
        }
    }
}
