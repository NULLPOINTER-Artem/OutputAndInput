using System;

namespace OutputAndInput
{
    /*
     * This program represent simple ways how to use output and input flows in C#
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Block of OUTPUT");
            Console.WriteLine();

            // OUTPUT
            // System.Console.Write/WriteLine()
            Console.Write("Hello ");
            Console.WriteLine("World!");

            Console.WriteLine();

            // Interpolation
            // First way
            string firstname = "Artem";
            string secondname = "Orlov";

            Console.WriteLine($"{firstname} {secondname}");
            Console.WriteLine($"7 + 2 = {7 + 2}");

            Console.WriteLine();

            // Second way to use interpolation
            Console.WriteLine("Hello, {0} {1}!", firstname, secondname);

            Console.WriteLine();
            Console.WriteLine("Block of INPUT");
            Console.WriteLine();

            // INPUT
            // System.Console.ReadLine()
            Console.Write("Your name is ");
            firstname = Console.ReadLine();
            Console.WriteLine($"Welcome to programming, {firstname}!");

            // FINAL BLOCK
            Console.WriteLine();
            Console.WriteLine("FINAL BLOCK WITH CONVERSION - System.Convert.ToInt32/ToDouble() and so on...");
            Console.WriteLine();

            Console.Write("How do you old ?\n -> ");
            int olds = Convert.ToInt32(Console.ReadLine());
            Console.Write("Where are you from ?\n -> ");
            string country = Console.ReadLine();
            Console.Write("Your fullname\n -> ");
            string fullname = Console.ReadLine();
            Console.Write("7,2 + 2,1 = ?\n -> ");
            double answer = Convert.ToDouble(Console.ReadLine());

            // checks the answer
            bool checkAnswer = answer == 9.3;
            
            // prepare for use this variables
            firstname = "";
            secondname = "";

            char[] chars = fullname.ToCharArray();

            for(int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ')
                {
                    i++; // skip the space
                    for(; i < chars.Length; i++)
                    {
                        secondname += chars[i];
                    }
                } else
                {
                    firstname += chars[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Hello, {firstname}!\n - Your secondname is {secondname}\n -" +
                $" Your old is {olds}\n - You are from {country}\n - Your answer is {answer} and it is {checkAnswer}");
        }
    }
}
