using AutoMapper;
using DITest.DTO.Models;
using DITest.Models;
using DITest.Service.Services.Interfaces;
using DITtest.Service.Services.Interfaces;
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
        private readonly ISalesOrderItemService salesOrderItemService;

        log4net.ILog logger = log4net.LogManager.GetLogger(typeof(SaleOrderController));  //Declaring Log4Net

        public SaleOrderController(ISalesOrderService service, ISalesOrderItemService salesOrderItemService)
        {
            this.service = service;
            this.salesOrderItemService = salesOrderItemService;
        }

        // GET: SaleOrder
        public ActionResult Index()
        {
            logger.Error("boo");
            return View(Mapper.Map<IEnumerable<SaleOrderDTO>, IEnumerable<SalesOrder>>(service.GetAllSaleOrder()));
        }

        // GET: SaleOrder
        public ActionResult IndexDiv()
        {
            logger.Error("boo");
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

        public ActionResult AddSaleOrderItem(int saleOrderId)
        {
            return base.PartialView("_AddSaleOrderItem", new SalesOrderItem() { SaleOrderId = saleOrderId });
        }

        [HttpPost]
        public ActionResult AddSaleOrderItem(SalesOrderItem SalesOrderItem)
        {
            salesOrderItemService.Save(Mapper.Map<SalesOrderItem, SaleOrderItemDTO>(SalesOrderItem));
            return RedirectToAction("Index");
        }


        public ActionResult ShowItemList(int saleOrderId)
        {

            var list = Mapper.Map<IEnumerable<SaleOrderItemDTO>, IEnumerable<SalesOrderItem>>(salesOrderItemService.GetBySaleOrderId(saleOrderId));
            return PartialView("_SaleOrderItems", list);
        }

        public ActionResult SaveData(SalesOrderItem d)
        {

            if (ModelState.IsValid)
            {
                salesOrderItemService.Save(Mapper.Map<SalesOrderItem, SaleOrderItemDTO>(d));
                return Json(new { success = true });

            }
            else
            {
                return base.PartialView("_AddSaleOrderItem", d);
                // return Json(new { success = false });
            }
        }
    }
}