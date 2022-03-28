using System;

namespace CB
{
    class Laptop : Product
    {
        public string Model { get; set; }
        public string Processor { get; set; }
        public string VideoCard { get; set; }
        public string Producer { get; set; }
        public string WiFi { get; set; }
        public string Bluetooth { get; set; }
        public string WebCamera { get; set; }
        public string Memory { get; set; }
        public string ScreenResolution { get; set; }

        public Laptop(string name) : base(name)
        {
            this.Model = name;
        }

        public override void Add(ProductCategory c)
        {
            throw new NotImplementedException();
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string(' ', depth) + name);
        }

        public override void Remove(ProductCategory c)
        {
            throw new NotImplementedException();
        }
    }
}
