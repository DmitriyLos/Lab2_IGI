﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class OwnerController : Controller
    {
        public IActionResult Index()
        {
            return Content("<html></html>"); ;
        }
    }
}