using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Mafia_Game_Controller
{
    public partial class NightPartGame : ContentPage
    {
        public NightPartGame()
        {
            InitializeComponent();
        }
        private void switcher_Toggled(object sender, ToggledEventArgs e)
        {
            SheriffPlayLabel.IsVisible = true;
            DonPlayLabel.IsVisible = false;
        }

    }
}
