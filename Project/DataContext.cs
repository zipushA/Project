using CsvHelper;
using Microsoft.Extensions.Logging;
using Project.Entities;
using System.Formats.Asn1;
using System.Globalization;

namespace Project
{
    public class DataContext
    {
        public List<Cleaner>dataCleners = new List<Cleaner>();
        public List<Order>dataOrders = new List<Order>();
        public List<Owner>dataOwners = new List<Owner>();
        public List<User>dataUsers = new List<User>();
        public List<Zimmer>dataZimmers = new List<Zimmer>();
      
    }
}
