
namespace Product
{
    internal class Order
    {
        private const int MaxProducts = 10;
        private Product[] products;

        public Order()
        {
            products = new Product[MaxProducts];
        }

        public void AddProduct(Product product)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == null)
                {
                    products[i] = product;
                    return;
                }
            }
            Console.WriteLine("Product limit reached. Cannot add more products to the order.");
        }

        public bool RemoveProduct(Product product)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == product)
                {
                    products[i] = null;
                    return true;
                }
            }
            Console.WriteLine($"{product.Name} is not in the order.");
            return false;
        }

        public void GetDetails()
        {
            Console.WriteLine("Order Details:");
            foreach (var product in products)
            {
                if (product != null)
                {
                    Console.WriteLine($"Product Name: {product.Name}, Price: {product.Price:C}");
                }
            }
        }

        public decimal GetTotalAmount()
        {
            decimal totalAmount = 0;
            foreach (var product in products)
            {
                if (product != null)
                {
                    totalAmount += product.Price;
                }
            }
            return totalAmount;
        }
    }
}

      
    
