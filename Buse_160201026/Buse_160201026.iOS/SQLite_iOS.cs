using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using SQLite;

using Buse_160201026.iOS;
using Xamarin.Forms;
[assembly: Dependency(typeof(SQLite_iOS))]

namespace Buse_160201026.iOS
{
    public class SQLite_iOS : SQLite_Interface 
    {
        public SQLiteConnection GetConnection()
        {
            var DB_Name = "MY_DB.sql";
            var DB_Path = System.Environment.GetFolderPath(
                System.Environment.SpecialFolder.Personal);
            var Full_Path = System.IO.Path.Combine(DB_Path, DB_Name);

            var Conn = new SQLiteConnection(Full_Path);
            return Conn;
        }
    }
}