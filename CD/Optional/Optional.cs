
namespace CD
{
    abstract class Optional : Product

    {
        protected Product Product;
        public Optional(string name, double cost, Product product): base(name, cost)
        {
            this.Product = product;
        }

        public abstract override double GetCost();
    }
}
