using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Interface
{
   public interface IBaseService<T,TSearch> where T:class where TSearch:class
    {
        Task<List<T>> Get(TSearch search);
        Task<T> GetById(int ID);
    }
}
