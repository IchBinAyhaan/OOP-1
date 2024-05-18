

namespace Animal
{
    internal abstract class Animal
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }

        public abstract void MakeSound();
    }
}
