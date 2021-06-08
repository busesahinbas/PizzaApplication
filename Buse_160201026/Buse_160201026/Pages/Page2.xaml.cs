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
    public partial class Page2 : ContentPage
    {
        public SQLiteConnection Conn;
        public Customer Cus_Data;
        public Page2()
        {
            InitializeComponent();
            Conn = DependencyService.Get<SQLite_Interface>().GetConnection();
           
        }

        public void But_Cus_Add_Clicked(object sender, EventArgs e)
        {
            Cus_Data = new Customer ();
            Cus_Data.CUS_Name = C_Name.Text;
            Cus_Data.CUS_Add = C_Add.Text;           
            int.TryParse(C_Phone.Text, out int PH);
            Cus_Data.CUS_Phone = PH;
            
            Conn.Insert(Cus_Data);

            Global_CLS.C_N = Cus_Data.CUS_Name;
            Global_CLS.C_A = Cus_Data.CUS_Add;
            Global_CLS.C_P = PH;
            Global_CLS.C_ID = Cus_Data.CUS_ID;
        }

        private void Show_But_Clicked(object sender, EventArgs e)
        {
           var data = (from cus in Conn.Table<Customer>() select cus);
           Cus_List_View.ItemsSource = data;
            
            //Conn.DropTable<Customer>();
        }

        private void Cus_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //var data = (from cus in Conn.Table<Customer>() select cus);
            //Cus_List_View.ItemsSource = data;
            //await DisplayAlert("allert", data., "ok");
          
        }
    }
}