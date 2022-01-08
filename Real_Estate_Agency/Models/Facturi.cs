using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Npgsql;

namespace Real_Estate_Agency.Models
{
    public class Facturi
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int id_contact { get; set; }
        public int suma { get; set; }
        public DateTime date { get; set; }
    }
}
