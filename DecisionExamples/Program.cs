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
            int age, number1, number2;
            double hours, overtime;
            string suit, day, category;
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

            //7. Do the same as above but use an OR statement
            if (suit == "spade" || suit == "clubs")
            {
                Console.WriteLine("The colour is black");
            }
            else if (suit == "hearts" || suit == "diamonds")
            {
                Console.WriteLine("The colour is red");
            }
            else
            {
                Console.WriteLine("invalid input");
            }

            //8. Use AND statements to see if two conditions are true
            socksOn = false;
            hatOn = true;

            if (socksOn == true && hatOn == true)
            {
                Console.WriteLine("You are wearing both a hat and socks.");
            }
            else if (socksOn == false && hatOn == false)
            {
                Console.WriteLine("You are weating neither a hat or socks");
            }
            else if (socksOn == true) 
            {
                Console.WriteLine("You are wearing socks but no hat");
            }
            else
            {
                Console.WriteLine("You are wearing a hat but no socks");

            }

            // 9. Determine hurricane wind speeds
            Console.Write("Please enter a category: ");
            category = Console.ReadLine();

            switch(category)
            {
                case "1":
                    Console.WriteLine("119-153 km/hr");
                    break;
                case "2":
                    Console.WriteLine("154-177 km/hr");
                    break;
                case "3":
                    Console.WriteLine("178-209 km/hr");
                    break;
                case "4":
                    Console.WriteLine("210-249 km/hr");
                    break;
                case "5":
                    Console.WriteLine("greater than 249 km/hr");
                    break;
                default:
                    Console.WriteLine("That is not a category");
                    break;
            }

            day = "saturday";

            switch(day)
            {
                case "Monday":
                    Console.WriteLine("It's a weekday");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's a weekday");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's a weekday");
                    break;
                case "Thursday":
                    Console.WriteLine("It's a weekday");
                    break;
                case "Friday":
                    Console.WriteLine("It's a weekday");
                    break;
                case "Saturday":
                    Console.WriteLine("It's the weekend!!!!!!");
                    break;
                case "Sunday":
                    Console.WriteLine("It's the weekend!!!!!!");
                    break;
                default:
                    Console.WriteLine("Invalid day entered");
                    break;
            }

            Console.ReadKey();
        }
    }
}
