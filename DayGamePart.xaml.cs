using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Mafia_Game_Controller
{
    public partial class DayGamePart : ContentPage
    {

   
        public int a= 0;
       

        public DayGamePart()
        {
            InitializeComponent();

        }

       private void Buttons_Click (object sender, EventArgs ev)
        {
           
             List<Label> labels = new List<Label>();
             labels.Add(label1);
             labels.Add(label2);
             labels.Add(label3);
             labels.Add(label4);
             labels.Add(label5);
             labels.Add(label6);
             labels.Add(label7);
             labels.Add(label8);
             labels.Add(label9);
             labels.Add(label10);

             List<Button> buttons = new List<Button>();
             buttons.Add(button1);
             buttons.Add(button2);
             buttons.Add(button3);
             buttons.Add(button4);
             buttons.Add(button5);
             buttons.Add(button6);
             buttons.Add(button7);
             buttons.Add(button8);
             buttons.Add(button9);
             buttons.Add(button10);

             List<Entry> entrys = new List<Entry>();
             entrys.Add(entry1);
             entrys.Add(entry2);
             entrys.Add(entry3);
             entrys.Add(entry4);
             entrys.Add(entry5);
             entrys.Add(entry6);
             entrys.Add(entry7);
             entrys.Add(entry8);
             entrys.Add(entry9);
             entrys.Add(entry10);

             a++;
           
            
for (int i = 0; i < 10; i++)
            {
                
                if (buttons[i].IsFocused==true)
                {
                    buttons[i].Text = a.ToString() + " зауваження";
                    if (a == 4)
                    {
                        buttons[i].BackgroundColor = Color.Red;
                        buttons[i].IsEnabled = false;
                        buttons[i].Text = a.ToString() + " зауваження";
                        labels[i].BackgroundColor = Color.Red;
                        entrys[i].Text = entrys[i].Text + " Видалено за 4 фоли";
                        entrys[i].BackgroundColor = Color.Red;
                        a = 0;
                        
                    }
                   
                }
      
            }

 }

       

        protected async void GoToNight(object sender, EventArgs e)
        {

            await App.Navigation.PushAsync(new NightPartGame());
        }

                 
        }

}
