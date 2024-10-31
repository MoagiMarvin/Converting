using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converting
{

    internal class Program
    {
        static void Main()
        {   //To repeat the cycle untill terminated
            while (true)
            {
                // Display instuctions
                Console.WriteLine("CONVERTING NUMBERS TO WORDS!");
                Console.WriteLine("---------------------------------");
                Console.WriteLine();

                Console.WriteLine("Enter a numbers between 0-9999");
                Console.WriteLine("Type and enter 'q' to quit");
                Console.WriteLine("---------------------------------");


                string input = Console.ReadLine();


                //To end the code from running 
                if (input.ToLower() == "q")
                    break;

                if (int.TryParse(input, out int number))
                {
                    if (number >= 0 && number <= 9999)
                    {
                        string result = convet(number);
                        Console.WriteLine($"{number} = {result}\n");
                        //Underline and spacing
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine();
                        Console.WriteLine();

                    }
                    else
                    {
                        //If enter a number above 9999
                        Console.WriteLine("Number out of range of 0 and 9999");
                        Console.WriteLine("Please enter a number between 0 and 9999");

                    }
                }
                else
                {
                    //If enter nothing
                    Console.WriteLine("Invalid . Please enter a number");
                }
            }

        }

        static string convet(int number)
        {
            string[] units = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                          "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            if (number == 0)
                return units[0];

            string words = null;

            // Thousands
            if ((number / 1000) > 0)
            {
                words += units[number / 1000] + " Thousand ";
                number %= 1000;
            }

            // Hundreds

            if ((number / 100) > 0)
            {
                words += units[number / 100] + " Hundred ";
                number %= 100;

                if (number > 0)
                    words += "and ";
            }

            // Tens and Units
            if (number > 0)
            {
                if (number < 20)
                    words += units[number];
                else
                {
                    words += tens[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + units[number % 10];
                }
            }

            return words;
        }
    }
}