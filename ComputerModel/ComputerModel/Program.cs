using System;
using System.Security.Cryptography.X509Certificates;

namespace Computer
{
    public class Computer
    {
        public string Motherboard { get; set; } = string.Empty;
        public int CPUCores { get; set; }
        public bool HasWifi { get; set; }
        public bool HasLTE { get; set; }
        public bool HasMobilePhone { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string VideoCard { get; set; } = string.Empty;

    //    public Computer()
    //    {
    //        if (VideoCard == null)
    //        {
    //            VideoCard = "";
    //        }
    //        if (Motherboard == null)
    //        {
    //            Motherboard = "";
    //        }
    //    }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer()
            {
                Motherboard = "ZMO9001",
                CPUCores = 900,
                HasLTE = false,
                HasWifi = false,
                HasMobilePhone = true,
                ReleaseDate = new DateTime(),
                Price = 104.99m,
                VideoCard = "RTX 6700"
            };

            Console.WriteLine("You have a"+ " " + myComputer.Motherboard + " " + "motherboard on your machine!");
            Console.WriteLine(myComputer.CPUCores);
            Console.WriteLine(myComputer.HasLTE);
            Console.WriteLine(myComputer.HasWifi);
            Console.WriteLine("You have a mobile phone with status" + " " + myComputer.HasMobilePhone);
            Console.WriteLine(myComputer.ReleaseDate);
            Console.WriteLine(myComputer.Price);
            Console.WriteLine(myComputer.VideoCard);

        }
    }
}