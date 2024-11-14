using Project.Entities;
using Project.Interface;

namespace Project
{
    public class FakeContext:IdataContext
    {
        public List<Cleaner> dataCleners { get; set; }
        public List<Order> dataOrders { get; set; }
        public List<Owner> dataOwners { get; set; }
        public List<User> dataUsers { get; set; }
        public List<Zimmer> dataZimmers { get; set; }
        public FakeContext()
        {
            dataCleners = new List<Cleaner>();
            dataOrders = new List<Order>();
            dataOwners = new List<Owner>();
            dataUsers = new List<User>();
            dataZimmers = new List<Zimmer>();
        }
    }
}
