
namespace Shape 
{
    internal class Square : Shape
    {
        
        public double Side { get; set; }

  
        public Square(double side)
        {
            Side = side;
        }

     
        public override double CalculateArea()
        {
            return Side * Side;
        }
    }
}
