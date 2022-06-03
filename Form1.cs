using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;
using static Caro.ChessBoardManager;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;
using System.Net;
using Caro.Resources;
using System.Media;


namespace Caro
{
    public partial class Form1 : Form
    {
        private SoundPlayer soundsc;
        private SoundPlayer soundmark;

        #region Properties
        ChessBoardManager ChessBoard;
        SocketManager socket;
        #endregion
        public Form1()
        {
            InitializeComponent();
            soundsc = new SoundPlayer("soundscreen.wav");
            ChessBoard = new ChessBoardManager(pnlChessBoard, tBPlayerName, ptrAva);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;
            prcTime.Step = Box.Cooldown_step;
            prcTime.Maximum = Box.Cooldown_time;
            prcTime.Value = 0;
            //soundsc.Play();
            socket = new SocketManager();

            Time.Interval = Box.Cooldown_interval;

            ChessBoard.DrawChessBoard();
        }

        public Form1(string Message) : this()
        {
            string user = Message;
            txtUser.Text = user;
        }

        void EndGame()
        {
            soundsc.Stop();
            Time.Stop();
            pnlChessBoard.Enabled = false;
            if(socket.ConnectServer())
                if (socket.isServer)
                {
                    if (tBPlayerName.Text == "Mocha Bear")
                    {
                        Mochalose ketqua = new Mochalose();
                        ketqua.ShowDialog();
                    }
                    else
                    {
                        Mochawin ketqua = new Mochawin();
                        ketqua.ShowDialog();
                    }
                }
                else
                {
                    if (tBPlayerName.Text == "Mocha Bear")
                    {
                        Milkwin ketqua = new Milkwin();
                        ketqua.ShowDialog();
                        
                    }
                    else
                    {
                        Milklose ketqua = new Milklose();
                        ketqua.ShowDialog();
                        
         
                    }
                }
            undoToolStripMenuItem.Enabled = false;
        }


        void Undo()
        {
            ChessBoard.Undo();
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
        }

        private void ChessBoard_PlayerMarked(object sender, ButtonClickEvent e)
        {
            soundmark = new SoundPlayer("mark.wav");
            soundmark.Play();
            Time.Start();
            pnlChessBoard.Enabled = false;
            prcTime.Value = 0;
            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickedPoint));
            undoToolStripMenuItem.Enabled = false;
            Listen();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            prcTime.PerformStep();

            if (prcTime.Value >= prcTime.Maximum)
            {
                EndGame();
                socket.Send(new SocketData((int)SocketCommand.TIME_OUT, "", new Point()));
            }
        }
        public void NewGame()
        {
            soundsc.Play();
            prcTime.Value = 0;
            Time.Stop();
            ChessBoard.DrawChessBoard();
            undoToolStripMenuItem.Enabled = true;
        }
        public void Quit()
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlChessBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
            pnlChessBoard.Enabled = true;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to quit?", "NOTICE", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                }
                catch { }
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
            socket.Send(new SocketData((int)SocketCommand.UNDO, "", new Point()));

        }



        private void button3_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void btnHowtoplay_Click(object sender, EventArgs e)
        {
            Howtoplay howtoplay = new Howtoplay();
            howtoplay.ShowDialog();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            NewGame();
            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
            pnlChessBoard.Enabled = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            socket.IP = txbIP.Text;

            if (!socket.ConnectServer())
            {
                socket.isServer = true;
                pnlChessBoard.Enabled = true;
                socket.CreateServer();
                Listen();
                MessageBox.Show("Waiting for other player!!!");
            }
            else
            {
                socket.isServer = false;
                pnlChessBoard.Enabled = false;
                Listen();  
                MessageBox.Show("Found match!!!");
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.TIME_OUT, "", new Point()));
                }
                catch { }
            }
            btnConnect.Enabled = false;
        }
        void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();
                    ProcessData(data);
                }
                catch (Exception e)
                {
                }
            });
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if (string.IsNullOrEmpty(txbIP.Text))
            {
                txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }
        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.SEND_MESSAGE:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        rtbMess.Text = data.Message;
                        Addmess();
                    }));
                    break;
                case (int)SocketCommand.NOTIFY:
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        pnlChessBoard.Enabled = false;
                    }));
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        prcTime.Value = 0;
                        pnlChessBoard.Enabled = true;
                        Time.Start();
                        ChessBoard.OtherPlayerMark(data.Point);
                        undoToolStripMenuItem.Enabled = true;
                    }));
                    break;
                case (int)SocketCommand.UNDO:
                    Undo();
                    prcTime.Value = 0;
                    break;
                case (int)SocketCommand.END_GAME:
                    break;
                case (int)SocketCommand.TIME_OUT:
                    MessageBox.Show("Time's up");
                    break;
                case (int)SocketCommand.QUIT:
                    Time.Stop();
                    MessageBox.Show("Your opponent has quit!!!");
                    break;
                default:
                    break;
            }

            Listen();
        }
        private void Addmess()
        {
            string s = rtbMess.Text;
            LvShow.Items.Add(new ListViewItem() { Text = s });
            rtbMess.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            socket.Send(new SocketData((int)SocketCommand.SEND_MESSAGE,txtUser.Text +": "+ rtbMess.Text , new Point()));
            string s = txtUser.Text + ": " + rtbMess.Text;
            LvShow.Items.Add(new ListViewItem() { Text = s });
            rtbMess.Clear();
            Listen();
        }

        private void rtbMess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSend.PerformClick();
        }
    }

   

}


