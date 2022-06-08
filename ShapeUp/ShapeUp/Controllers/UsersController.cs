using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShapeUp.Interface;
using ShapeUp.Model;
using ShapeUp.Model.Dto;
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
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<MKlijent> Insert([FromBody] KlijentInsertRequest request)
        {
            return await _service.Insert(request);
        }

        [HttpGet("{Id}")]
        public async Task<MKlijent> GetById(string Id)
        {
            return await _service.GetById(Id);
        }

        [HttpDelete("{Id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<bool> Delete(string Id)
        {
            return await _service.Delete(Id);
        }

        [HttpGet("profile-info")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<MKlijent> GetProfileInfo()
        {
            return await _service.GetProfileInfo();
        }

        [HttpPost("profile-picture")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<string> PostProfilePicture(UserImageUpload img)
        {
            return await _service.PostProfilePicture(img);
        }
    }
}
