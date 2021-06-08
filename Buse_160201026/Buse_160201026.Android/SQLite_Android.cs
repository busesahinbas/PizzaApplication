using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

using Buse_160201026.Droid;
using Xamarin.Forms;
[assembly: Dependency(typeof(SQLite_Android))]

namespace Buse_160201026.Droid
{
    public class SQLite_Android : SQLite_Interface
    {
        public SQLiteConnection GetConnection()
        {
            var DB_Name = "MY_DB.sql";
            var DB_Path = System.Environment.GetFolderPath(
                System.Environment.SpecialFolder.ApplicationData);
            var Full_Path = System.IO.Path.Combine(DB_Path, DB_Name);

            var Conn = new SQLiteConnection(Full_Path);
            return Conn;
        }
    }
}