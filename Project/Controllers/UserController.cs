using Microsoft.AspNetCore.Mvc;
using Project.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return DataManager.dataContext.dataUsers;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return DataManager.dataContext.dataUsers.FirstOrDefault(x => x.Id == id); ;

        }

        // POST api/<UserController>
        [HttpPost]
        public bool Post([FromBody] User value)
        {
            DataManager.dataContext.dataUsers.Add(new User(value));
            return true;
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] User value)
        {
            int index = DataManager.dataContext.dataUsers.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                DataManager.dataContext.dataUsers[index] = new User(id, value);
                return true;
            }
            return false;
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            DataManager.dataContext.dataUsers.Remove(DataManager.dataContext.dataUsers.FirstOrDefault(x => x.Id == id));
            return true;
        }
    }
}
