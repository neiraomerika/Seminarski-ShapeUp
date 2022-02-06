﻿using Microsoft.AspNetCore.Mvc; 
using ShapeUp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseCRUDController<T, TSearch, TInsert, TUpdate> : BaseController<T,TSearch> where T:class where TSearch:class where TInsert:class where TUpdate:class
    {
        private readonly ICRUDService<T, TSearch, TInsert, TUpdate> _service;

        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) :base(service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<T>Insert(TInsert request)
        {
            return await _service.Insert(request);
        }

        [HttpPut("{ID}")]
        public async Task<T>Update(int ID,TUpdate request)
        {
            return await _service.Update(ID, request);
        }
        [HttpDelete("{ID}")]
        public async Task<bool>Delete(int ID)
        {
            return await _service.Delete(ID);
        }
    }
}
