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
    public partial class Mochawin : Form
    {
        SoundPlayer soundwin;

        public Mochawin()
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            soundwin.Stop();
            Application.Exit();
        }
    }
}
