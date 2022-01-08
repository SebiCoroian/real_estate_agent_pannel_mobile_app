using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Npgsql;

namespace Real_Estate_Agency.Models
{
    public class Contacte
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string nume { get; set; }
        public string nr_tel { get; set; }
        public string mail { get; set; }


        public DateTime date { get; set; }
    }
}
