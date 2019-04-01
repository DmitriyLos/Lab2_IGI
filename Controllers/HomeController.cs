using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab2.Models;

namespace Lab2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Car()
        {
            return View("~/Views/Car/Index.cshtml");
        }

        [HttpGet]
        public IActionResult Order()
        {
            return View("~/Views/Order/Index.cshtml");
        }

        [HttpGet]
        public IActionResult Worker()
        {
            return View("~/Views/Worker/Index.cshtml");
        }

        [HttpPost]
        public string Car(string model, string stateNumber,
            string colour, int power) {
            return "Автомобиль " + model + " с гос. номером " + stateNumber + "\n" +
                "добавлен в базу. Цвет: " + colour + ", мощность: " + power;
        }

        [HttpPost]
        public string Order(string name, string dateReceipt)
        {
            return "Заказ " + name + " на дату " + dateReceipt + " добавлен";
        }

        [HttpPost]
        public string Worker(string name, string post)
        {
            return "Рабочий " + name + " с должностью " + post
                + " успешно зарегистрирован";
        }

        //[HttpPost]
        //public string Appoint(string name, string phone)
        //{
        //    return "Клиент " + name + " с номером " + phone
        //        + " успешно зарегистрирован";
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
