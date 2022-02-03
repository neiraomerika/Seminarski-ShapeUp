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
        Task<MKlijent> GetById(string Id);
        Task<MKlijent> Update(string Id, KlijentUpdateRequest request);
        Task<bool> Delete(string Id);
        Task<MKlijent> Insert(KlijentInsertRequest request);
    }
}
