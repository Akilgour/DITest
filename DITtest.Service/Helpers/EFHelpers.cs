using DITest.DTO.Models;
using DITest.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITtest.Service.Helpers
{
    public static class EFHelpers
    {
        //public static void UpdateAndSave(DITestContext context, object origanalObject, object changedObject, string[] collectionKeys)
        //{
        //    context.Entry(origanalObject).CurrentValues.SetValues(changedObject);
        //    // context.Set<LargeObjectDTO>().Attach((LargeObjectDTO)origanalObject);
        //    //context.Set<LargeObjectDTO>().Add((LargeObjectDTO)origanalObject);
        //    context.Entry(origanalObject).CurrentValues.SetValues(changedObject);
        //    foreach (var prop in origanalObject.GetType().GetProperties())
        //    {
        //        context.Entry(origanalObject).Property(prop.Name).IsModified = collectionKeys.Contains(prop.Name);
        //    }
        //    context.SaveChanges();
        //}

        public static void NewMethod(DITestContext context, LargeObjectDTO largeObjectDTO, string[] collectionKeys, LargeObjectDTO oldobj)
        {
            context.Entry(oldobj).CurrentValues.SetValues(largeObjectDTO);
            foreach (var prop in oldobj.GetType().GetProperties())
            {
                context.Entry(oldobj).Property(prop.Name).IsModified = collectionKeys.Contains(prop.Name);
            }
            context.SaveChanges();
        }
    }
}
