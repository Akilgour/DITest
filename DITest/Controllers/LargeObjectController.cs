using AutoMapper;
using DITest.DTO.Models;
using DITest.Models;
using DITtest.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DITest.Controllers
{
    public class LargeObjectController : Controller
    {
        private readonly ILargeObjectService largeObjectService;

        public LargeObjectController(ILargeObjectService largeObjectService)
        {
            this.largeObjectService = largeObjectService;
        }


        // GET: LargeObject
        public ActionResult Index()
        {
            return View(Mapper.Map<IEnumerable<LargeObjectDTO>, IEnumerable<LargeObject>>(largeObjectService.GetAll()));
        }

        // GET: LargeObject/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LargeObject/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LargeObject/Create
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

        // GET: LargeObject/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LargeObject/Edit/5
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

        // GET: LargeObject/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LargeObject/Delete/5
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
