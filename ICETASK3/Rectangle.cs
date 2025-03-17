using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICETASK3
{
    // Step 3: Create the Rectangle Class
    public class Rectangle : Shape, ICalculateArea
    {
        public double Length { get; set; }
        public double Width { get; set; }

        // Constructor
        public Rectangle(string name, double length, double width) : base(name)
        {
            Length = length;
            Width = width;
        }

        // Implement CalculateArea Method
        public double CalculateArea()
        {
            return Length * Width;
        }
        // Override Display Method
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Rectangle - Length: {Length}, Width: {Width}, Area: {CalculateArea()}");
        }
    }
}
