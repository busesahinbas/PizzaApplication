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
    public partial class Page4 : ContentPage
    {
        public SQLiteConnection Conn;
        public Pizza Piz_Data;
        public Page4()
        {
            InitializeComponent();
            Conn = DependencyService.Get<SQLite_Interface>().GetConnection();
        }

        private void But_Piz_Add_Clicked(object sender, EventArgs e)
        {
            Piz_Data = new Pizza();
            Piz_Data.Pizza_Size = Global_CLS.S;

            if (Radio_1.IsChecked == true)
            { Piz_Data.Pizza_Name = Radio_1.Text; }

            if (Radio_2.IsChecked == true)
            { Piz_Data.Pizza_Name = Radio_2.Text; }

            if (Radio_3.IsChecked == true)
            { Piz_Data.Pizza_Name = Radio_3.Text; }

            Conn.Insert(Piz_Data);

            Global_CLS.P_N = Piz_Data.Pizza_Name;
            Global_CLS.P_ID = Piz_Data.Pizza_ID;
        }

        private void Show_Piz_But_Clicked(object sender, EventArgs e)
        {
            var data = (from piz in Conn.Table<Pizza>() select piz);
            Piz_List_View.ItemsSource = data;
            //Conn.DropTable<Pizza>();
        }
    }
}