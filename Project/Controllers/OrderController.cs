using Microsoft.AspNetCore.Mvc;
using Project.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return DataManager.dataContext.dataOrders;
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return DataManager.dataContext.dataOrders.FirstOrDefault(x => x.Id == id); 
        }

        // POST api/<OrderController>
        [HttpPost]
        public bool Post([FromBody] Order order)
        {
            if (order!=null)
            {
                DataManager.dataContext.dataOrders.Add(new Order(order));
                return true;

            }
            return false;
           
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Order value)
        {
            int index = DataManager.dataContext.dataOrders.FindIndex(x => x.Id == id);
            if (index != -1&&value!=null)
            {
                DataManager.dataContext.dataOrders[index] = new Order(id, value);
                return true;
            }
            return false;
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            DataManager.dataContext.dataOrders.Remove(DataManager.dataContext.dataOrders.FirstOrDefault(x => x.Id == id));
            return true;
        }
    }
}
