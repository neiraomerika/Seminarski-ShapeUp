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
    public class NapredakController : BaseCRUDController<MNapredak, NapredakSearchObject, NapredakInsertRequest, NapredakUpdateRequest>
    {
        private readonly INapredakService _service;

        public NapredakController(INapredakService service):base(service)
        {
            _service = service;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public override async Task<List<MNapredak>> Get(NapredakSearchObject search)
        {
            return await _service.Get(search);
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public override async Task<MNapredak> Insert(NapredakInsertRequest request)
        {
            return await _service.Insert(request);
        }
    }
}
