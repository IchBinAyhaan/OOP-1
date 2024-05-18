namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
      
            Car car = new Car("Toyota", "Corolla", "Beyaz", 180, 1.8, 50, 5);
            Truck truck = new Truck("Mercedes", "Actros", "Mavi", 120, 12.0, 300, 5000);

     
            Console.WriteLine("Araba haqqında məlumatlar:");
            car.Information();
            Console.WriteLine();

            Console.WriteLine("Tir haqqında məlumatlar:");
            truck.Information();
        }
    }
}


