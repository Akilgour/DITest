using AutoMapper;
using DITest.AutoMapper.SaleOrder;
using DITest.DTO;
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
            Mapper.Initialize(cfg => cfg.CreateMap<SaleOrderDTO, SalesOrder>()
            .ForMember(dest => dest.FullAddress, opt => opt.MapFrom(src => FullAddress.ResolveCore( src )))
            );
        }
    }
}