using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Interface
{
    public interface ICRUDService<T, TSearch, TInsert, TUpdate> : IBaseService<T, TSearch> where T:class where TSearch:class where TInsert:class where TUpdate:class
    {
        Task<T> Insert(TInsert request);
        Task<T> Update(int ID, TUpdate request);
        Task<bool> Delete(int ID);
       
    }
}
