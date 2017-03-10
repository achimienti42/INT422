using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppProjectTemplate_v21.Controllers
{
   
        public class EmployeeController : Controller
        {
            // GET: Employee

            private Manager m = new Manager();
            public ActionResult Index()
            {
                var l = m.EmployeeGetAll();
                return View(l);
            }

            // GET: Employee/Details/5
            public ActionResult Details(int id)
            {
                var o = m.EmployeeGetById(id);

                if (o == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(o);
                }
            }

            // GET: Employee/Create
            public ActionResult Create()
            {
                return View(new EmployeeAdd());
            }

            // POST: Employee/Create
            [HttpPost]
            public ActionResult Create(EmployeeAdd newItem)
            {
                if (!ModelState.IsValid)
                {
                    return View(newItem);
                }

                var o = m.EmployeeAdd(newItem);

                if (o == null)
                {
                    return View(o);
                }
                else
                {
                    return RedirectToAction("Details", new { id = o.EmployeeId });
                }
            }

            // GET: Employee/Edit/5
            public ActionResult Edit(int id)
            {
                return View();

            }

            // POST: Customers/Edit/5

            [HttpPost]

            public ActionResult Edit(int? id, FormCollection collection)

            {
                try
                {
                    // TODO: Add delete logic here

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }

            // GET: Employee/Delete/5
            public ActionResult Delete(int id)
            {
                return View();
            }

            // POST: Employee/Delete/5
            [HttpPost]
            public ActionResult Delete(int id, FormCollection collection)
            {
                try
                {
                    // TODO: Add delete logic here

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }

        }
    }
