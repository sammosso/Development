using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate my BMI using:");

            Console.WriteLine();
            Console.WriteLine("M - Metric (kilograms/meters)");

            Console.WriteLine();
            Console.WriteLine("I - Imperial (pounds/inches)");

            Console.WriteLine();
            Console.WriteLine("Q - Quit");

            char response;
            response = Convert.ToChar(Console.Read());


            switch (response)
            {
                case 'm':
                case 'M':
                    MetricBMI();
                    break;

                case 'i':
                case 'I':
                    ImperialBMI();
                    break;

                case 'q':
                case 'Q':
                    Environment.Exit(0);
                    break;
            }

            Console.WriteLine($"Convert this to:");

            Console.WriteLine();
            Console.WriteLine("M - Metric (kilograms/meters)");

            Console.WriteLine();
            Console.WriteLine("I - Imperial (pounds/inches)");


            switch (response)
            {
                case 'm':
                case 'M':
                    MetricBMI();
                    break;

                case 'i':
                case 'I':
                    ImperialBMI();
                    break;

                case 'q':
                case 'Q':
                    Environment.Exit(0);
                    break;
            }
        }

        static void MetricBMI()
        {
            double Height, Weight;

            Console.ReadLine();

            Console.WriteLine("Enter your weight in kilograms:");
            Weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your height in meters:");
            Height = Convert.ToDouble(Console.ReadLine());

            double BMI = (Weight) / (Height * Height);
            Console.WriteLine($"Your BMI is {Math.Round(BMI, 2)}");
            Console.WriteLine();

            BMI myBMI = new BMI();
            bmiResult(BMI);
        }
        static void ImperialBMI()
        {
            double Height, Weight;

            Console.ReadLine();

            Console.WriteLine("Enter your weight in lbs:");
            Weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your height in inches:");
            Height = Convert.ToDouble(Console.ReadLine());

            double BMI = (Weight * 703) / (Height * Height);
            Console.WriteLine($"Your BMI is {Math.Round(BMI, 2)}");
            Console.WriteLine();

            BMI myBMI = new BMI();
            bmiResult(BMI);
        }
        static void bmiResult(double newBMI)
        {
            if (newBMI < 18.5)
            {
                Console.WriteLine($"You are classified as underweight (BMI less than 18.5)");
            } else if (newBMI >= 18.5 && newBMI <= 24.9)
            {
                Console.WriteLine($"You are classified as normal weight (BMI between 18.5 & 24.9)");
            } else if (newBMI >= 25 && newBMI <=29.9)
            {
                Console.WriteLine($"You are classified as overweight (BMI between 25.0 & 29.9)");
            }
            else 
            {
                Console.WriteLine($"You are classified as obese (BMI 30.0 and above)");
            }
        }
    }
}
