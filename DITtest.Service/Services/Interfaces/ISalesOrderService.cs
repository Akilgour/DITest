using DITest.DTO.Models;
using System.Collections.Generic;

namespace DITest.Service.Services.Interfaces
{
    public interface ISalesOrderService
    {
        IEnumerable<SaleOrderDTO> GetAllSaleOrder();
        SaleOrderDTO GetSaleOrderById(int saleOrderId);
    }
}