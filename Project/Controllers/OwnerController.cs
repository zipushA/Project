using Microsoft.AspNetCore.Mvc;
using Project.Entities;
using Project.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IdataContext _dataContext;
        public OwnerController(IdataContext dataContext)
        {
            _dataContext = dataContext;
        }
        // GET: api/<OwnerController>
        [HttpGet]
        public IEnumerable<Owner> Get()
        {
            return _dataContext.dataOwners;
        }

        // GET api/<OwnerController>/5
        [HttpGet("{id}")]
        public Owner Get(int id)
        {
            return _dataContext.dataOwners.FirstOrDefault(x => x.Id == id); ;

        }

        // POST api/<OwnerController>
        [HttpPost]
        public bool Post([FromBody] Owner value)
        {
            _dataContext.dataOwners.Add(new Owner(value));
            return true;

        }

        // PUT api/<OwnerController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Owner value)
        {
            int index = _dataContext.dataOwners.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _dataContext.dataOwners[index] = new Owner(id, value);
                return true;
            }
            return false;
        }

        // DELETE api/<OwnerController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            _dataContext.dataOwners.Remove(_dataContext.dataOwners.FirstOrDefault(x => x.Id == id));
            return true;
        }
    }
}
