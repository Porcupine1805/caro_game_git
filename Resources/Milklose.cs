using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Caro.Resources
{
    public partial class Milklose : Form
    {
        SoundPlayer soundlose;
        public Milklose()
        {
            soundlose = new SoundPlayer("sl.wav");
            soundlose.Play();
            InitializeComponent();
        }



        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            soundlose.Stop();
            this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            soundlose.Stop();
            Application.Exit();
        }


    }
}
