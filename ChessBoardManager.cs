using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro
{

    public class ChessBoardManager
    {
        #region Properties
        private Panel ChessBoard;
        private List<Player> player;
        public List<Player> Player { get => player; set => player = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public TextBox PlayerName1 { get => PlayerName; set => PlayerName = value; }
        public PictureBox PlayerAva1 { get => PlayerAva; set => PlayerAva = value; }
        public List<List<Button>> Matrix1 { get => Matrix; set => Matrix = value; }

        private int currentPlayer;
        private TextBox PlayerName;
        private PictureBox PlayerAva;
        private List<List<Button>> Matrix;
        private event EventHandler<ButtonClickEvent> playerMarked;
        public event EventHandler<ButtonClickEvent> PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }
        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }
        private Stack<PlayInfo> playTimeLine;
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tranc\Caro\dbUser.mdf;Integrated Security=True;Connect Timeout=30");

        #endregion
        string strNhan;
        public string Message
        {
            get { return strNhan; }
            set { strNhan = value; }
        }


        #region Initialize
        public ChessBoardManager(Panel ChessBoard, TextBox PlayerName, PictureBox PlayerAva)
        {
            cn.Open();
            this.ChessBoard = ChessBoard;
            this.PlayerName1 = PlayerName;
            this.PlayerAva1 = PlayerAva;

            this.Player = new List<Player>()
            {
                new Player("Mocha Bear", Image.FromFile(Application.StartupPath + "\\Resources\\black.png"), Image.FromFile(Application.StartupPath + "\\Resources\\player1.1.gif")),
                new Player("Milk Bear", Image.FromFile(Application.StartupPath + "\\Resources\\white.png"), Image.FromFile(Application.StartupPath + "\\Resources\\player2.1.gif")),
            };
            
         
        }

        
        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            ChessBoard.Enabled = true;
            ChessBoard.Controls.Clear();
            playTimeLine = new Stack<PlayInfo>();
            currentPlayer = 0;
            ChangePlayer();
            Matrix = new List<List<Button>>();

            Button oldbutton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Box.CHESS_HEIGHT; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Box.CHESS_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Box.BOX_HEIGHT,
                        Height = Box.BOX_WIDTH,
                        Location = new Point(oldbutton.Location.X + oldbutton.Width, oldbutton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };
                    btn.Click += Btn_Click;

                    ChessBoard.Controls.Add(btn);

                    Matrix[i].Add(btn);

                    oldbutton = btn;
                } 
                oldbutton.Location = new Point(0, oldbutton.Location.Y + Box.BOX_HEIGHT);
                oldbutton.Width = 0;
                oldbutton.Height = 0;
            }
            #endregion

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackgroundImage != null)
                return;

           
            PlayerAvatar(btn);
            playTimeLine.Push(new PlayInfo(GetChessPoint(btn),CurrentPlayer));
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
            ChangePlayer();

            if (playerMarked != null)
                playerMarked(this, new ButtonClickEvent(GetChessPoint(btn)));

            if (IsEndGame(btn))
            {
                EndGame();
            }

            
        }
        public bool Undo()
        {
            if (playTimeLine.Count <= 0)
                return false;

            bool isUndo1 = UndoAStep();
            bool isUndo2 = UndoAStep();

            PlayInfo oldPoint = playTimeLine.Peek();
            CurrentPlayer = oldPoint.CurrentPlayer == 1 ? 0 : 1;

            return isUndo1 && isUndo2;
        }

        private bool UndoAStep()
        {
            if (playTimeLine.Count <= 0)
                return false;

            PlayInfo oldPoint = playTimeLine.Pop();
            Button btn = Matrix[oldPoint.Point.Y][oldPoint.Point.X];

            btn.BackgroundImage = null;

            if (playTimeLine.Count <= 0)
            {
                CurrentPlayer = 0;
            }
            else
            {
                oldPoint = playTimeLine.Peek();
            }

            ChangePlayer();

            return true;
        }
        public void OtherPlayerMark(Point point)
        {
            Button btn = Matrix[point.Y][point.X];

            if (btn.BackgroundImage != null)
                return;

            PlayerAvatar(btn);

            playTimeLine.Push(new PlayInfo(GetChessPoint(btn), CurrentPlayer));

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;

            ChangePlayer();

            if (IsEndGame(btn))
            {
                EndGame();
            }
        }
        public void EndGame()
        {
            if (endedGame != null)
                endedGame(this, new EventArgs());
        }
        
        private bool IsEndGame(Button btn)
        {
            return IsEndinCol(btn) || IsEndinRow(btn) || IsEndDiagonal1(btn) || IsEndDiagonal2(btn);
        }

        private Point GetChessPoint(Button btn)
        {
            
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);
            Point point = new Point(horizontal,vertical);
            return point;
        }
        private bool IsEndinCol(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countLeft = 0;
            int countRight = 0; 
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }
            for (int i = point.X + 1; i < Box.CHESS_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }
            return countLeft + countRight == 5;
        }
        private bool IsEndinRow(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            int countBot = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            for (int i = point.Y + 1; i < Box.CHESS_HEIGHT; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBot++;
                }
                else
                    break;
            }
            return countTop + countBot == 5;
        }
        private bool IsEndDiagonal1(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            int countBot = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;
                if (Matrix[point.Y-i][point.X-i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            for (int i = 1; i <= Box.CHESS_WIDTH - point.X; i++)
            {
                if (point.Y + i >= Box.CHESS_HEIGHT || point.X + i >= Box.BOX_WIDTH)
                    break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBot++;
                }
                else
                    break;
            }
            return countTop + countBot == 5;
        }
        private bool IsEndDiagonal2(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            int countBot = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > Box.CHESS_WIDTH || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            for (int i = 1; i <= Box.CHESS_WIDTH - point.X; i++)
            {
                if (point.Y + i >= Box.CHESS_HEIGHT || point.X - i < 0)
                    break;
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBot++;
                }
                else
                    break;
            }
            return countTop + countBot == 5;
        }
        private void PlayerAvatar(Button btn)
        { 
            btn.BackgroundImage = Player[currentPlayer].Mark1;
            
        }

        private void ChangePlayer()
        {
            PlayerName.Text = Player[CurrentPlayer].Name;
            PlayerAva.Image = Player[CurrentPlayer].PlayerAva1;
        }
        public class ButtonClickEvent : EventArgs
        {
            private Point clickedPoint;

            public Point ClickedPoint
            {
                get { return clickedPoint; }
                set { clickedPoint = value; }
            }

            public ButtonClickEvent(Point point)
            {
                this.ClickedPoint = point;
            }
        }
    }
}
