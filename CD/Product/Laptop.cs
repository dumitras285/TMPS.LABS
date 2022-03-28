
namespace CD
{
    class Laptop : Product
    {

        public Laptop(string name, double cost): base(name, cost)
        {
            this.ProductCost = cost;
        }
        public override double GetCost()
        {
            return ProductCost;
        }
    }
}
