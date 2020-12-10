using System;

namespace Arithmatic_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int operation;
            operation = 2 + 5 * 4;
            Console.WriteLine("operation result is =" + operation);
            
            int divideInt = 25 / 2;
            double floatFail = 25 / 2;
            double divideFloat = 25.0 / 2.0;
            int modulo = 25 % 2;

            Console.WriteLine(divideInt);
            Console.WriteLine(floatFail);
            Console.WriteLine(divideFloat);
            Console.WriteLine(modulo); 

            char first = 'C';
            char last = 'T';

            char backSpace = '\b';
            char tab = '\t';
            char hexLetter = '\u004A';

            Console.WriteLine("My first" + first + tab +"my last"+last);
            Console.WriteLine(hexLetter);

            string firstName = "";

            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine(firstName);
            Console.WriteLine(firstName);
            Console.WriteLine(firstName);
            Console.WriteLine(firstName); 

            bool isRaining = true;
            Console.WriteLine(isRaining);

            bool isBigger = 15 < 5;
            Console.WriteLine(isBigger);

            
            int myAge = 23;

            if (myAge>18)
            {
                Console.WriteLine("Your age is " + myAge.ToString() + " and you can enter.");
            } 

            int x = 0;
            while (x<5)
            {
                Console.WriteLine(x);
                x++;
            }

            myMethod();

            int myAge = 23;
            ageMethod(myAge);
        }

        public static void myMethod()
        {
            string name = "Cheers";
            Console.WriteLine(name + " darling");
        }
        public static void ageMethod(int years)
        {
            Console.WriteLine(years);
        }
    }
}
