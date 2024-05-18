

namespace Vehicles
{
    internal class Car : Vehicle
    {
    
        public int PassengerCapacity { get; set; }


        public Car(string name, string model, string color, int maxSpeed, double engineVolume, double fuelCapacity, int passengerCapacity)
            : base(name, model, color, maxSpeed, engineVolume, fuelCapacity)
        {
            PassengerCapacity = passengerCapacity;
        }

        public override void Information()
        {
            base.Information();
            Console.WriteLine($"Sərnişin Tutumu: {PassengerCapacity}");
        }
    }
}
