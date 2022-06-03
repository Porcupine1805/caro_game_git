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
    public partial class Milkwin : Form
    {
        SoundPlayer soundwin;
        public Milkwin()
        {
            soundwin = new SoundPlayer("sw.wav");
            soundwin.Play();
            InitializeComponent();
        }



        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            soundwin.Stop();
            this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            soundwin.Stop();
            Application.Exit();
        }
    }
}
