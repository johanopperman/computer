using System;
using System.Security.Cryptography.X509Certificates;

namespace Computer
{
    public class Computer
    {
        public string Motherboard { get; set; }
        public int CPUCores { get; set; }
        public bool HasWifi { get; set; }
        public bool HasLTE { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string VideoCard { get; set; }

        public Computer()
        {
            if (VideoCard == null)
            {
                VideoCard = "";
            }
            if (Motherboard == null)
            {
                Motherboard = "";
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer()
            {
                Motherboard = "ZMO900",
                CPUCores = 500,
                HasLTE = false,
                HasWifi = false,
                ReleaseDate = new DateTime(),
                Price = 34.99m,
                VideoCard = "RTX 2000"
            };

            Console.WriteLine("You have a"+ " " + myComputer.Motherboard + " " + "motherboard on your machine!");
            Console.WriteLine(myComputer.CPUCores);
            Console.WriteLine(myComputer.HasLTE);
            Console.WriteLine(myComputer.HasWifi);
            Console.WriteLine(myComputer.ReleaseDate);
            Console.WriteLine(myComputer.Price);
            Console.WriteLine(myComputer.VideoCard);

        }
    }
}