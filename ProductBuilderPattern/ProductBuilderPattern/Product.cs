using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductBuilderPattern
{
    public class Product
    {
        public string? Name { private get; set; }
        public double? Width { private get; set; }
        public double? Height { private get; set; }
        public double? Length { private get; set; }

        public void Display()
        {
            if (Name != null) Console.WriteLine($"Name: {Name}");
            if (Width != null) Console.WriteLine($"Width: {Width}");
            if (Height != null) Console.WriteLine($"Height: {Height}");
            if (Length != null) Console.WriteLine($"Length: {Length}");
        }
    }
}
