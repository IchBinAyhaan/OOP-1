

namespace Animal
{
    internal class Cat : Animal
    {
        public Cat(string name, int age, string gender, string color)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Color = color;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Miyav");
        }
    }
}
