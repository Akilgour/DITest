using DITest.DTO.Models;
using System.Collections.Generic;

namespace DITtest.Service.Services.Interfaces
{
    public interface ISalesOrderItemService
    {
        SaleOrderItemDTO Save(SaleOrderItemDTO SaleOrderItemDTO);

        IEnumerable<SaleOrderItemDTO> GetBySaleOrderId(int saleOrderId);
    }
}