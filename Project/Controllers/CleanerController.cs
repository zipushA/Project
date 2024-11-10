using Microsoft.AspNetCore.Mvc;
using Project.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CleanerController : ControllerBase
    {
        // GET: api/<CleanerController>
        [HttpGet]
        public IEnumerable<Cleaner> Get()
        {
            return DataManager.dataContext.dataCleners;
        }

        // GET api/<CleanerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Cleaner c = DataManager.dataContext.dataCleners.FirstOrDefault(x => x.Id == id);
            if (c == null)
                return NotFound();
            else
                return Ok(c);
        }

        // POST api/<CleanerController>
        [HttpPost]
        public bool Post([FromBody] Cleaner value)
        {
            DataManager.dataContext.dataCleners.Add(new Cleaner(value));
            return true;
        }

        // PUT api/<CleanerController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Cleaner value)
        {
            int index = DataManager.dataContext.dataCleners.FindIndex(x=>x.Id==id);
            if(index != -1)
            {
                DataManager.dataContext.dataCleners[index] = new Cleaner(id, value);
                return true;
            }
            return false;
        }

        // DELETE api/<CleanerController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
          return DataManager.dataContext.dataCleners.Remove(DataManager.dataContext.dataCleners.FirstOrDefault(x => x.Id == id));
        }
    }
}
