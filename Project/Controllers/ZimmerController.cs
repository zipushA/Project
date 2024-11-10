using Microsoft.AspNetCore.Mvc;
using Project.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZimmerController : ControllerBase
    {
        // GET: api/<ZimmerController>
        [HttpGet]
        public IEnumerable<Zimmer> Get()
        {
            return DataManager.dataContext.dataZimmers;
        }

        // GET api/<ZimmerController>/5
        [HttpGet("{id}")]
        public Zimmer Get(int id)
        {
            return DataManager.dataContext.dataZimmers.FirstOrDefault(x => x.Id == id); ;

        }

        // POST api/<ZimmerController>
        [HttpPost]
        public bool Post([FromBody] Zimmer value)
        {
            DataManager.dataContext.dataZimmers.Add(new Zimmer(value));
            return true;
        }

        // PUT api/<ZimmerController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Zimmer value)
        {
            int index = DataManager.dataContext.dataZimmers.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                DataManager.dataContext.dataZimmers[index] = new Zimmer(id, value);
                return true;

            }
            return false;
        }

        // DELETE api/<ZimmerController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            DataManager.dataContext.dataZimmers.Remove(DataManager.dataContext.dataZimmers.FirstOrDefault(x => x.Id == id));
            return true;
        }
    }
}
