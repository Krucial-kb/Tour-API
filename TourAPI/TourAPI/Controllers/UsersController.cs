using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Tour.Domain.Interfaces;
using TourAPI.Models;

namespace TourAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository _repo;
        private readonly ILogger<UsersController> _logger;

        public UsersController(IUsersRepository Repo ,ILogger<UsersController> Logger)
        {
            _repo = Repo;
            _logger = Logger;
        }

        // GET: api/Users
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ApiModels.ApiUsers>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Users>>> GetUsersAsync()
        {
            IEnumerable<Tour.Domain.DomainModels.Users> users = await _repo.GetUsersAsync();

            IEnumerable<ApiModels.ApiUsers> result = users.Select(u => new ApiModels.ApiUsers
            { 
                UserId = u.UserId,
                FirstName = u.FirstName,
                LastName = u.LastName,
                UserName = u.UserName,
                Email = u.Email,
                Password = u.Password,
                Posts = u.Posts,
                ProfilePic = u.ProfilePic
            });

            return Ok(result);
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ApiModels.ApiUsers), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Users>> GetUsers(int id)
        {
            Tour.Domain.DomainModels.Users users = await _repo.GetUserByIdAsync(id);

            var result = new ApiModels.ApiUsers
            {
                UserId = users.UserId,
                FirstName = users.FirstName,
                LastName = users.LastName,
                UserName = users.UserName,
                Email = users.Email,
                Password = users.Password,
                Posts = users.Posts,
                ProfilePic = users.ProfilePic
            };

            if (users == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsers(int id, Tour.Domain.DomainModels.Users users)
        {
            if (id != users.UserId)
            {
                return BadRequest();
            }

            var result = new Tour.Domain.DomainModels.Users
            {
                UserId = users.UserId,
                FirstName = users.FirstName,
                LastName = users.LastName,
                UserName = users.UserName,
                Email = users.Email,
                Password = users.Password,
                Posts = users.Posts,
                ProfilePic = users.ProfilePic
            };

            _repo.Changed(result);

            try
            {
                await _repo.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (! (await UsersExists(id)))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Users
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult> PostUsers(Tour.Domain.DomainModels.Users users)
        {
            Tour.Domain.DomainModels.Users create = await _repo.CreateUserAsync(users);

            var result = new ApiModels.ApiUsers
            {
                UserId = users.UserId,
                FirstName = users.FirstName,
                LastName = users.LastName,
                UserName = users.UserName,
                Email = users.Email,
                Password = users.Password,
                Posts = users.Posts,
                ProfilePic = users.ProfilePic
            };

            return Ok(result);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public ActionResult DeleteUsers(int id)
        {
            var result = _repo.DeleteUserAsync(id);
            return Ok(result);
        }
        [HttpGet("{id}")]
        private Task<bool> UsersExists(int id)
        {
            return _repo.UserExistsAsync(id);
        }
    }
}
