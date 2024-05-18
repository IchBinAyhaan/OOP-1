

namespace Animal
{
    internal class Dog : Animal
    {

        public Dog(string name, int age, string gender, string color) 
        {
            Name = name;
            Age = age;
            Gender = gender;
            Color = color;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Hav!");
        }
    }
}
