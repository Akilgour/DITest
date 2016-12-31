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
        public static void UpdateAndSave(DITestContext context, object originalObject, object updatedObject, string[] collectionKeys)
        {
            context.Entry(originalObject).CurrentValues.SetValues(updatedObject);
            foreach (var prop in originalObject.GetType().GetProperties())
            {
                context.Entry(originalObject).Property(prop.Name).IsModified = collectionKeys.Contains(prop.Name);
            }
            context.SaveChanges();
        }
    }
}
