using System;
using System.Collections.Generic;
using System.Globalization;
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
            //  bool isMale = false;
            // Console.WriteLine(isMale);
            // bool isSale = true;
            // Console.WriteLine(isSale);




            //  Converting string to numbers
            // string age1 = "-23";
            // int age2= Convert.ToInt32(age1);
            //  Console.WriteLine(age2);

            // string textBignum = "500000000";
            // long bigNum = Convert.ToInt64(textBignum);
            // Console.WriteLine(bigNum);

            // string textnegative = "-50000.256";
            // double bigNumNegative = Convert.ToDouble(textnegative);
            // Console.WriteLine(bigNumNegative);

            // string f = "25.2000015464";
            // float precision= Convert.ToSingle(f);
            // Console.WriteLine(precision);


            // string mt = "8.25";
            // decimal m = Convert.ToDecimal(mt);
            // Console.WriteLine(m);


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

            //Numeric Formatting
            /*  double value = 1000 / 12.34D;
              Console.WriteLine(value) ;
              Console.WriteLine(string.Format("{0:0}" , value));
              Console.WriteLine(string.Format("{0:0:0}",value));
              Console.WriteLine(string.Format("{0:0.00}",value));

              double money = -10D / 3D;
              Console.WriteLine(money) ;
              Console.WriteLine("$10 / $3 = ${0:0.00}",money);
              Console.WriteLine(money.ToString("C"));
              Console.WriteLine(money.ToString("C0"));
              Console.WriteLine(money.ToString("C1"));
              Console.WriteLine(money.ToString("C2"));
              Console.WriteLine(money.ToString("C3"));


              Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
              Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
              Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
              Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")));

              */
            // TryParse Function
            // int.TryParse(Console.ReadLine(), out num);
            // Console.WriteLine(num);

            // Exercise Times Table
            /* Console.WriteLine("Enter a number : ");
              int num = Convert.ToInt32(Console.ReadLine());
             // int num = 0;

             for (int i = 1; i <= 10; i++)
             {
                 Console.WriteLine("{0} x {1} = {2}", i,num, num * i);
             }
            */

            /*
             *  Create a for loop from 1 to X (15)
             *  3 and 5 = FizzBuzz
             *  3 = Fizz
             *  5 = Buzz
             *  else = number
             *  
             */
            for (int i = 1; i <= 15; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine("Number : {0}", i);
                }
                // cdf
            }


            Console.ReadLine();




        }
    }
}
