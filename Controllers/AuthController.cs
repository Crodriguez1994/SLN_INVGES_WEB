﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SLN_INVGES_WEB.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View("login");
        }
    }
}