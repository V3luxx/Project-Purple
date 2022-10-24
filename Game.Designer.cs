
namespace Kassbrick
{
    partial class Game
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
            this.labelS = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS.Location = new System.Drawing.Point(11, 9);
            this.labelS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(139, 38);
            this.labelS.TabIndex = 0;
            this.labelS.Text = "Score: 0";
            this.labelS.Click += new System.EventHandler(this.labelS_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.LightPink;
            this.ball.Location = new System.Drawing.Point(383, 318);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(33, 33);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.LightSalmon;
            this.player.Location = new System.Drawing.Point(336, 441);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(133, 39);
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(797, 503);
            this.Controls.Add(this.player);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.labelS);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(815, 550);
            this.MinimumSize = new System.Drawing.Size(815, 550);
            this.Name = "Game";
            this.Text = "Kassbrick";
            this.Load += new System.EventHandler(this.Game_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox player;
    }
}