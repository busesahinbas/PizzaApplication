using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Buse_160201026.DataBase;
using SQLite;

namespace Buse_160201026.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public SQLiteConnection Conn;
        public Page3()
        {

            InitializeComponent();
            Conn = DependencyService.Get<SQLite_Interface>().GetConnection();

        }

        public void But_Size_Add_Clicked(object sender, EventArgs e)
        {
            
          if(Radio1.IsChecked==true )
            { Global_CLS.S = "Small"; }

          if (Radio2.IsChecked == true)
            { Global_CLS.S = "Medium"; }

          if (Raido3.IsChecked == true)
            { Global_CLS.S = "Large"; }
        }
    }
}