using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe3
{
    class Program
    {
        static void Main(string[] args)
        {
             double height, weight;
             double bmi;
             string input1, input2;
             Console.Write("Enter your weight (kg): ");
             input1 = Console.ReadLine();
             weight = Convert.ToDouble(input1);

             Console.Write("Enter your height (cm): ");
             input2 = Console.ReadLine();
             height = Convert.ToDouble(input2);

            bmi = weight / ((height / 100) * (height / 100));
            Console.WriteLine("Your BMI is: " + bmi.ToString("F"));
            Console.ReadLine();

             /*bmi = (double) weight / (double)((height/100) * (double)(height/100));
             Console.WriteLine("Your BMI is: " + bmi);
             Console.ReadLine();
             */


            /*double i = (double) 196 / 100;
            Console.WriteLine(i);
            Console.ReadLine();
            */
        }
    }
}
