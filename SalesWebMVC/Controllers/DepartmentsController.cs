﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List < Department > list = new List<Department>();
            list.Add(new Department { ID = 1, Name = "eletronicos" });
            list.Add(new Department { ID = 2, Name = "escritório" });

            return View(list);
        }
    }
}
