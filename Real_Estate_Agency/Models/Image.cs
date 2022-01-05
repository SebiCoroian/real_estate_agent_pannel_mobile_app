using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Npgsql;

namespace Real_Estate_Agency.Models
{
    public class PropImage
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Property { get; set; }
        public string ImageUrl { get; set; }
    }
}
