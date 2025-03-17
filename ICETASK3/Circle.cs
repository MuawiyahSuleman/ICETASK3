using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICETASK3
{
    // Step 4: Create the Circle Class
    public class Circle : Shape, ICalculateArea
    {
        public double Radius { get; set; }

        // Constructor
        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        // Implement CalculateArea Method
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        // Override Display Method
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Circle - Radius: {Radius}, Area: {CalculateArea():F2}");
        }
    }
}
