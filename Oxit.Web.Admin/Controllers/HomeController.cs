﻿using Microsoft.AspNetCore.Mvc;
using Oxit.Web.Admin.Models;
using System.Diagnostics;

namespace Oxit.Web.Admin.Controllers
{
    public class HomeController : Controller
    {
 
        public HomeController()
        {
         
        }

        public IActionResult Index()
        {
            return View();
        }

    
    }
}