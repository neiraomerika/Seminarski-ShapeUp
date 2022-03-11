using Microsoft.AspNetCore.Mvc;
using ShapeUp.Database;
using ShapeUp.Interface;
using ShapeUp.Model;
using ShapeUp.Model.Models;
using ShapeUp.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Controllers
{
    public class ProizvodiController : BaseCRUDController<MProizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>
    {
        private readonly IProizvodiService _service;
        public ProizvodiController(IProizvodiService service) : base (service)
        {
            _service = service;
        }

        public override async Task<List<MProizvodi>> Get(ProizvodiSearchObject search)
        {
            return await _service.Get(search);
        }

    }
}
