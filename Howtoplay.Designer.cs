namespace Caro
{
    partial class Howtoplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Howtoplay));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbtitle = new System.Windows.Forms.PictureBox();
            this.rtbHowtoplay = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbtitle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(8, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 255);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Caro.Properties.Resources.tenor;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ptbtitle);
            this.panel2.Controls.Add(this.rtbHowtoplay);
            this.panel2.Location = new System.Drawing.Point(262, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 255);
            this.panel2.TabIndex = 1;
            // 
            // ptbtitle
            // 
            this.ptbtitle.BackColor = System.Drawing.Color.White;
            this.ptbtitle.Image = global::Caro.Properties.Resources.bloggif_5edda4de96c6c;
            this.ptbtitle.Location = new System.Drawing.Point(2, 2);
            this.ptbtitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptbtitle.Name = "ptbtitle";
            this.ptbtitle.Size = new System.Drawing.Size(238, 58);
            this.ptbtitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbtitle.TabIndex = 3;
            this.ptbtitle.TabStop = false;
            // 
            // rtbHowtoplay
            // 
            this.rtbHowtoplay.BackColor = System.Drawing.Color.White;
            this.rtbHowtoplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbHowtoplay.Enabled = false;
            this.rtbHowtoplay.Font = new System.Drawing.Font("Comic Sans MS", 10.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHowtoplay.Location = new System.Drawing.Point(2, 67);
            this.rtbHowtoplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbHowtoplay.Name = "rtbHowtoplay";
            this.rtbHowtoplay.Size = new System.Drawing.Size(238, 185);
            this.rtbHowtoplay.TabIndex = 2;
            this.rtbHowtoplay.Text = resources.GetString("rtbHowtoplay.Text");
            this.rtbHowtoplay.TextChanged += new System.EventHandler(this.rtbHowtoplay_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExit.Location = new System.Drawing.Point(387, 269);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 42);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "LET\'S PLAY";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Howtoplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(511, 321);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Howtoplay";
            this.Text = "Howtoplay";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbtitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbHowtoplay;
        private System.Windows.Forms.PictureBox ptbtitle;
        private System.Windows.Forms.Button btnExit;
    }
}