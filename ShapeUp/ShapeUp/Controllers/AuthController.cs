using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShapeUp.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using ShapeUp.Database.Models;
using System.IdentityModel.Tokens.Jwt;

namespace ShapeUp.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<Klijent> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly JwtHandler _jwtHandler;


        public AuthController(IMapper mapper, 
                              UserManager<Klijent> userManager,
                              RoleManager<IdentityRole> roleManager,
                              JwtHandler jwtHandler)
        {
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _jwtHandler = jwtHandler;
        }


        [HttpPost("registration")]
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

                return StatusCode(201);
            }

            return null;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLogin model)
        {
            var user = await _userManager.FindByNameAsync(model.Email);

            if (user == null || !await _userManager.CheckPasswordAsync(user, model.Password))
                return Unauthorized(new LoginResponse { ErrorMessage = "Sorry we couldn\'t log you in. Try different email or password" });

            if (!await _userManager.IsEmailConfirmedAsync(user))
                return Unauthorized(new LoginResponse { ErrorMessage = "Email is not confirmed" });

            var signingCredentials = _jwtHandler.GetSigningCredentials();
            var claims = await _jwtHandler.GetClaims(user);
            var tokenOptions = _jwtHandler.GenerateTokenOptions(signingCredentials, claims);
            var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            return Ok(new LoginResponse { IsAuthSuccessful = true, Token = token });

        }
    }
}
