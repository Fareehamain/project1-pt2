using project1_pt2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project1_pt2.Controllers
{
    public class CRUDController : Controller
    {
        public ActionResult create()
        {
            return View();
        }

        //Create
        [HttpPost]
        public ActionResult create(Employee model)
        {
            using(var context = new EmployeesEntities())
            {
                context.Employees.Add(model);

                context.SaveChanges();
            }
            string message = "Created the record succesfully";

            ViewBag.Message = message;

            return View();
        }

        //Read
        [HttpGet] 
        public ActionResult
            Read()
        {
            using (var context = new EmployeesEntities())
            {

                
                var data = context.Employees.ToList();
                return View(data);
            }
        }

        //Update 
        public ActionResult Update(int Employeeid)
        {
            using(var context = new EmployeesEntities())
            {
                var data = context.Employees.Where(x => x.EmployeeID == Employeeid).SingleOrDefault();
                return View(data);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int Employeeid, Employee model)
        {
            using(var context = new EmployeesEntities())
            {
                var data = context.Employees.FirstOrDefault(x => x.EmployeeID == Employeeid);

                if (data != null)
                {
                    data.first_name = model.first_name;
                    data.last_name = model.last_name;
                    context.Employees.Remove(data);

                    return RedirectToAction("Read");
                }
                else
                {
                    return View();
                }
            }
        }
    }
}