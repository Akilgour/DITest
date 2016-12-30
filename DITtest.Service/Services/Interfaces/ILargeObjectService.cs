using DITest.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITtest.Service.Services.Interfaces
{
    public interface ILargeObjectService
    {
        IEnumerable<LargeObjectDTO> GetAll();
        void Save(LargeObjectDTO largeObjectDTO);
        LargeObjectDTO GetById(int id);
        void SaveFirstHalf(LargeObjectDTO largeObjectDTO , string[] collectionKeys);
    }
}
