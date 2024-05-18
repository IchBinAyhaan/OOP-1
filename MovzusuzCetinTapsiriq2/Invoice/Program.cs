namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice("678904", "Alex", "Foxtrot");
            inv.Article = "USB-hab";
            inv.Quantity = 6;
            inv.Price = 30;

            decimal totalCostWithEdv = inv.CostCalculation(true);
            Console.WriteLine("Ümumi deyer edv ile: " + totalCostWithEdv);

            decimal totalCostWithoutEdv = inv.CostCalculation(false);
            Console.WriteLine("Ümumi deyer edv olmadan: " + totalCostWithoutEdv);
        }
    }
}


