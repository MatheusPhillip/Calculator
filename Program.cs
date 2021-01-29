using System;
using ProjectCalculator.Model;
using ProjectCalculator.View;

namespace ProjectCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            char answer;
            float num1, num2;
            do
            {
                Menu.showMenu();
                ch = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digit the first number: ");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digit the second number: ");
                num2 = float.Parse(Console.ReadLine());
                switch (ch)

                {
                    case 1:
                        Calculator.Sum(num1, num2);
                        break;
                    case 2:
                        Calculator.Subtract(num1, num2);
                        break;
                    case 3:
                        Calculator.Multiple(num1, num2);
                        break;
                    case 4:
                        Calculator.Divide(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Choose an available option!");
                        break;
                }
                Console.WriteLine("Do you want to calculate again? | (Y)es or (N)o :");
                answer = Char.Parse(Console.ReadLine());
                answer = Char.Parse(answer.ToString().ToUpper());
            } while (!answer.Equals('N'));

            
        }
    }
}
