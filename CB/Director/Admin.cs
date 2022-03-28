using System;

namespace CB
{
    class Admin
    {
        public Laptop AddLaptop(LaptopBuilder builder)
        {
            if (builder.laptop.Processor == null || builder.laptop.Producer == null || builder.laptop.VideoCard == null || builder.laptop.Model == null)
            {
                throw new InvalidOperationException("You must to set all required fields");
            }
            return builder.laptop;
        }
    }
}
