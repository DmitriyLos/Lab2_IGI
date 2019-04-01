using System;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class WorkerController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}