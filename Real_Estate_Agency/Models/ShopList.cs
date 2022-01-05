using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Npgsql;

namespace Real_Estate_Agency.Models
{
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public float Area { get; set; }
        public float Price { get; set; } 
        public string ImageUrl { get; set; }
    }
}
