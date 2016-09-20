using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms;



namespace Mafia_Game_Controller
{
    public partial class RoleChoose : ContentPage
    {
       
        public RoleChoose()
        {
            InitializeComponent();

        }

    

        protected async void GoToDay(object sender, EventArgs e)
        {
             
            await App.Navigation.PushAsync(new DayGamePart());
        }

    }
}
