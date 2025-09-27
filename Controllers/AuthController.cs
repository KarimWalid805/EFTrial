using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormEF.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;
        public AuthController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            using var con = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            con.Open();
            var cmd = new SqlCommand("SELECT * FROM customeraccount WHERE username=@username AND password=@password", con);
            cmd.Parameters.AddWithValue("@username", request.Username);
            cmd.Parameters.AddWithValue("@password", request.Password);
            using var dr = cmd.ExecuteReader();
            if (dr.Read())
                return Ok(new { Success = true });
            return Unauthorized(new { Success = false, Message = "Invalid credentials" });
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterRequest request)
        {
            using var con = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            con.Open();
            var cmd = new SqlCommand("INSERT INTO customeraccount (username, password) VALUES (@username, @password)", con);
            cmd.Parameters.AddWithValue("@username", request.Username);
            cmd.Parameters.AddWithValue("@password", request.Password);
            try
            {
                cmd.ExecuteNonQuery();
                return Ok(new { Success = true });
            }
            catch (SqlException ex)
            {
                return BadRequest(new { Success = false, Message = ex.Message });
            }
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class RegisterRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}