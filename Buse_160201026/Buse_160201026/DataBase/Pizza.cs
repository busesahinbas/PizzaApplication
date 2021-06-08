using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Buse_160201026.DataBase
{
    public class Pizza
    {
        [PrimaryKey, AutoIncrement]
        public int Pizza_ID { get; set; }
        public string Pizza_Size {get; set;}
        public string Pizza_Name { get; set; }
    }
}
