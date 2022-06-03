using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro
{
    public partial class Howtoplay : Form
    {
        public Howtoplay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtbHowtoplay_TextChanged(object sender, EventArgs e)
        {
            ReadOnlyException();
        }

        private bool ReadOnlyException()
        {
            return true;
        }
    }
}
