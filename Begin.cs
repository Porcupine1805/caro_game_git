using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Caro
{

    public partial class Begin : Form
    {
        private SoundPlayer sound;

        public Begin()
        {
            InitializeComponent();
            sound = new SoundPlayer("sound.wav");
            sound.Play();
        }


        public void btnPvP_Click(object sender, EventArgs e)
        {
            sound.Stop();
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tranc\User.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                cn.Open();
                string us = txtUser.Text;
                string pw = txtPassword.Text;
                string sql = "select *from UserDatabase where id='" + us + "' and Password='" + pw + "'";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader data= cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    Form1 PvPscreeen = new Form1(txtUser.Text);
                    
                    PvPscreeen.Show();
                    this.Visible=false;
                }
                else
                {
                    MessageBox.Show("Wrong password. Please try again!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lbPW_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPvP.PerformClick();
        }
    }
}
