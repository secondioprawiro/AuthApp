using AuthBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuthBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] AuthRequest request)
        {
            var isUserExist = await _context.Users.AnyAsync(u => u.Username == request.Username);
            
            if (isUserExist)
            {
                return Ok(new AuthResponse { IsSuccess = false, Message = "Username sudah digunakan!" });
            }

            var newUser = new User { Username = request.Username, Password = request.Password };
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return Ok(new AuthResponse { IsSuccess = true, Message = "Registrasi berhasil!" });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AuthRequest request)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == request.Username && u.Password == request.Password);

            if (user == null)
            {
                return Ok(new AuthResponse { IsSuccess = false, Message = "Username atau password salah!" });
            }

            return Ok(new AuthResponse { IsSuccess = true, Message = "Login berhasil!" });
        }
    }
}