using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departments> list= new List<Departments>();
            list.Add(new Departments { Id = 1, Name = "Eletrônicos" });
            list.Add(new Departments { Id = 2, Name = "Vestuário" });

            return View(list);
        }
    }
}