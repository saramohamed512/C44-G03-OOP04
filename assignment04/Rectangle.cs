using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment04
{
    internal class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        // Parameterless constructor
        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        // Constructor with width and height
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        // Constructor with single value 
        public Rectangle(int size)
        {
            Width = size;
            Height = size;
        }
        public override string ToString()
        {
            return $"Rectangle: Width = {Width}, Height = {Height}";
        }
    }
}
