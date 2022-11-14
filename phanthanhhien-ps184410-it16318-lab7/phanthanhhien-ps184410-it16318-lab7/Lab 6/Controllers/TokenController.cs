using Lab_6.Models;
using Lab_6.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace Lab_6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly ReservationDBContext _context;
        private readonly IUserService _service;
        public TokenController(IConfiguration configuration, ReservationDBContext context, IUserService service)
        {
            _configuration = configuration;
            _context = context;
            _service = service;
        }

        //public async Task<UserInfo> GetUser(string email, string password)
        //{
        //    return await _context.UserInfos.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
        //}
        [HttpPost]
        public async Task<IActionResult> Login([FromForm]UserInfo _userData)
        {
            if(_userData !=null && _userData.Email !=null && _userData.Password != null)
            {
                var user = await _service.GetUser(_userData.Email, _userData.Password);
                if (user != null)
                {
                    var claims = new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Sub,_configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat,DateTime.UtcNow.ToString()),
                        new Claim("Id",user.Id.ToString()),
                        new Claim("FirstName",user.FirstName.ToString()),
                        new Claim("LastName",user.LastName.ToString()),
                        new Claim("UserName",user.UserName.ToString()),
                        new Claim("Email",user.Email.ToString()),
                    };
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(_configuration["Jwt:Issuer"],
                        _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1),
                        signingCredentials: signIn);
                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                     
                }
                else
                {
                    return BadRequest("Invalid Credentials");
                }
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
