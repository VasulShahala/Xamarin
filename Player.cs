using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Mafia_Game_Controller
{
    public class Player
    {
        public int I_position { get; set; }
        public string NickName { get; set; }
        public string Role_player { get; set; }
        public int Coun_fouls { get; set; }
        public bool Nigth_kill { get; set; }
        public bool DayDie { get; set; }
        public bool FoulDelete { get; set; }
        
    }
           
   
}
