using DITest.Models;
using System.Web.Mvc;

namespace DITest.Controllers
{
    public class SaleOrderItemController : Controller
    {
        // GET: SaleOrderItem
        public ActionResult Add(int saleOrderId)
        {
            return View("AddSaleOrderItem", new SalesOrderItem() { SaleOrderId = saleOrderId });
        }

        [HttpPost]
        public ActionResult Add(SalesOrderItem model)
        {
            return View("AddSaleOrderItem", model);
        }
    }
}