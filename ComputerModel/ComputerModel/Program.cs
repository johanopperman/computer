using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Computer
{
    public class Computer
    {
        public string Motherboard { get; set; } = string.Empty;
        public int CPUCores { get; set; }
        public bool HasWifi { get; set; }
        public bool HasLTE { get; set; }
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
            string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;";

            IDbConnection dbConnection = new SqlConnection(connectionString);

            Computer myComputer = new Computer()
            {
                Motherboard = "ZMO9002",
                CPUCores = 901,
                HasWifi = true,
                HasLTE = true,
                ReleaseDate = new DateTime(),
                Price = 105.99m,
                VideoCard = "RTX 6701"
            };

            string sql = @"INSERT INTO TutorialAppSchema.Computer (

                Motherboard,
                CPUCores,
                HasLTE,
                HasWifi,
                ReleaseDate,
                Price,
                VideoCard
            )VALUES ('" + myComputer.Motherboard
                    + "','" + myComputer.CPUCores
                    + "','" + myComputer.HasWifi
                    + "','" + myComputer.HasLTE
                    + "','" + myComputer.ReleaseDate.ToString("yyyy-MM-dd")
                    + "','" + myComputer.Price.ToString("0.00",CultureInfo.InvariantCulture)
                    + "','" + myComputer.VideoCard
            + "')";

            Console.WriteLine(sql);

            int result = dbConnection.Execute(sql);
            Console.WriteLine(result);


            string sqlSelect = @"SELECT 
                Computer.Motherboard,
                Computer.CPUCores,
                Computer.HasLTE,
                Computer.HasWifi,
                Computer.ReleaseDate,
                Computer.Price,
                Computer.VideoCard
            FROM TutorialAppSchema.Computer";

            IEnumerable<Computer> computers =  dbConnection.Query<Computer>(sqlSelect);

            Console.WriteLine("'Motherboard','CPUCores','HasWifi','HasLTE','ReleaseDate','Computer','VideoCard'");

            foreach (Computer computer in computers)
            {
                Console.WriteLine("'" + myComputer.Motherboard
                    + "','" + myComputer.CPUCores
                    + "','" + myComputer.HasWifi
                    + "','" + myComputer.HasLTE
                    + "','" + myComputer.ReleaseDate.ToString("yyyy-MM-dd")
                    + "','" + myComputer.Price.ToString("0.00", CultureInfo.InvariantCulture)
                    + "','" + myComputer.VideoCard
            + "'");
            }


            //Console.WriteLine("You have a"+ " " + myComputer.Motherboard + " " + "motherboard on your machine!");
            //Console.WriteLine(myComputer.CPUCores);
            //Console.WriteLine(myComputer.HasLTE);
            //Console.WriteLine(myComputer.HasWifi);
            //Console.WriteLine("You have a mobile phone with status" + " " + myComputer.HasMobilePhone);
            //Console.WriteLine(myComputer.ReleaseDate);
            //Console.WriteLine(myComputer.Price);
            //Console.WriteLine(myComputer.VideoCard);

        }
    }
}