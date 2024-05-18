

namespace Invoice
{
    internal class Invoice
    {
        public string Account { get; }
        public string Customer { get; }
        public string Provider { get; }
        public string Article { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Invoice(string account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }
        public decimal CostCalculation(bool needEdv)
        {
            decimal totalCost = Quantity * Price;
            if (needEdv)
            {
                decimal edv = totalCost * 0.18m; 
                totalCost += edv;
            }
            return totalCost;
        }
    }
}
