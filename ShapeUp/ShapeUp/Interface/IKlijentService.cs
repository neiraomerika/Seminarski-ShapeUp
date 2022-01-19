using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShapeUp.Model.Models;
using ShapeUp.Model.Request;
using ShapeUp.Model.SearchObjects;

namespace ShapeUp.Interface
{
    public interface IKlijentService
    {
        Task<List<MKlijent>> Get(KlijentSearchObject search);
        Task<MKlijent> GetById(int Id);
        Task<MKlijent> Update(int Id, KlijentUpdateRequest request);
        Task<bool> Delete(int Id);
    }
}
