using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Repository.Entities;
using Repository.Helpers;
using Repository.Implementations.Service;
using Repository.Interfaces.Repositories;
using Repository.Interfaces.Service;
using Repository.ViewModel;

namespace WebApplication.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private IServiceUser _userService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public UsersController(
            IServiceUser userService,
            IMapper mapper,
            IOptions<AppSettings> appSettings)
        {
            _userService = userService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]UserView userView)
        {
            var user = _userService.RepositoryUser.Authenticate(userView.Username, userView.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            // return basic user info (without password) and token to store client side
            return Ok(new
            {
                Id = user.Id,
                Username = user.Username,
                Token = tokenString
            });
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody]UserView userView)
        {
            // map dto to entity
            var user = _mapper.Map<User>(userView);

            try
            {
                // save 
                _userService.RepositoryUser.Create(user, userView.Password);
                _userService.Commit();
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.RepositoryUser.GetAll();
            var userViews = _mapper.Map<IList<UserView>>(users);
            return Ok(userViews);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.RepositoryUser.GetById(id);
            var userView = _mapper.Map<UserView>(user);
            return Ok(userView);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody]UserView userView)
        {
            // map dto to entity and set id
            var user = _mapper.Map<User>(userView);
            user.Id = id;

            try
            {
                // save 
                _userService.RepositoryUser.Update(user, userView.Password);
                _userService.Commit();
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userService.RepositoryUser.Delete(id);
            _userService.Commit();
            return Ok();
        }
    }
}