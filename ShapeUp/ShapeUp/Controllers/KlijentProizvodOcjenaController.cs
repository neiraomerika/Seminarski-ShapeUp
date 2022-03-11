using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    public class KlijentProizvodOcjenaController : BaseCRUDController<MKlijentProizvodOcjena, KlijentProizvodOcjenaSearch, KlijentProzivodOcjenaInsert, KlijentProizvodOcjenaUpdate>
    {
        private readonly IKlijentProizvodOcjenaService _service;

        public KlijentProizvodOcjenaController(IKlijentProizvodOcjenaService service) : base(service)
        {
            _service = service;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public override async Task<MKlijentProizvodOcjena> Insert(KlijentProzivodOcjenaInsert request)
        {
            return await _service.Insert(request);
        }
    }
}
