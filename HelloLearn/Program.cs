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
            //    int a = 15;
            //    float b = 10.2F;  //110.2 is consider double that's why have to add F to clarification
            //    char c = 'b';
            //    string s = "Bushra is lazy";
            //Console.WriteLine(s);
            //Console.WriteLine(c);
            //Console.WriteLine(a);
            //Console.WriteLine(b);


            //Taking user input for the string input only
            //string userInput = Console.ReadLine();
            //Console.WriteLine("User input String: "+ userInput);

            //Type Casting 
            //There are 2 types of type casting
            // 1. Implicit Casting: char to -> int to -> long to -> float to ->double
            // 2. Explicit Type : 
            //int x = (int)3.5; // It is explicit cast
            //double y = x; // it is possible and it is implicit type
            // int a = y not possible
            // Console.WriteLine(x);



            // Boolean datatypes
            bool isMale = false;
            Console.WriteLine(isMale);
            bool isSale = true;
            Console.WriteLine(isSale);




            //  Converting string to numbers
            string age1 = "-23";
            int age2= Convert.ToInt32(age1);
            Console.WriteLine(age2);

            string textBignum = "500000000";
            long bigNum = Convert.ToInt64(textBignum);
            Console.WriteLine(bigNum);

            string textnegative = "-50000.256";
            double bigNumNegative = Convert.ToDouble(textnegative);
            Console.WriteLine(bigNumNegative);

            string f = "25.2000015464";
            float precision= Convert.ToSingle(f);
            Console.WriteLine(precision);


            string mt = "8.25";
            decimal m = Convert.ToDecimal(mt);
            Console.WriteLine(m);


            // Operators  + - * /
            //int age = 23;
            //Console.WriteLine(age2++);
            //Console.WriteLine(age);
            // Console.WriteLine(++age);

            // age *= 20;
            //Console.WriteLine(age);
            //  
            //  // Remainder
            // int f1 = 21;
            // int f2 = 2;
            // Console.WriteLine("Remiander :"+ (f1%f2));
            //  
            //  
            //  // var is a keyword which we can use to intialize any kind of datas
            //  var a = 5;
            //  var b = 5.2554F;
            // var c = 25.455D;
            //var d = "Ama";
            //  var e = 'a';

            // const keyword
            //  const int v = 555; // so we can't chnage the value
            //  
            //  //Storing user data
            // var n = "Bush";
            // var dd = "012365546";
            // var i = 5;




            // Taking User input and string to number
            // Console.WriteLine("Enter your name");
            //string nam = Console.ReadLine();
            // Console.WriteLine("Hey I'm " + nam);

            // Console.WriteLine("How many candies you want?");
            // string can = Console.ReadLine();
            // Console.WriteLine("You will get 4 more candies so you get total: "
            //   + (Convert.ToInt32(can) + 4) + " Candies");


            // If else and switch cases conditional

            //        Console.Write("Enter your age: ");
            //      string tg= Console.ReadLine();
            //    int age = Convert.ToInt32(tg);
            //    if(age <=2)
            //    {
            //        Console.WriteLine("You are just born");
            //    }
            //    else if (age <= 10)
            //  {
            //      Console.WriteLine("You are not allowed");
            //    }
            //  else if(age>=18 && age <= 70)
            //  {
            //      Console.WriteLine("You are allowed to drive");
            //  }
            //  else
            //    //   {
            //      Console.WriteLine("Enjoy");
            //  }
            // switch (age)
            //{
            //  case 2: 
            //    Console.WriteLine("Not allowed");
            //  break;
            //case 18: 
            //  Console.WriteLine("you are allowed");
            //break;

            //                default: 
            //                  Console.WriteLine("enjoy");
            //                break;



          //      for (int i = 0; i < 10; i++)
           //    {
           //        Console.WriteLine(i);
           //    }
           //    int a = 0;
           //    while (a < 5)
           //    {
           //        Console.WriteLine(a);
           //        a++;
           //    }
           //    do {
            //      a++;
            //      Console.WriteLine(a);
           //    } while (a <= 5);

            Console.ReadLine();




        }
    }
}
