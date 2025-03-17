using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICETASK3
{
    public abstract class Shape
    {
        public string Name { get; set; } // Property for shape name

        // Constructor
        public Shape(string name)
        {
            Name = name;
        }

        // Virtual Display Method
        public virtual void Display()
        {
            Console.WriteLine($"Shape: {Name}");
        }
    }
}
