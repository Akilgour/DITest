using DITtest.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DITest.DTO.Models;
using DITest.Repository.Context;
using System.Data.Entity.Migrations;

namespace DITtest.Service.Services
{
    public class LargeObjectService : ILargeObjectService
    {
        private readonly DITestContext context;

        public LargeObjectService(DITestContext context)
        {
            this.context = context;
        }

        public IEnumerable<LargeObjectDTO> GetAll()
        {
            return context.LargeObject.ToList();
        }

        public void Save(LargeObjectDTO largeObjectDTO)
        {
            context.Set<LargeObjectDTO>().AddOrUpdate(largeObjectDTO);
            context.SaveChanges();
        }
    }
}
