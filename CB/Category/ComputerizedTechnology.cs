using System;
using System.Collections.Generic;
using System.Text;

namespace CB
{
    class ComputerizedTechnology : ProductCategory
    {
        List<ProductCategory> children = new List<ProductCategory>();

        public ComputerizedTechnology(string name) : base(name)
        { }

        public override void Add(ProductCategory component)
        {
            children.Add(component);
        }

        public override void Remove(ProductCategory component)
        {
            children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string(' ', depth) + name);

            foreach (ProductCategory component in children)
            {
                component.Display(depth + 2);
            }
        }
    }
}
