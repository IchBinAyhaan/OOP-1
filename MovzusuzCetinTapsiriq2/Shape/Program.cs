namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(5, 8);
            Circle circle = new Circle(3);
            Square square = new Square(4);

            Console.WriteLine("Ücbucagin sahesi: " + triangle.CalculateArea());
            Console.WriteLine("Dairenin sahesi: " + circle.CalculateArea());
            Console.WriteLine("Kvadrat sahesi: " + square.CalculateArea());
        }
    }
}

