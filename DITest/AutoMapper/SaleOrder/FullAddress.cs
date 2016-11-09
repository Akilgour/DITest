using AutoMapper;
using DITest.DTO.Models;

namespace DITest.AutoMapper.SaleOrder
{
    public static class FullAddress //: ValueResolver<SalesOrder, string>
    {
        // protected override string ResolveCore(SalesOrder source)
        public static string ResolveCore(SaleOrderDTO source)
        {
            return $"{source.FullName } lives at {source.AddressLineOne} {source.AddressLineTwo}";
        }
    }
}