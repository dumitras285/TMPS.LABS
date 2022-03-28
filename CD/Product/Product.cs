using System;

namespace CD
{
    abstract class Product : ProductCategory
    {
        protected double ProductCost;
        public Product(string name, double cost) : base(name)
        {
            this.ProductCost = cost;
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string(' ', depth) + name);
        }

        public override void Add(ProductCategory component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(ProductCategory component)
        {
            throw new NotImplementedException();
        }
        public abstract double GetCost();
    }
}
