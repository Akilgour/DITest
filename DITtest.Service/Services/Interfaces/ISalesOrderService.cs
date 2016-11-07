using DITest.DTO;
using System.Collections.Generic;

namespace DITest.Service.Services.Interfaces
{
    public interface ISalesOrderService
    {
        IEnumerable<SaleOrderDTO> GetAllSaleOrder();
    }
}