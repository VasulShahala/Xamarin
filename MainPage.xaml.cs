using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Mafia_Game_Controller
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected async void GoToRoleChoose(object sender, EventArgs e)
        {
            await App.Navigation.PushAsync(new RoleChoose());
        }
    }
}
