

namespace Vehicles
{
    internal class Truck : Vehicle
    {
    
        public double LoadCapacity { get; set; }

    
        public Truck(string name, string model, string color, int maxSpeed, double engineVolume, double fuelCapacity, double loadCapacity)
            : base(name, model, color, maxSpeed, engineVolume, fuelCapacity)
        {
            LoadCapacity = loadCapacity;
        }

        // Bilgi Ver metodu (override edilmiş)
        public override void Information()
        {
            base.Information();
            Console.WriteLine($"Yük Tutumu: {LoadCapacity} kg");
        }
    }
}
