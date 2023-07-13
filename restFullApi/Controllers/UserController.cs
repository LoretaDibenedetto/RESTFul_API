using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using restFullApi.DataBase;

namespace restFullApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static FakeDatabase _database = new FakeDatabase();

        [HttpGet]
        public IActionResult GetUser(int idUser) 
        {
        
         var user = _database.Users.FirstOrDefault(x => x.IdUser == idUser);
         if (user == null)
            {
                return NotFound();
            }
        
         return Ok(user);
        
        }



        [HttpGet] 
        public IActionResult AllUsers()
        {
            return Ok(_database.Users);
        }
    }
}
