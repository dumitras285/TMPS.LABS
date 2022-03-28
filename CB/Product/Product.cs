using System;

namespace CB
{
    class Product : ProductCategory
    {
        public Product(string name) : base(name)
        { }

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


    }
}
