using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Buse_160201026.DataBase;

namespace Buse_160201026.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page5 : ContentPage
    {
        public SQLiteConnection Conn;
        public Enroll Enroll_Data;
        public Page5()
        {
            InitializeComponent();
            Conn = DependencyService.Get<SQLite_Interface>().GetConnection();
           
        }

        /*public void GetCus()
        {                  
            var data = (from cus in Conn.Table<Customer>() select cus);
            Enroll_List_View.ItemsSource = data;           
        }
        
        public void GetPizza()
        {
            var data = (from piz in Conn.Table<Pizza>() select piz);
            Enroll_List_View.ItemsSource = data;           
        } 
        */

        private void Save_But_Clicked(object sender, EventArgs e)
        {
            C_name.Text = Global_CLS.C_N;
            C_adres.Text = Global_CLS.C_A;
            C_phone.Text = Global_CLS.C_P.ToString();
            P_size.Text = Global_CLS.S;
            P_name.Text = Global_CLS.P_N;

            Enroll_Data = new Enroll();
            Enroll_Data.CUS_ID = Global_CLS.C_ID;
            Enroll_Data.Pizza_ID = Global_CLS.P_ID;
        }
        private void Show_But_Clicked(object sender, EventArgs e)
        {
            var data = (from enrl in Conn.Table<Enroll>() select enrl);
            Enroll_List_View.ItemsSource = data;
        }

      
    }
}