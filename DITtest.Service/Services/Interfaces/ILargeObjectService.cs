using DITest.DTO.Models;
using System.Collections.Generic;

namespace DITtest.Service.Services.Interfaces
{
    public interface ILargeObjectService
    {
        IEnumerable<LargeObjectDTO> GetAll();

        void Save(LargeObjectDTO largeObjectDTO);

        LargeObjectDTO GetById(int id);

        void Update(LargeObjectDTO largeObjectDTO, string[] updateFields);
    }
}