namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kedi ve köpek nesneleri oluşturuluyor
            Cat cat = new Cat("Mia", 3, "Dişi", "Siyah");
            Dog dog = new Dog("Max", 5, "Erkek", "Kahverengi");

            // Sesler çıkarılıyor
            cat.MakeSound(); // Mia miyav diye ses çıkarır.
            dog.MakeSound(); // Max hav diye ses çıkarır.
        }
    }
}

