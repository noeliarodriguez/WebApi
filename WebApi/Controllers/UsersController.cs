using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApi.Context;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        // GET api/users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users_Api.ToListAsync();
        }

        // GET api/users/id
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserId(int Id)
        {
            var user = await _context.Users_Api.FindAsync(Id);
            if (user == null) return NotFound();
            else return user;
        }

        //POST api/users
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _context.Users_Api.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUserId), new { Id = user.Id }, user);
        }
    }
}
