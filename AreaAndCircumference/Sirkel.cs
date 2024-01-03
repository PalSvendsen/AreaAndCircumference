namespace AreaAndCircumference
{
    internal class Sirkel : Shapes
    {
        public Sirkel(int diameter) 
        {
            Width = diameter;
            Height = Width;
        }

        public double CalculateArea() 
        {
            return Math.PI * Width / 2 * Width / 2;
        }

        public double CalculateCircumference() 
        {
            return Math.PI * Width;
        }

        public void ShowInfoCircle()
        {
            Console.WriteLine("Arealsirkel: " + Convert.ToString(CalculateArea()));
            Console.WriteLine("OmkretsSirkel: " + Convert.ToString(CalculateCircumference()));
        }

    }
}
