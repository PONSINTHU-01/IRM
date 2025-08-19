using System;
using System.Text.Json.Serialization;
namespace conditinal
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your marks in English:");
            int marks = Convert.ToInt32(Console.ReadLine());
            if (marks >= 90)
            {
                Console.WriteLine("Excellent");
            
            }
            else if( marks<90 && marks>50)
            {
                Console.WriteLine("Good");
            }
            else
            {
                Console.WriteLine("Needs improvement");
            }
            int age = 20;
            Console.WriteLine("--------------------------------------");
            string result = (age >= 18) ? "Eligible to vote" : "Not Eligible to vote";
            Console.WriteLine(result);


            int x=0;
            while (x <= 10)
            {
            
                Console.WriteLine(x);
                x++; 
            }
            Console.WriteLine("Enter the day");
            int day=Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }


            Console.WriteLine("Enter a multiplcation table");
            int num=Convert.ToInt32(Console.ReadLine());
            int n = 10;
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine( i + " * " + num + " = " + (i * num) );
            }


        }
    }
}

