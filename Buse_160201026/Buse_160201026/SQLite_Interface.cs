using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Buse_160201026
{
    public interface SQLite_Interface
    {
        SQLiteConnection GetConnection();
    }
}
