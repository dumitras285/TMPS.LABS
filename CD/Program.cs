using System;

namespace CD
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCategory ComputerizedTechniques = new ComputerizedTechnology("Tehnica Computerizata");
            ProductCategory Laptops = new ComputerizedTechnology("Laptopuri");
            ProductCategory AcerLaptops = new ComputerizedTechnology("Laptopuri Acer");
            Product AcerAspireA51543R19L = new Laptop("AcerAspireA51543R19L", 9999);
            AcerAspireA51543R19L = new MicrosoftOficeInstalling(" AcerAspireA51543R19L", 200, AcerAspireA51543R19L);
            AcerAspireA51543R19L = new WindowsInstalling("AcerAspireA51543R19L", 200, AcerAspireA51543R19L);


            ComputerizedTechniques.Add(Laptops);
            Laptops.Add(AcerLaptops);
            AcerLaptops.Add(AcerAspireA51543R19L);
            ComputerizedTechniques.Display(0);

            Console.WriteLine("\nAcerAspireA51543R19L Price: " + AcerAspireA51543R19L.GetCost());

            Console.ReadLine();
        }
    }
}
