
namespace BIRD_GAME
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
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.pipbottom = new System.Windows.Forms.PictureBox();
            this.piptop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipbottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piptop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // flappybird
            // 
            this.flappybird.Image = ((System.Drawing.Image)(resources.GetObject("flappybird.Image")));
            this.flappybird.Location = new System.Drawing.Point(358, 197);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(119, 81);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappybird.TabIndex = 0;
            this.flappybird.TabStop = false;
            // 
            // pipbottom
            // 
            this.pipbottom.Image = global::BIRD_GAME.Properties.Resources.pipeBottom;
            this.pipbottom.Location = new System.Drawing.Point(736, 356);
            this.pipbottom.Name = "pipbottom";
            this.pipbottom.Size = new System.Drawing.Size(100, 141);
            this.pipbottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipbottom.TabIndex = 1;
            this.pipbottom.TabStop = false;
            // 
            // piptop
            // 
            this.piptop.Image = global::BIRD_GAME.Properties.Resources.pipeTop;
            this.piptop.Location = new System.Drawing.Point(860, 9);
            this.piptop.Name = "piptop";
            this.piptop.Size = new System.Drawing.Size(104, 172);
            this.piptop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piptop.TabIndex = 2;
            this.piptop.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-8, 503);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1392, 69);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Wide Latin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(1, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(176, 23);
            this.score.TabIndex = 6;
            this.score.Text = "SCORE:0";
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.gametimer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1387, 573);
            this.Controls.Add(this.score);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.piptop);
            this.Controls.Add(this.pipbottom);
            this.Controls.Add(this.flappybird);
            this.Name = "Form1";
            this.Text = "FLAPPY BIRD GAME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameup);
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipbottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piptop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.PictureBox pipbottom;
        private System.Windows.Forms.PictureBox piptop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer timer;
    }
}

