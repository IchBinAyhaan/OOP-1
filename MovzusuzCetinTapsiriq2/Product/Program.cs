using Product;

class Program
{
    public static void Main()
    {
        Electronic electronic = new Electronic("Laptop", 1500);
        Clothes clothes = new Clothes("Shirt", 30);

        Order order = new Order();
        order.AddProduct(electronic);
        order.AddProduct(clothes);
        order.GetDetails();
        Console.WriteLine($"Total Amount: {order.GetTotalAmount():C}");

        order.RemoveProduct(electronic);
        order.GetDetails();
    }
}