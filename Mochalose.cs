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

namespace Caro
{
    public partial class Mochalose : Form
    {
        SoundPlayer soundlose;
        public Mochalose()
        {
            soundlose = new SoundPlayer("sl.wav");
            soundlose.Play();
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            soundlose.Stop();
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            soundlose.Stop();
            this.Close();
        }



        private void btnExit_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
