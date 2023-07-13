using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using restFullApi.DataBase;
using restFullApi.Model.Request;

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



        [HttpGet("all")] 
        public IActionResult AllUsers()
        {
            return Ok(_database.Users);
        }



        [HttpDelete]

        public IActionResult DeleteUser(int idUser)
        {

            var user = _database.Users.FirstOrDefault(x => x.IdUser == idUser);
            if (user == null)
            
                return NotFound();
            
            _database.Users.Remove(user);
            return Ok();

        }

        [HttpPost]
        public IActionResult AddUser([FromBody]AddUserRequest user)
        {
            _database.AddUser(new User { IdUser = 0, 
                                         Name = user.Name,
                                         Password = user.Password, 
                                         Surname = user.Surname,
                                         UserName = user.UserName });
            return Ok();
        }

    }
}
