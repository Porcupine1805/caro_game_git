namespace Caro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.ptrAvatar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ptrAva = new System.Windows.Forms.PictureBox();
            this.tBPlayerName = new System.Windows.Forms.TextBox();
            this.prcTime = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnHowtoplay = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbMess = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.LvShow = new System.Windows.Forms.ListView();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptrAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAva)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.Color.White;
            this.pnlChessBoard.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlChessBoard.Location = new System.Drawing.Point(11, 26);
            this.pnlChessBoard.Margin = new System.Windows.Forms.Padding(2);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(482, 510);
            this.pnlChessBoard.TabIndex = 0;
            this.pnlChessBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChessBoard_Paint);
            // 
            // ptrAvatar
            // 
            this.ptrAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptrAvatar.BackColor = System.Drawing.Color.LightYellow;
            this.ptrAvatar.Controls.Add(this.panel3);
            this.ptrAvatar.Controls.Add(this.ptrAva);
            this.ptrAvatar.Controls.Add(this.tBPlayerName);
            this.ptrAvatar.Controls.Add(this.prcTime);
            this.ptrAvatar.Location = new System.Drawing.Point(8, 50);
            this.ptrAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.ptrAvatar.Name = "ptrAvatar";
            this.ptrAvatar.Size = new System.Drawing.Size(178, 239);
            this.ptrAvatar.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(9, 241);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 134);
            this.panel3.TabIndex = 2;
            // 
            // ptrAva
            // 
            this.ptrAva.BackColor = System.Drawing.Color.LightYellow;
            this.ptrAva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptrAva.ErrorImage = null;
            this.ptrAva.Location = new System.Drawing.Point(2, 29);
            this.ptrAva.Margin = new System.Windows.Forms.Padding(2);
            this.ptrAva.Name = "ptrAva";
            this.ptrAva.Size = new System.Drawing.Size(173, 185);
            this.ptrAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrAva.TabIndex = 2;
            this.ptrAva.TabStop = false;
            // 
            // tBPlayerName
            // 
            this.tBPlayerName.Location = new System.Drawing.Point(31, 5);
            this.tBPlayerName.Margin = new System.Windows.Forms.Padding(2);
            this.tBPlayerName.Name = "tBPlayerName";
            this.tBPlayerName.ReadOnly = true;
            this.tBPlayerName.Size = new System.Drawing.Size(118, 20);
            this.tBPlayerName.TabIndex = 0;
            this.tBPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prcTime
            // 
            this.prcTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prcTime.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prcTime.Location = new System.Drawing.Point(2, 217);
            this.prcTime.Margin = new System.Windows.Forms.Padding(2);
            this.prcTime.Name = "prcTime";
            this.prcTime.Size = new System.Drawing.Size(173, 19);
            this.prcTime.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.txbIP);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnRestart);
            this.panel1.Controls.Add(this.btnHowtoplay);
            this.panel1.Location = new System.Drawing.Point(187, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 239);
            this.panel1.TabIndex = 10;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.OrangeRed;
            this.btnConnect.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConnect.Location = new System.Drawing.Point(2, 208);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(104, 28);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txbIP
            // 
            this.txbIP.Cursor = System.Windows.Forms.Cursors.No;
            this.txbIP.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIP.Location = new System.Drawing.Point(4, 185);
            this.txbIP.Margin = new System.Windows.Forms.Padding(2);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(103, 24);
            this.txbIP.TabIndex = 3;
            this.txbIP.Text = "127.0.0.1";
            this.txbIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExit.Location = new System.Drawing.Point(2, 113);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRestart.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRestart.Location = new System.Drawing.Point(2, 59);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(104, 50);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnHowtoplay
            // 
            this.btnHowtoplay.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHowtoplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHowtoplay.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowtoplay.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHowtoplay.Location = new System.Drawing.Point(2, 5);
            this.btnHowtoplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnHowtoplay.Name = "btnHowtoplay";
            this.btnHowtoplay.Size = new System.Drawing.Size(104, 50);
            this.btnHowtoplay.TabIndex = 0;
            this.btnHowtoplay.Text = "How to play";
            this.btnHowtoplay.UseVisualStyleBackColor = false;
            this.btnHowtoplay.Click += new System.EventHandler(this.btnHowtoplay_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbMess);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.ptrAvatar);
            this.panel2.Controls.Add(this.LvShow);
            this.panel2.Location = new System.Drawing.Point(495, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 510);
            this.panel2.TabIndex = 11;
            // 
            // rtbMess
            // 
            this.rtbMess.Location = new System.Drawing.Point(8, 480);
            this.rtbMess.Name = "rtbMess";
            this.rtbMess.Size = new System.Drawing.Size(211, 20);
            this.rtbMess.TabIndex = 12;
            this.rtbMess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbMess_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Caro.Properties.Resources.thegifyouwant1;
            this.pictureBox1.Location = new System.Drawing.Point(8, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Khaki;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtUser.Location = new System.Drawing.Point(148, 15);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(148, 31);
            this.txtUser.TabIndex = 3;
            this.txtUser.Text = "Toàn";
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSend.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSend.Location = new System.Drawing.Point(225, 478);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(71, 29);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // LvShow
            // 
            this.LvShow.HideSelection = false;
            this.LvShow.Location = new System.Drawing.Point(8, 293);
            this.LvShow.Margin = new System.Windows.Forms.Padding(2);
            this.LvShow.Name = "LvShow";
            this.LvShow.Size = new System.Drawing.Size(288, 182);
            this.LvShow.TabIndex = 0;
            this.LvShow.UseCompatibleStateImageBehavior = false;
            this.LvShow.View = System.Windows.Forms.View.List;
            // 
            // Time
            // 
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(795, 547);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "M&M Caro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ptrAvatar.ResumeLayout(false);
            this.ptrAvatar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAva)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel ptrAvatar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox ptrAva;
        private System.Windows.Forms.ProgressBar prcTime;
        private System.Windows.Forms.TextBox tBPlayerName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHowtoplay;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ListView LvShow;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox rtbMess;
    }
}

