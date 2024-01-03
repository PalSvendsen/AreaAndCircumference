using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndCircumference
{
    internal class Rektangel : Shapes
    {

        public Rektangel(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }
        public double CalculateCircumference()
        {
            return Width * 2 + Height * 2;
        }
        public void ShowInfoRektangel()
        {
            Console.WriteLine("ArealRektangel: " + Convert.ToString(CalculateArea()));
            Console.WriteLine("OmkretsRektangel: " + Convert.ToString(CalculateCircumference()));
        }
    }
}
