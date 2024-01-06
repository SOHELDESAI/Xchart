//using Microsoft.AspNetCore.Mvc;

//namespace Xchart.Models
//{
//    public class XChartModel : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
//}

using System;

namespace Xchart.Models
{
    public class XChartModel
    {
        public int[] Data { get; set; } = GenerateRandomData();

        private static int[] GenerateRandomData()
        {
            Random random = new Random();
            return new int[] { random.Next(1, 100), random.Next(1, 100), random.Next(1, 100), random.Next(1, 100), random.Next(1, 100) };
        }
    }
}

