//using Microsoft.AspNetCore.Mvc;

//namespace Xchart.Controllers
//{
//    public class XChartController : Controller
//    {
//        public IActionResult Index()
//        {
//            var xChartModel = new XChartModel(); // Replace with your model or data source
//            return View(xChartModel);
//        }

//        [HttpGet]
//        public IActionResult RefreshData()
//        {
//            var refreshedData = new XChartModel(); // Replace with logic to fetch updated data
//            return Json(refreshedData);
//        }
//    }
//}

using Microsoft.AspNetCore.Mvc;
using Xchart.Models; // Update with your actual namespace
using System;

public class XChartController : Controller
{
    public IActionResult Index()
    {
        var xChartModel = new XChartModel();
        return View(xChartModel);
    }

    [HttpGet]
    public IActionResult RefreshData()
    {
        var refreshedData = new XChartModel();
        return Json(refreshedData);
    }
}
