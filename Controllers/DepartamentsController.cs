using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();

            list.Add(new Departamento { Id = 1, Name = "Eletronics" });
            list.Add(new Departamento { Id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}
