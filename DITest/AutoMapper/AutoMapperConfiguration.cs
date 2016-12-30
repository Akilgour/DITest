using AutoMapper;
using DITest.AutoMapper.SaleOrder;
using DITest.DTO.Models;
using DITest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DITest.AutoMapper
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(c => {
                c.CreateMap<SaleOrderDTO, SalesOrder>()
                    .ForMember(dest => dest.FullAddress, opt => opt.MapFrom(src => FullAddress.ResolveCore(src))
                ).ReverseMap();

                c.CreateMap<SaleOrderItemDTO, SalesOrderItem>().ReverseMap();
                c.CreateMap<LargeObjectDTO, LargeObject>().ReverseMap();

            });
        }
    }
}