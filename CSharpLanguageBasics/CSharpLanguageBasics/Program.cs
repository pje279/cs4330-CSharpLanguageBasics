using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLanguageBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte sample1 = 0x3A;
            byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            const float acceleration = (float)9.8;
            float mass = (float)14.6;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            const char integral = '\u222B';
            const string greeting = "Hello";
            string name = "Karen";

            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal.");
            } //End if (sample1 == sample2)
            else
            {
                Console.WriteLine("The samples are not equal.");
            } //End else

            if (heartRate > 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal.");
            } //End if (heartRate > 40 && heartRate <= 80)
            else
            {
                Console.WriteLine("Heart rate is not normal.");
            } //End else

            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            } //End if (deposits >= 100000000)
            else
            {
                Console.WriteLine("Sorry you are so poor.");
            } //End else

            float force = mass * acceleration;
            Console.WriteLine("force = " + force);

            Console.WriteLine(distance + " is the distance.");

            if (lost && expensive)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            } //End if (lost && expensive)
            else if (lost && !expensive)
            {
                Console.WriteLine("Here is coupon for 10% off.");
            } //End if (lost ** !expensive)

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
            } //End switch (choice)
            
            Console.WriteLine(integral + " is an integral.");

            for (int i = 5; i <= 10; i++)
            {
                Console.WriteLine("i = " + i);
            } //End for (int i = 5; i <= 10; i++)

            int age = 0;

            while (age < 6)
            {
                Console.WriteLine("age = " + age);
                age++;
            } //End while (age < 6)

            Console.WriteLine(greeting + " " + name);

            Console.ReadKey();
        } //End static void Main(string[] args)
    } //End class Program
} //End namespace CSharpLanguageBasics
