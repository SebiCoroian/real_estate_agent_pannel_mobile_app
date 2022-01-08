using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Npgsql;

namespace Real_Estate_Agency.Models
{
    public class Cereri
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int id_contact { get; set; }
        public int buget { get; set; }
        public int nr_camere_min { get; set; }
        public int nr_camere_max { get; set; }
        public int suprafata_min { get; set; }
        public int suprafata_max { get; set; }

        public DateTime date { get; set; }
    }
}
