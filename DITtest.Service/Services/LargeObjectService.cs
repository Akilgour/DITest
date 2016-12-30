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

        public LargeObjectDTO GetById(int id)
        {
            return context.LargeObject.Single(x => x.LargeObjectId == id);
        }

        public void Save(LargeObjectDTO largeObjectDTO)
        {
            context.Set<LargeObjectDTO>().AddOrUpdate(largeObjectDTO);
            context.SaveChanges();
        }

        public void SaveFirstHalf(LargeObjectDTO largeObjectDTO, string[] collectionKeys)
        {
            //using (var newContext = new DITestContext())
            //{
            //    newContext.LargeObject.Attach(largeObjectDTO);
            //    newContext.Entry(largeObjectDTO).Property(X => X.PropertyOne).IsModified = true;
            //    newContext.Entry(largeObjectDTO).Property(X => X.PropertyTwo).IsModified = true;
            //    newContext.SaveChanges();
            //}

            var oldobj = context.LargeObject.Single(x => x.LargeObjectId == largeObjectDTO.LargeObjectId);
            context.Entry(oldobj).CurrentValues.SetValues(largeObjectDTO);


            foreach (var prop in oldobj.GetType().GetProperties())
            {
                context.Entry(oldobj).Property(prop.Name).IsModified = collectionKeys.Contains(prop.Name);
            }

            // context.Entry(oldobj).Property(u => u.PropertyTwo).IsModified = true;

            // works context.Entry(oldobj).Property(u => u.PropertyTwo).IsModified = false;


            context.SaveChanges();

            //var entry = context.Entry(largeObjectDTO);
            //// Attach user entity and set all properties as modified
            //entry.State = EntityState.Modified;

            //// Reset modified state on just two properties
            //entry.Property(u => u.PropertyOne).IsModified = false;
            //entry.Property(u => u.PropertyTwo).IsModified = false;

            //// Values for ProfilePicture and MemberSince will not be
            //// included in UPDATE statement sent to database
            //context.SaveChanges();


            //var dbEntityEntry = context.Entry(largeObjectDTO);
            //foreach (var property in dbEntityEntry.OriginalValues.PropertyNames)
            //{
            //    var original = dbEntityEntry.OriginalValues.GetValue<object>(property);
            //    var current = dbEntityEntry.CurrentValues.GetValue<object>(property);
            //    if (original != null && !original.Equals(current))
            //        dbEntityEntry.Property(property).IsModified = true;
            //}

            //context.Entry(largeObjectDTO).State = EntityState.Modified;
            //context.Entry(largeObjectDTO).Property(x => x.PropertyTwo).IsModified = false;
            //context.SaveChanges();

            //using (context)
            //{

            //    context.LargeObject.Attach(largeObjectDTO);

            //}
            //       var entry = context.Entry(largeObjectDTO);
            //  entry.State = EntityState.Modified;
            //foreach (var name in excluded)
            //{
            //    entry.Property(name).IsModified = false;
            //}

            //entry.Property("PropertyOne").IsModified = false;
            //entry.Property("PropertyTwo").IsModified = false;

            //  context.Set<LargeObjectDTO>().Attach(largeObjectDTO);
            ////  context.Set<LargeObjectDTO>().AddOrUpdate(largeObjectDTO);
            //  context.Entry(largeObjectDTO).Property(X => X.PropertyOne).IsModified = true;
            //  context.Entry(largeObjectDTO).Property(X => X.PropertyTwo).IsModified = true;
            //  context.Entry(largeObjectDTO).Property(X => X.PropertyThree).IsModified = true;
            //  context.Entry(largeObjectDTO).Property(X => X.PropertyFour).IsModified = true;
            //  context.Entry(largeObjectDTO).Property(X => X.PropertyFive).IsModified = true;
            //  context.SaveChanges();


        }
    }
}
