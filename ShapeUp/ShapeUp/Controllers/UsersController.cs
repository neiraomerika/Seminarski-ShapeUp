using Microsoft.AspNetCore.Mvc;
using ShapeUp.Interface;
using ShapeUp.Model;
using ShapeUp.Model.Models;
using ShapeUp.Model.Request;
using ShapeUp.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IKlijentService _service;

        public UsersController(IKlijentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<MKlijent>> Get([FromQuery] KlijentSearchObject search)
        {
            return await _service.Get(search);
        }

        [HttpPost]
        public async Task<MKlijent> Insert([FromQuery] KlijentInsertRequest request)
        {
            return await _service.Insert(request);
        }

        [HttpGet("/{Id}")]
        public async Task<MKlijent> GetById(string Id)
        {
            return await _service.GetById(Id);
        }

        [HttpDelete("/{Id}")]
        public async Task<bool> Delete(string Id)
        {
            return await _service.Delete(Id);
        }
    }
}
