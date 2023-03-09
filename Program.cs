using System;

namespace NumericTypes
{
    class Program
    {
        public static void Main(string[] args)
        {
            double length;
            double width;
            double area;
            string input; 


            Console.WriteLine("Length: ");
            input = Console.ReadLine();
            length = double.Parse(input);

            Console.WriteLine("Width: ");
            input = Console.ReadLine();
            width = double.Parse(input);

            area = (length * width);
            Console.WriteLine("The area of your rectangle is: " + area);
            Console.ReadLine();

        }
    }
}
