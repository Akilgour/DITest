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
    }
}