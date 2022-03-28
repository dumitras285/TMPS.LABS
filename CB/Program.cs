using System;

namespace CB
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();
            LaptopBuilder AcerNitroBuilder = new AcerLaptopBuilder("Acer Nitro AN515-54-599H");
            AcerNitroBuilder
                .SetProcessor("Core i5-9300H")
                .SetMemory("8 Gb")
                .SetVideoCard("NVIDIA GeForce GTX 1650")
                .SetProducer("Acer")
                .SetScreenResolution("1920x1080 FullHD")
                .SetWiFi("Yes")
                .SetBluetooth("Yes")
                .SetWebCamera("Yes");

            LaptopBuilder AcerAspireBuilder = new AcerLaptopBuilder("Acer Aspire A315-23 Pure Silver");
            AcerAspireBuilder
                .SetProcessor("AMD Ryzen 3 3250U")
                .SetMemory("4 Gb")
                .SetVideoCard("Radeon Vega 8 Graphics")
                .SetProducer("Acer")
                .SetScreenResolution("1920x1080 FullHD")
                .SetWiFi("Yes");

            ProductCategory ComputerizedTechniques = new ComputerizedTechnology("Tehnica Computerizata");
            ProductCategory Laptops = new ComputerizedTechnology("Laptopuri");
            ProductCategory AcerLaptops = new ComputerizedTechnology("Laptopuri Acer");
            ProductCategory AcerNitroAN51554599H = admin.AddLaptop(AcerNitroBuilder);
            ProductCategory AcerAspireA31523 = admin.AddLaptop(AcerAspireBuilder);

            ComputerizedTechniques.Add(Laptops);
            Laptops.Add(AcerLaptops);
            AcerLaptops.Add(AcerAspireA31523);
            AcerLaptops.Add(AcerNitroAN51554599H);

            ComputerizedTechniques.Display(0);

            Console.ReadLine();
        }
    }
}
