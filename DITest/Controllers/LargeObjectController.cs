using AutoMapper;
using DITest.DTO.Models;
using DITest.Models;
using DITest.ViewModel;
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
            return View(new LargeObject());
        }

        // POST: LargeObject/Create
        [HttpPost]
        public ActionResult Create(LargeObject largeObject)
        {
            largeObjectService.Save(Mapper.Map<LargeObject, LargeObjectDTO>(largeObject));
            return RedirectToAction("Index");
        }

        // GET: LargeObject/Edit/5
        public ActionResult EditFirstHalfLargeObject(int id)
        {
            return View(Mapper.Map< LargeObjectDTO , FirstHalfLargeObject > (largeObjectService.GetById(id)));
        }

        // POST: LargeObject/Edit/5
        [HttpPost]
        public ActionResult EditFirstHalfLargeObject(FirstHalfLargeObject largeObject, FormCollection collection)
        {

            var collectionKeys = collection.AllKeys;

            largeObjectService.Update(Mapper.Map<FirstHalfLargeObject, LargeObjectDTO>(largeObject), collectionKeys);
            return RedirectToAction("Index");
        }

        public ActionResult EditSecondHalfLargeObject(int id)
        {
            return View(Mapper.Map<LargeObjectDTO, SecondHalfLargeObject>(largeObjectService.GetById(id)));
        }

        // POST: LargeObject/Edit/5
        [HttpPost]
        public ActionResult EditSecondHalfLargeObject(SecondHalfLargeObject secondHalfLargeObject, FormCollection collection)
        {
            largeObjectService.Update(Mapper.Map<SecondHalfLargeObject, LargeObjectDTO>(secondHalfLargeObject), collection.AllKeys);
            return RedirectToAction("Index");
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
