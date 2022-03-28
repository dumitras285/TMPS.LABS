
namespace CB
{
    class AcerLaptopBuilder : LaptopBuilder
    {
        public AcerLaptopBuilder(string name)
        {
            this.laptop = new Laptop(name);
        }
        
        public override LaptopBuilder SetBluetooth(string bluetooth)
        {
            laptop.Bluetooth = bluetooth;
            return this;
        }

        public override LaptopBuilder SetMemory(string memory)
        {
            laptop.Memory = memory;
            return this;
        }

        public override LaptopBuilder SetProcessor(string processor)
        {
            laptop.Processor = processor;
            return this;
        }

        public override LaptopBuilder SetProducer(string producer)
        {
            laptop.Producer = producer;
            return this;
        }

        public override LaptopBuilder SetScreenResolution(string resolution)
        {
            laptop.ScreenResolution = resolution;
            return this;
        }

        public override LaptopBuilder SetVideoCard(string videocard)
        {
            laptop.VideoCard = videocard;
            return this;
        }

        public override LaptopBuilder SetWebCamera(string webcamera)
        {
            laptop.WebCamera = webcamera;
            return this;
        }

        public override LaptopBuilder SetWiFi(string wifi)
        {
            laptop.WiFi = wifi;
            return this;
        }
    }
}
