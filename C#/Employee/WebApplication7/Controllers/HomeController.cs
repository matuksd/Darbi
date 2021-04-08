using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;
using DataLibrary;
using DataLibrary.BussinesLogic;
namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ViewEmployees()
        {
            ViewBag.Message = "Employee list";

             var data = EmployeeProcessor.LoadEmployees();
             List<EmployeeModel> employees = new List<EmployeeModel>();

             foreach(var row in data)
             {
             employees.Add(new EmployeeModel
                {
                   EmpleyeeId = row.EmployeeId,
                   FirstName = row.FirstName,
                   LastName = row.LastName,
                   EmailAdress = row.EmailAddress
                 });
             }
                        
            return View(employees);
        }

        public ActionResult SignUp()
        {
            ViewBag.Message = "Employee Sign Up.";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(EmployeeModel model)
        {
            if(ModelState.IsValid)
            {
                EmployeeProcessor.CreateEmployee(model.EmpleyeeId,
                    model.FirstName,
                    model.LastName,
                    model.EmailAdress);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}