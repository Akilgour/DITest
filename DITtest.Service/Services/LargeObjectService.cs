using DITest.DTO.Models;
using DITest.Repository.Context;
using DITtest.Service.Helpers;
using DITtest.Service.Services.Interfaces;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

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

        public LargeObjectDTO GetById(int id)
        {
            return context.LargeObject.Single(x => x.LargeObjectId == id);
        }

        public void Save(LargeObjectDTO largeObjectDTO)
        {
            context.Set<LargeObjectDTO>().AddOrUpdate(largeObjectDTO);
            context.SaveChanges();
        }

        public void Update(LargeObjectDTO largeObjectDTO, string[] updateFields)
        {
            var origanalObject = context.LargeObject.Single(x => x.LargeObjectId == largeObjectDTO.LargeObjectId);
            EFHelpers.UpdateAndSave(context, origanalObject, largeObjectDTO, updateFields);
        }
    }
}