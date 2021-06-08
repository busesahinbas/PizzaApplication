using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Buse_160201026.DataBase
{
    public class Customer 
    {
        [PrimaryKey, AutoIncrement]
        public int CUS_ID { get; set; }
        public string CUS_Name { get; set; }
        public string CUS_Add { get; set; }
        public int CUS_Phone { get; set; }
    }
}
