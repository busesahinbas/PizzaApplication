using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Buse_160201026.DataBase;
using SQLite;


namespace Buse_160201026
{
    
    static public class Global_CLS
    {
        static public string S;
        static public string C_N;
        static public string C_A;
        static public int C_P;
        static public int C_ID;
        
        static public string P_N;
        static public string P_S;
        static public int P_ID;

    }
    public partial class MainPage : TabbedPage
    {
        public SQLiteConnection Conn;
        // public Customer Cus_Data;
        //public Pizza Piz_Data;
        //public Enroll ENR;

      


        public MainPage()
        {
            InitializeComponent();
            Conn = DependencyService.Get<SQLite_Interface>().GetConnection();
            Conn.CreateTable <Customer>(); 
            Conn.CreateTable<Pizza>();
            Conn.CreateTable<Enroll>();

        }
    }
}
