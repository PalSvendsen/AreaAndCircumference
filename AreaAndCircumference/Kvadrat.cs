using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndCircumference
{
    internal class Kvadrat : Shapes
    {

        public Kvadrat(int sidelength)
        {
            Width = sidelength;
            Height = Width;
        }
        public double CalculateArea()
        {
            return Width * Height;
        }
        public double CalculateCircumference()
        {
            return Width * 4;
        }
        public void ShowInfoKvadrat()
        {
            Console.WriteLine("ArealKvadrat: " + Convert.ToString(CalculateArea()));
            Console.WriteLine("OmkretsKvadrat: " + Convert.ToString(CalculateCircumference()));
        }
    }
}
