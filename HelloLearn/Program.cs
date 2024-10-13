using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloLearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bhoo testing git
            // C# is a case sensetive programing language
            /* Console.WriteLine("Hello World!");
             Console.WriteLine("C# using for games,console appiications.");
             Console.WriteLine("C# runs in .net Framework.So thats means C# is a part of .net framework");
             Console.WriteLine(".net framework is a open source framework. Means anyone can contribute there through github");
            */
            /*  Data types in C#:
               Integer - int age=23;

               Floating points num - float num;
               Character - char c = 'B';
               String - string inp = "Bush"

             */
            int a = 15;
            float b = 10.2F;  //110.2 is consider double that's why have to add F to clarification
            char c = 'b';
            string s = "Bushra is lazy";
            Console.WriteLine(s);
            Console.WriteLine(c);
            Console.WriteLine(a);
            Console.WriteLine(b);
           

            //Taking user input for the string input only
            string userInput = Console.ReadLine();
            Console.WriteLine("User input String: "+ userInput);

            //Type Casting 
            //There are 2 types of type casting
               // 1. Implicit Casting: char to -> int to -> long to -> float to ->double
               // 2. Explicit Type : 
            int x = (int)3.5; // It is explicit cast
            double y = x; // it is possible and it is implicit type
            // int a = y not possible
            Console.WriteLine(x);

            Console.ReadLine();
        }
    }
}
