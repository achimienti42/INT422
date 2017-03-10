using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment3.Controllers
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
            return View(new EmployeeEdit());
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(EmployeeEdit newItem)
        {
           
                return RedirectToAction("Details");
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            // Attempt to fetch the matching object
            var o = m.EmployeeGetById(id);

            if (o == null)
            {
                return HttpNotFound();
            }
            else
            {
                // Create and configure an "edit form"

                // Notice that o is a CustomerBase object
                // We must map it to a CustomerEditContactInfoForm object
                // Notice that we can use AutoMapper anywhere, 
                // and not just in the Manager class!
                var editForm = AutoMapper.Mapper.Map<EmployeeBase, EmployeeEditForm>(o);

                return View(editForm);

            }
        }

        // POST: Customers/Edit/5

        [HttpPost]

        public ActionResult Edit(int id, EmployeeEdit collection)
        { 
          // Validate the input
            if (!ModelState.IsValid)
            {
                // Our "version 1" approach is to display the "edit form" again
                return RedirectToAction("edit", new { id = collection.EmployeeId });
            }

            if (id != collection.EmployeeId)
            {
                // This appears to be data tampering, so redirect the user away
                return RedirectToAction("index");
            }

            // Attempt to do the update
            var editedItem = m.EmployeeEdit(collection);

            if (editedItem == null)
            {
                // There was a problem updating the object
                // Our "version 1" approach is to display the "edit form" again
                return RedirectToAction("edit", new { id = collection.EmployeeId });
            }
            else
            {
                // Show the details view, which will have the updated data
                return RedirectToAction("Index");
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
