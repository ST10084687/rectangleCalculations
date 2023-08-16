using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangleCalculations
{
    public class Program
    {
        static void Main(string[] args)
        {
            double height;
            double width;
            double area;
            double perimeter;



            Console.WriteLine("Please enter the height of the rectangle >>>");
            height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the width of the rectangle >>>");
            width = Convert.ToDouble(Console.ReadLine());


            computations(height, width, out area, out perimeter);

            Console.WriteLine("The area of the rectangle is: " + area);
            Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
            

            Console.ReadLine(); 
            
        }
       
           

        
        public static void computations(double height, double width, out double area, out double perimeter)
        {
            area = width * height;
            perimeter = 2 * (width + height);


        }
       
    }
}
