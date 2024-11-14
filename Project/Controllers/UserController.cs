using Microsoft.AspNetCore.Mvc;
using Project.Entities;
using Project.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IdataContext _dataContext;
        public UserController(IdataContext dataContext)
        {
            _dataContext = dataContext;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _dataContext.dataUsers;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _dataContext.dataUsers.FirstOrDefault(x => x.Id == id); ;

        }

        // POST api/<UserController>
        [HttpPost]
        public bool Post([FromBody] User value)
        {
            _dataContext.dataUsers.Add(new User(value));
            return true;
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] User value)
        {
            int index = _dataContext.dataUsers.FindIndex(x => x.Id == id);
            if (index != -1)
            {
               _dataContext.dataUsers[index] = new User(id, value);
                return true;
            }
            return false;
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            _dataContext.dataUsers.Remove(_dataContext.dataUsers.FirstOrDefault(x => x.Id == id));
            return true;
        }
    }
}
