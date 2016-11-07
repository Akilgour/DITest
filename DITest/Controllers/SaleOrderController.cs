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
            var foo = service.GetAllSaleOrder();
            return View();
        }
    }
}