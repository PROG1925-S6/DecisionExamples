using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age, number1, number2, category;
            double hours, overtime;
            string suit, day;
            bool socksOn, hatOn;

            // 1. determine if a person is old enough to vote. 
            age = 11;

            if (age > 17)
            {
                Console.WriteLine("You can vote");
            }
            else
            {
                Console.WriteLine("Go away kid");
            }

            // 2. Create a program that determines the max value between 2 values

            number1 = 12;
            number2 = 15;

            if (number1 > number2)
            {
                Console.WriteLine($"{number1} is greater than {number2}");
            }
            else
            {
                Console.WriteLine($"{number2} is greater than {number1}");
            }

            // 3. Check if both values are equal
            number1 = 8;
            number2 = 9;

            if (number1 == number2)
            {
                Console.WriteLine($"{number1} is equal to {number2}");
            }
            else
            {
                Console.WriteLine($"{number1} is NOT equal to {number2}");
            }

            // 4. Check if values are not equal to each other

            if (number1 != number2)
            {
                Console.WriteLine($"{number1} is NOT equal to {number2}");
            }

            //5. Determine overtime hours from user input
            Console.Write("Please enter hours worked: ");
            hours = Convert.ToDouble(Console.ReadLine());

            if (hours <= 40)
            {
                Console.WriteLine($"You worked {hours} hours");
            }
            else
            {
                overtime = hours - 40;
                Console.WriteLine($"You worked {hours} hours, {overtime} were overtime");
            }

            //6. determine the colour of a card suit
            Console.Write("Please enter a suit: ");
            suit = Console.ReadLine();

            if (suit == "spade")
            {
                Console.WriteLine("The colour is black");
            }
            else if (suit == "clubs")
            {
                Console.WriteLine("The colour is black");
            }
            else if (suit == "hearts")
            {
                Console.WriteLine("The colour is red");
            }
            else if (suit == "diamonds")
            {
                Console.WriteLine("The colour is red");
            }
            else
            {
                Console.WriteLine("invalid input");
            }

            Console.ReadKey();
        }
    }
}
