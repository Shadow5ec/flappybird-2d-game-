
namespace flappybird
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
            this.scoreText = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.pipebottom2 = new System.Windows.Forms.PictureBox();
            this.pipetop2 = new System.Windows.Forms.PictureBox();
            this.pipetop3 = new System.Windows.Forms.PictureBox();
            this.pipebottom3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom3)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.White;
            this.scoreText.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(424, 1007);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(224, 62);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "score :0";
            this.scoreText.Click += new System.EventHandler(this.label1_Click);
            // 
            // ground
            // 
            this.ground.Image = global::flappybird.Properties.Resources.ground_grass_and_dirt;
            this.ground.Location = new System.Drawing.Point(-16, 963);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(2071, 148);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipebottom
            // 
            this.pipebottom.Image = global::flappybird.Properties.Resources.pipe;
            this.pipebottom.Location = new System.Drawing.Point(435, 620);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(130, 347);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom.TabIndex = 2;
            this.pipebottom.TabStop = false;
            this.pipebottom.Click += new System.EventHandler(this.pipebottom_Click);
            // 
            // pipetop
            // 
            this.pipetop.Image = global::flappybird.Properties.Resources.pipedown;
            this.pipetop.Location = new System.Drawing.Point(718, 12);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(131, 260);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 1;
            this.pipetop.TabStop = false;
            this.pipetop.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // flappybird
            // 
            this.flappybird.Image = global::flappybird.Properties.Resources._151_1515878_flappy_bird_sprite_computer_icons_bird_flight_bird;
            this.flappybird.Location = new System.Drawing.Point(12, 296);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(148, 127);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappybird.TabIndex = 0;
            this.flappybird.TabStop = false;
            this.flappybird.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pipebottom2
            // 
            this.pipebottom2.Image = global::flappybird.Properties.Resources.pipe;
            this.pipebottom2.Location = new System.Drawing.Point(1011, 729);
            this.pipebottom2.Name = "pipebottom2";
            this.pipebottom2.Size = new System.Drawing.Size(144, 228);
            this.pipebottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom2.TabIndex = 5;
            this.pipebottom2.TabStop = false;
            this.pipebottom2.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // pipetop2
            // 
            this.pipetop2.Image = global::flappybird.Properties.Resources.pipedown;
            this.pipetop2.Location = new System.Drawing.Point(1237, 12);
            this.pipetop2.Name = "pipetop2";
            this.pipetop2.Size = new System.Drawing.Size(116, 372);
            this.pipetop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop2.TabIndex = 6;
            this.pipetop2.TabStop = false;
            // 
            // pipetop3
            // 
            this.pipetop3.Image = global::flappybird.Properties.Resources.pipedown;
            this.pipetop3.Location = new System.Drawing.Point(1937, 21);
            this.pipetop3.Name = "pipetop3";
            this.pipetop3.Size = new System.Drawing.Size(118, 183);
            this.pipetop3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop3.TabIndex = 7;
            this.pipetop3.TabStop = false;
            // 
            // pipebottom3
            // 
            this.pipebottom3.Image = global::flappybird.Properties.Resources.pipe;
            this.pipebottom3.Location = new System.Drawing.Point(1718, 507);
            this.pipebottom3.Name = "pipebottom3";
            this.pipebottom3.Size = new System.Drawing.Size(138, 460);
            this.pipebottom3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom3.TabIndex = 8;
            this.pipebottom3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(2068, 1147);
            this.Controls.Add(this.pipebottom3);
            this.Controls.Add(this.pipetop3);
            this.Controls.Add(this.pipetop2);
            this.Controls.Add(this.pipebottom2);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipebottom);
            this.Controls.Add(this.pipetop);
            this.Controls.Add(this.flappybird);
            this.Name = "Form1";
            this.Text = "flappy bird game by shadowsec";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox pipebottom2;
        private System.Windows.Forms.PictureBox pipetop2;
        private System.Windows.Forms.PictureBox pipetop3;
        private System.Windows.Forms.PictureBox pipebottom3;
    }
}

