﻿using AutoMapper;
using ShapeUp.Database;
using ShapeUp.Interface;
using ShapeUp.Model;
using ShapeUp.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Service
{
    public class BaseCRUDService<TModel, TSearch, TDatabase, TInsert, TUpdate> :BaseService<TModel,TSearch,TDatabase>,ICRUDService<TModel,TSearch,TInsert,TUpdate> where TModel:class where TSearch:class where TInsert:class where TUpdate:class where TDatabase : class
    {
        private readonly ShapeUpDBContext _context;
        private readonly IMapper _mapper;

        public BaseCRUDService(ShapeUpDBContext context, IMapper mapper) :base(context,mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual async Task<bool> Delete(int ID)
        {
            var entity = _context.Set<TDatabase>().Find(ID);
            try
            {
                _context.Set<TDatabase>().Remove(entity);
                await _context.SaveChangesAsync();
                return true;

            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public virtual Task<List<MProizvodi>> Get(ProizvodiSearchObject search = null)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<TModel> Insert(TInsert request)
        {
            var entity = _mapper.Map<TDatabase>(request);
            _context.Set<TDatabase>().Add(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<TModel>(entity);
        }

        public virtual async Task<TModel> Update(int ID, TUpdate request)
        {
            var entity = _context.Set<TDatabase>().Find(ID);
            _context.Set<TDatabase>().Attach(entity);
            _context.Set<TDatabase>().Update(entity);

            _mapper.Map(request, entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<TModel>(entity);
        }
    }
}
