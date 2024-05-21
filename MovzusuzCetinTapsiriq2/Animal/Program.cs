namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Cat cat = new Cat("Mia", 3, "Dişi", "Qara");
            Dog dog = new Dog("Max", 5, "Erkek", "Qehveyi");

            
            cat.MakeSound(); 
            dog.MakeSound(); 
        }
    }
}

