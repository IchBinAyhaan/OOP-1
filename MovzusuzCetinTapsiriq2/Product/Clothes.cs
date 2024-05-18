
namespace Product
{
    internal class Clothes : Product
    {
        public string Size {  get; }
        public Clothes(string name, decimal price) : base(name, price)
        {
        }
    }
}
