

namespace Vehicles
{
   abstract class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int MaxSpeed { get; set; }
        public double EngineVolume { get; set; }
        public double FuelCapacity { get; set; }

        public Vehicle(string name, string model, string color, int maxSpeed, double engineVolume, double fuelCapacity)
        {
            Name = name;
            Model = model;
            Color = color;
            MaxSpeed = maxSpeed;
            EngineVolume = engineVolume;
            FuelCapacity = fuelCapacity;
        }
        public virtual void Information()
        {
            Console.WriteLine($"Ad: {Name}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Reng: {Color}");
            Console.WriteLine($"Maksimum Süret: {MaxSpeed} km/saat");
            Console.WriteLine($"Motor Hecmi: {EngineVolume} L");
            Console.WriteLine($"Yanacaq Tutumu: {FuelCapacity} L");
        }
    }






        

       
      
    }

