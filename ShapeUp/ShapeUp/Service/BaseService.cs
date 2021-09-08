using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShapeUp.Database;
using ShapeUp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Service
{
    public class BaseService<TModel, TSearch, TDatabase>:IBaseService<TModel,TSearch> where TModel:class where TSearch:class where TDatabase :class
    {
        protected ShapeUpDBContext _context;
        protected IMapper _mapper;

        public BaseService(ShapeUpDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public virtual async Task<List<TModel>> Get(TSearch search)
        {
            var list = await _context.Set<TDatabase>().ToListAsync();
            return _mapper.Map<List<TModel>>(list);
        }
        public virtual async Task<TModel> GetById(int ID)
        {
            var entity = await _context.Set<TDatabase>().FindAsync(ID);
            return _mapper.Map<TModel>(entity);
        }
    }
}
