﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment5.Controllers
{
    public class TrackController : Controller
    {
        private Manager m = new Manager();
        // GET: Track
        public ActionResult Index()
        {
            var r = m.TrackGetAll();

            return View(r);
        }

        // GET: Track/Details/5
        public ActionResult Details(int id)
        {
            var r = m.TrackGetByIdWithDetail(id);

            if (r == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(r);
            }
        }

        // GET: Track/Create
        public ActionResult Create()
        {
            var form = new TrackAddForm();
            form.AlbumList = new SelectList(m.AlbumGetAll(), "AlbumId", "Title");
            form.MediaTypeList = new SelectList(m.MediaTypeGetAll(),"MediaTypeId", "Name");

            return View(form);
        }

        // POST: Track/Create
        [HttpPost]
        public ActionResult Create(TrackAdd collection)
        {
            if (!ModelState.IsValid)
            {
                return View(collection);
            }

            var o = m.TrackAdd(collection);

            if ( o == null)
            {
                return View(o);
            }
            else
            {
                return RedirectToAction("Details", new { id = o.TrackId});
            }
        }

        // GET: Track/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Track/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Track/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Track/Delete/5
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
