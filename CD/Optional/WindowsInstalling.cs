
namespace CD
{
    class WindowsInstalling : Optional
    {
        public WindowsInstalling(string name, double cost, Product product) : base(name, cost, product)
        {
        }
        public override double GetCost()
        {
            var FinalCost = Product.GetCost() + ProductCost;
            return FinalCost;
        }
    }
}
