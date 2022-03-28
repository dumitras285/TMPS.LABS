
namespace CB
{
    abstract class LaptopBuilder
    {
        public Laptop laptop;
        abstract public LaptopBuilder SetProcessor(string processor);
        abstract public LaptopBuilder SetMemory(string memory);
        abstract public LaptopBuilder SetWiFi(string wifi);
        abstract public LaptopBuilder SetBluetooth(string bluetooth);
        abstract public LaptopBuilder SetProducer(string producer);
        abstract public LaptopBuilder SetScreenResolution(string resolution);
        abstract public LaptopBuilder SetWebCamera(string webcamera);
        abstract public LaptopBuilder SetVideoCard(string videocard);

    }
}
