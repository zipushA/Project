using Project.Entities;
using Project.Controllers;
namespace Project.Interface
{
    public interface IdataContext
    {
        public List<Cleaner> dataCleners { get; set; }
        public List<Order> dataOrders { get; set; }
        public List<Owner> dataOwners {  get; set; }
        public List<User> dataUsers {  get; set; }
        public List<Zimmer> dataZimmers { get; set; }
    }
}
