using System;
using System.Collections.Generic;
using System.Text;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int answer;
            char convert;


            Console.WriteLine("Jemel Barreto");
            Console.Write("Enter the First Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type 1 for Addition, 2 for Subtraction, 3 for Multiplication, and 4 for Division.");
            convert = Convert.ToChar(Console.ReadLine());
            
            
            
            switch (convert)
            {
                case '1':
                    answer = number1 + number2;
                    Console.WriteLine("Your addition answer is: {0}", answer);
                    break;


                case '2':
                    answer = number1 - number2;
                    Console.WriteLine("Your subtraction answer is: {0}", answer);
                    break;


                case '3':
                    answer = number1 * number2;
                    Console.WriteLine("Your multiplication answer is: {0}", answer);
                    break;


                case '4':
                    answer = number1 / number2;
                    Console.WriteLine("Your division answer is: {0}", answer);
                    break;


              
            }
            Console.ReadLine();
        }
    }
}


