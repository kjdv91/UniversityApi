using Backend.DataAcces;
using Backend.Models.DtoModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UniversityContext _context;

        public UsersController(UniversityContext context)
        {
            _context = context;
        }
        // GET: api/Users
        [HttpGet]
        public async Task <ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        // GET api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(long id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();

            }
            return user;
        }

        // POST api/Users
        [HttpPost]
        public async Task <ActionResult<User>> CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();  //guarda los cambios de forma asincrona
            return CreatedAtAction("GetUser", new { id = user.Id }, user);  //tipo 201 llama internamente a getUser
        }

        // PUT api/Users/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(long id,User user)
        {
            if (id != user.Id)
            {
                return BadRequest(); //devuelve un error 400

            }
            _context.Entry(user).State = EntityState.Modified; //estado modificado
            try
            {
                await _context.SaveChangesAsync();  //actualizacion asincrona base de datos
            }
            catch (DbUpdateConcurrencyException)  //error de concurrencia
            {

                if (!UserExists (id))
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

       

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteUser(long id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Remove(user);
                await _context.SaveChangesAsync();
                return Ok(user);

            }
            return NotFound();

        }

        private bool UserExists(long id)
        {
            return _context.Users.Any(x => x.Id == id);
        }
    }
}
