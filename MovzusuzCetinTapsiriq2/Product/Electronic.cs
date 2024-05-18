
namespace Product
{
    internal class Electronic : Product
    {
        public string Material { get; }
        public Electronic(string name, decimal price) : base(name, price)
        {
        }
    }
}
