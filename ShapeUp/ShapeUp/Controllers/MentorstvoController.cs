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
    public class MentorstvoController : BaseCRUDController<MMentorstvo, MentorstvoSearchObject, MentorstvoInsertRequest, MentorstvoUpdateRequest>
    {
        private readonly IMentorstvoService _service;

        public MentorstvoController(IMentorstvoService service):base(service)
        {
            _service = service;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public override async Task<List<MMentorstvo>> Get(MentorstvoSearchObject search)
        {
            return await _service.Get(search);
        }
    }
}
