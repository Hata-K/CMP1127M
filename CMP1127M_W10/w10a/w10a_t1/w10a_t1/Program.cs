using System;
using System.Collections.Generic;

namespace w10a_t1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intUL = new List<int>();

            bool b = true;

            while (b == true)
            {
                Console.Write("Enter a number or 'stop': ");
                var userInput = Console.ReadLine();

                if (userInput.ToUpper() != "STOP")
                {
                    intUL.Add(Int32.Parse(userInput));
                }
                else
                {
                    b = false;
                    Display(intUL);
                    Console.WriteLine("\n");
                }
            }
        }

        private static void Display(List<int> intUL)
        {
            Console.WriteLine("Your sorted list is: ");
            intUL.Sort();
            foreach (int num in intUL)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
