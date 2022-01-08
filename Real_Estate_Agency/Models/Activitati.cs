using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Npgsql;

namespace Real_Estate_Agency.Models
{
    public class Activitati
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int id_contact1 { get; set; }
        public int id_contact2 { get; set; }
        public int id_proprietate { get; set; }
        public string descriere { get; set; }
        public DateTime data { get; set; }

    }
}
