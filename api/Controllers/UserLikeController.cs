using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserLikeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserLikeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("like")]
        public async Task<IActionResult> LikeBook(UserLikeDto likeDto)
        {
            var user = await _context.Users.FindAsync(likeDto.UserId);

            if (user == null)
            {
                return NotFound("User not Found");
            }

            if (user.LikedBookIds.Contains(likeDto.BookId))
            {
                return BadRequest("You have already liked this book.");
            }

            user.LikedBookIds.Add(likeDto.BookId);

            await _context.SaveChangesAsync();

            return Ok("Successfully liked the book.");
        }
    }
}