using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w10b_t1
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialising the stack
            Stack<char> charStack = new Stack<char>();

            //Getting input from the user
            Console.Write("Enter sequence of characters: ");
            string userInput = Console.ReadLine();

            //String is turned into a char array
            char[] UIArray = userInput.ToArray();

            //Each element is pushed into the stack
            foreach (var x in UIArray)
            {
                charStack.Push(x);
            }
            Console.WriteLine("\n");

            //Poping from the stack
            //Geetting the inital length so poping doesn't effect the stack
            int len = charStack.Count();
            Console.WriteLine("Reveserd output using STACK is: ");
            for (int i = 0; i < len; i++)
            {                
                Console.Write(charStack.Pop() + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
