using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Name is Omar");
            Console.WriteLine("My Favorite Color is Navy Blue");
            Console.WriteLine("The current year is 2024");
            Console.ReadKey();
            //Console.ReadKey is used to wait for user input before going to the next task



            int age = 19;
            double height = 1.85;
            char fav_letter = 'O';
            Boolean like_prog = true;

            //height is stored as a double because it is a decimal

            Console.WriteLine("I am " + age + " years old.");
            Console.WriteLine("My height is " + height+" meters.");
            Console.WriteLine("My favorite letter is " + fav_letter + ".");
            Console.WriteLine("Do I like programming? " + like_prog + ".");
            Console.ReadKey();

            Console.WriteLine("Enter the radius of the circle: ");
            int radius = Convert.ToInt16(Console.ReadLine());
            double PI = 3.14159;
            double area = PI * radius * radius;
           
            Console.WriteLine("The area of the circle is " + area);
            Console.ReadKey();

            String name = "Sarah";
            Int64 pop = 1500000;
            double temp = 23.5;
            Boolean is_student = true;

            Console.WriteLine("The persons name is " + name +".");
            Console.WriteLine("The population of the city is " + pop+".");
            Console.WriteLine("The temperature is " + temp + " degrees celsius.");
            Console.WriteLine("Is the person a student? " + is_student);
            Console.ReadKey();
            /*We used String for Sarah, Int64 for population, double for temperature,
             ,and Boolean for the final output*/
        }

        

    }
}
