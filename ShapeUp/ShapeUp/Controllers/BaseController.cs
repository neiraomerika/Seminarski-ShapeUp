using Microsoft.AspNetCore.Mvc;
using ShapeUp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class BaseController <T,TSearch> :ControllerBase where T:class where TSearch:class
    {
        private readonly IBaseService<T, TSearch> _service;

        public BaseController(IBaseService<T, TSearch> service)
        {
            _service = service;
        }
        [HttpGet]
        public virtual async Task<List<T>> Get([FromQuery] TSearch search)
        {
            return await _service.Get(search);
        }
       
        [HttpGet("{Id}")]
        public async Task<T>GetById(int Id)
        {
            return await _service.GetById(Id);
        }

    }
}
