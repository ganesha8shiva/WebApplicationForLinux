﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WebApplicationForLinux.Models;

namespace WebApplicationForLinux.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _Configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            
            _logger = logger;
            _Configuration = configuration;
        }

        public IActionResult Index()
        {
            System.Diagnostics.Trace.TraceInformation("Index:" + DateTime.Now.ToString());

            return  Content("here more change" + _Configuration["key"]);
        }

        public IActionResult Privacy()
        {
            System.Diagnostics.Trace.TraceInformation("Privacy:" + DateTime.Now.ToString());
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
