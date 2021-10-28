using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShapeUp.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using ShapeUp.Database.Models;

namespace ShapeUp.Controllers
{
    public class AuthController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<Klijent> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public AuthController(IMapper mapper, 
                              UserManager<Klijent> userManager,
                              RoleManager<IdentityRole> roleManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
        }


        [HttpPost("registration")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([FromBody] UserRegistration model)
        {
            if (model == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            var user = _mapper.Map<Klijent>(model);

            var result = await _userManager.CreateAsync(user, model.Password);
            var role = _roleManager.FindByNameAsync(model.RoleName).Result;


            if (!result.Succeeded)
            {
                var err = result.Errors.Select(e => e.Description);

                return BadRequest(new RegistrationError { Errors = err, RegistrationSuccessful = false });
            }
            
            if (result.Succeeded)
            {
                var roleResult = await _userManager.AddToRoleAsync(user, role.Name);
                var roleError = roleResult.Errors.Select(e => e.Description);

                if (!roleResult.Succeeded)
                    return BadRequest(new RegistrationError { Errors = roleError });


            }

            return null;
        }
    }
}
