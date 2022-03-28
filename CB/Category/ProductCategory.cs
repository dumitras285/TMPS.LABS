using System;
using System.Collections.Generic;
using System.Text;

namespace CB
{
    abstract class ProductCategory
    {
        protected string name;

        public ProductCategory(string name)
        {
            this.name = name;
        }

        public abstract void Display(int depth);
        public abstract void Add(ProductCategory c);
        public abstract void Remove(ProductCategory c);
    }
}
