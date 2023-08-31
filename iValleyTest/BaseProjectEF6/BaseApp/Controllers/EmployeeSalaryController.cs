using System;
using BaseApp.Models;
using BaseApp.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseApp.Controllers
{
    public class EmployeeSalaryController : Controller
    {
        private IRepository<EmployeeSalary> _repository = null;
        public EmployeeSalaryController()
        {
            this._repository = new Repository<EmployeeSalary>();
        }

        public ActionResult Index()
        {
            var employeesalaries = _repository.GetAll();
            return View(employeesalaries);
        }

        public ActionResult CurrentYearSalaries(int id)
        {
            var employeesalaries = _repository.GetAll().Where(b => b.SalaryDate.Year == DateTime.Now.Year).Where(b => b.EmployeeID == id)
                      .ToList();

            return PartialView("SalariesView", employeesalaries);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeSalary employeeSalary)
        {
            if (ModelState.IsValid)
            {
                employeeSalary.CreatedDate = DateTime.Now;
                _repository.Insert(employeeSalary);
                _repository.Save();
                return RedirectToAction("../Employee/Index");
            }
            else
            {
                return View(employeeSalary);
            }
        }


        //public ActionResult Edit(int Id)
        //{
        //    var employee = _repository.GetById(Id);
        //    return View(employee);
        //}

        //[HttpPost]
        //public ActionResult Edit(Employee employee)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _repository.Update(employee);
        //        _repository.Save();
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return View(employee);
        //    }
        //}

       
    }
}