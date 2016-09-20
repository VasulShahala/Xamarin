using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Mafia_Game_Controller
{
    public class App : Application

    {
        
        public static INavigation Navigation { get; set; }
        
          
        public App(){
       // public static Page GetMainPage()
            var mainPage = new MainPage();
            Navigation = mainPage.Navigation;
             MainPage= new NavigationPage( mainPage);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
