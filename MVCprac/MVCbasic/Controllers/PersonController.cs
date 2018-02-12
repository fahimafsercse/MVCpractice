using MVCbasic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCbasic.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person

        List<PersonEmployees> personList = new List<PersonEmployees>() {
            new PersonEmployees(){Id=1,Name="Bob",Salary=33000},
            new PersonEmployees(){Id=2,Name="Sara",Salary=30000},
            new PersonEmployees(){Id=3,Name="Alice",Salary=40000},
        };
        public ActionResult Index()
        {
            return View(this.personList);
        }
    }
}