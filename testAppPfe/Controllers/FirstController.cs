﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testAppPfe.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
     

        public IEnumerable<string> Create()
        {
            string[] Numbers = new[]
        {
           "1","2","3"
        };
            return Numbers;
        }
        public ActionResult Index()
        {
            return View();
        }
        
        // GET: First/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: First/Create
       

        // POST: First/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: First/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: First/Edit/5
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

        // GET: First/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: First/Delete/5
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
