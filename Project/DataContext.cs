﻿using CsvHelper;
using Microsoft.Extensions.Logging;
using Project.Entities;
using Project.Interface;
using System.Formats.Asn1;
using System.Globalization;

namespace Project
{
    public class DataContext:IdataContext
    {
        public List<Cleaner> dataCleners { get; set; }
        public List<Order> dataOrders { get; set; }
        public List<Owner> dataOwners { get; set; }
        public List<User> dataUsers { get; set; }
        public List<Zimmer> dataZimmers { get; set; }
        public DataContext()
        {
            dataCleners = new List<Cleaner>();
            dataOrders = new List<Order>();
            dataOwners = new List<Owner>();
            dataUsers = new List<User>();
            dataZimmers = new List<Zimmer>();
        }
    }
}
