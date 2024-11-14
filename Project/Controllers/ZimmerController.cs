using Microsoft.AspNetCore.Mvc;
using Project.Entities;
using Project.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZimmerController : ControllerBase
    {
        private readonly IdataContext _dataContext;
        public ZimmerController(IdataContext dataContext)
        {
            _dataContext = dataContext;
        }
        // GET: api/<ZimmerController>
        [HttpGet]
        public IEnumerable<Zimmer> Get()
        {
            return _dataContext.dataZimmers;
        }

        // GET api/<ZimmerController>/5
        [HttpGet("{id}")]
        public Zimmer Get(int id)
        {
            return _dataContext.dataZimmers.FirstOrDefault(x => x.Id == id); ;

        }

        // POST api/<ZimmerController>
        [HttpPost]
        public bool Post([FromBody] Zimmer value)
        {
            _dataContext.dataZimmers.Add(new Zimmer(value));
            return true;
        }

        // PUT api/<ZimmerController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Zimmer value)
        {
            int index = _dataContext.dataZimmers.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _dataContext.dataZimmers[index] = new Zimmer(id, value);
                return true;

            }
            return false;
        }

        // DELETE api/<ZimmerController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            _dataContext.dataZimmers.Remove(_dataContext.dataZimmers.FirstOrDefault(x => x.Id == id));
            return true;
        }
    }
}
