 using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro
{
    public class Player
    {
        private string name;


        public string Name
        {
            get => name; set => name = value;
        }
        private Image Mark;
        public Image Mark1 { get => Mark; set => Mark = value; }
        public Image PlayerAva1 { get => PlayerAva; set => PlayerAva = value; }

        public Player(string Name, Image Mark, Image PlayerAva)
        {
            this.name = Name;
            this.Mark1 = Mark;
            this.PlayerAva1 = PlayerAva;
        }

        private Image PlayerAva;
    }
}
