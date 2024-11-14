using Microsoft.AspNetCore.Mvc;
using Project.Entities;
using Project.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IdataContext _dataContext;
        public OrderController(IdataContext dataContext)
        {
            _dataContext = dataContext;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _dataContext.dataOrders;
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return _dataContext.dataOrders.FirstOrDefault(x => x.Id == id); 
        }

        // POST api/<OrderController>
        [HttpPost]
        public bool Post([FromBody] Order order)
        {
            if (order!=null)
            {
                _dataContext.dataOrders.Add(new Order(order));
                return true;

            }
            return false;
           
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Order value)
        {
            int index = _dataContext.dataOrders.FindIndex(x => x.Id == id);
            if (index != -1&&value!=null)
            {
                _dataContext.dataOrders[index] = new Order(id, value);
                return true;
            }
            return false;
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            _dataContext.dataOrders.Remove(_dataContext.dataOrders.FirstOrDefault(x => x.Id == id));
            return true;
        }
    }
}
