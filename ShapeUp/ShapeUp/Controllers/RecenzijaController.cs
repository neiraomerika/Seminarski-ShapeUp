using ShapeUp.Interface;
using ShapeUp.Model.Models;
using ShapeUp.Model.Request;
using ShapeUp.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Controllers
{
    public class RecenzijaController : BaseCRUDController<MRecenzija, RecenzijaSearchObject, RecenzijaInsertRequest, RecenzijaUpdateRequest>
    {
        private readonly IRecenzijaService _service;

        public RecenzijaController(IRecenzijaService service) : base(service)
        {
            _service = service;
        }

        public override async Task<List<MRecenzija>> Get(RecenzijaSearchObject search)
        {
            return await _service.Get(search);
        }
    }
}
