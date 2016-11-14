using AutoMapper;
using DITest.DTO.Models;
using DITest.Models;
using DITest.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DITest.Controllers
{
    public class SaleOrderController : Controller
    {
        private readonly ISalesOrderService service;

        public SaleOrderController(ISalesOrderService service)
        {
            this.service = service;
        }

        // GET: SaleOrder
        public ActionResult Index()
        {
            return View(Mapper.Map<IEnumerable<SaleOrderDTO>, IEnumerable<SalesOrder>>(service.GetAllSaleOrder()));
        }

        public ActionResult Edit(int saleOrderId)
        {
            return View(Mapper.Map<SaleOrderDTO, SalesOrder>(service.GetSaleOrderById(saleOrderId)));
        }

        public ActionResult Create()
        {
            return View(new SalesOrder());
        }

        [HttpPost]
        public ActionResult Create(SalesOrder salesOrder)
        {
            service.Save(Mapper.Map<SalesOrder, SaleOrderDTO>(salesOrder));
            return RedirectToAction("Index");
        }

        public ActionResult CreateDialog()
        {
            return base.PartialView("_CreateDialog", new SalesOrder());
        }

        [HttpPost]
        public ActionResult CreateDialog(SalesOrder salesOrder)
        {
            service.Save(Mapper.Map<SalesOrder, SaleOrderDTO>(salesOrder));
            return RedirectToAction("Index");
        }

        public ActionResult EditAddress(int saleOrderId)
        {
            return base.PartialView("_EditAddress", Mapper.Map<SaleOrderDTO, SalesOrder>(service.GetSaleOrderById(saleOrderId)));
        }

        [HttpPost]
        public ActionResult EditAddress(SalesOrder salesOrder)
        {
            service.Save(Mapper.Map<SalesOrder, SaleOrderDTO>(salesOrder));
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int saleOrderId)
        {
            service.Delete(saleOrderId);
            return RedirectToAction("Index");
        }

        public ActionResult RemoveSaleOrder(int saleOrderId, string fullName)
        {
            return PartialView("_RemoveSaleOrder", new SalesOrder() { SaleOrderId = saleOrderId, FullName = fullName });
        }

        [HttpPost]
        public ActionResult RemoveSaleOrder(SalesOrder salesOrder)
        {
            service.Delete(salesOrder.SaleOrderId);
            return RedirectToAction("Index");
        }

    }
}