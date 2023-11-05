using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp_tamagotchi
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_name = new System.Windows.Forms.Label();
            this.pictureBox_hero = new System.Windows.Forms.PictureBox();
            this.button_sleep = new System.Windows.Forms.Button();
            this.button_play = new System.Windows.Forms.Button();
            this.button_feed = new System.Windows.Forms.Button();
            this.button_heal = new System.Windows.Forms.Button();
            this.button_walk = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox_sleep = new System.Windows.Forms.PictureBox();
            this.pictureBox_sick = new System.Windows.Forms.PictureBox();
            this.pictureBox_play = new System.Windows.Forms.PictureBox();
            this.pictureBox_walk = new System.Windows.Forms.PictureBox();
            this.pictureBox_hungry = new System.Windows.Forms.PictureBox();
            this.pictureBox_dirty = new System.Windows.Forms.PictureBox();
            this.button_wash = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_walk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hungry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dirty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp_tamagotchi.Resource2.back;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Controls.Add(this.pictureBox_hero);
            this.panel1.Controls.Add(this.button_sleep);
            this.panel1.Controls.Add(this.button_play);
            this.panel1.Controls.Add(this.button_feed);
            this.panel1.Controls.Add(this.button_heal);
            this.panel1.Controls.Add(this.button_walk);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox_sleep);
            this.panel1.Controls.Add(this.pictureBox_sick);
            this.panel1.Controls.Add(this.pictureBox_play);
            this.panel1.Controls.Add(this.pictureBox_walk);
            this.panel1.Controls.Add(this.pictureBox_hungry);
            this.panel1.Controls.Add(this.pictureBox_dirty);
            this.panel1.Controls.Add(this.button_wash);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 641);
            this.panel1.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(12, 17);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(385, 45);
            this.label_name.TabIndex = 19;
            this.label_name.Text = "Take care of me, please!";
            // 
            // pictureBox_hero
            // 
            this.pictureBox_hero.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_hero.Image = global::WindowsFormsApp_tamagotchi.Resource2._happy;
            this.pictureBox_hero.Location = new System.Drawing.Point(214, 80);
            this.pictureBox_hero.Name = "pictureBox_hero";
            this.pictureBox_hero.Size = new System.Drawing.Size(454, 411);
            this.pictureBox_hero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_hero.TabIndex = 18;
            this.pictureBox_hero.TabStop = false;
            // 
            // button_sleep
            // 
            this.button_sleep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_sleep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sleep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_sleep.FlatAppearance.BorderSize = 0;
            this.button_sleep.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sleep.Image = global::WindowsFormsApp_tamagotchi.Resource2.sleep_mask;
            this.button_sleep.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_sleep.Location = new System.Drawing.Point(588, 567);
            this.button_sleep.Name = "button_sleep";
            this.button_sleep.Size = new System.Drawing.Size(282, 62);
            this.button_sleep.TabIndex = 17;
            this.button_sleep.Text = "Put to bed";
            this.button_sleep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sleep.UseVisualStyleBackColor = false;
            this.button_sleep.Click += new System.EventHandler(this.button_sleep_Click);
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_play.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_play.FlatAppearance.BorderSize = 0;
            this.button_play.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_play.Image = global::WindowsFormsApp_tamagotchi.Resource2.play_ball;
            this.button_play.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_play.Location = new System.Drawing.Point(300, 567);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(282, 62);
            this.button_play.TabIndex = 16;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = false;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_feed
            // 
            this.button_feed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_feed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_feed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_feed.FlatAppearance.BorderSize = 0;
            this.button_feed.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_feed.Image = global::WindowsFormsApp_tamagotchi.Resource2.hungry_feed;
            this.button_feed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_feed.Location = new System.Drawing.Point(12, 567);
            this.button_feed.Name = "button_feed";
            this.button_feed.Size = new System.Drawing.Size(282, 62);
            this.button_feed.TabIndex = 15;
            this.button_feed.Text = "Feed";
            this.button_feed.UseVisualStyleBackColor = false;
            this.button_feed.Click += new System.EventHandler(this.button_feed_Click);
            // 
            // button_heal
            // 
            this.button_heal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_heal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_heal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_heal.FlatAppearance.BorderSize = 0;
            this.button_heal.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_heal.Image = global::WindowsFormsApp_tamagotchi.Resource2.sick_heals;
            this.button_heal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_heal.Location = new System.Drawing.Point(588, 499);
            this.button_heal.Name = "button_heal";
            this.button_heal.Size = new System.Drawing.Size(282, 62);
            this.button_heal.TabIndex = 14;
            this.button_heal.Text = "Heal";
            this.button_heal.UseVisualStyleBackColor = false;
            this.button_heal.Click += new System.EventHandler(this.button_heal_Click);
            // 
            // button_walk
            // 
            this.button_walk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_walk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_walk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_walk.FlatAppearance.BorderSize = 0;
            this.button_walk.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_walk.Image = global::WindowsFormsApp_tamagotchi.Resource2.walk_boots;
            this.button_walk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_walk.Location = new System.Drawing.Point(300, 499);
            this.button_walk.Name = "button_walk";
            this.button_walk.Size = new System.Drawing.Size(282, 62);
            this.button_walk.TabIndex = 13;
            this.button_walk.Text = "Take a walk";
            this.button_walk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_walk.UseVisualStyleBackColor = false;
            this.button_walk.Click += new System.EventHandler(this.button_walk_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(674, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 62);
            this.button2.TabIndex = 12;
            this.button2.Text = "Try again";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox_sleep
            // 
            this.pictureBox_sleep.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_sleep.Image = global::WindowsFormsApp_tamagotchi.Resource2.sleep_status;
            this.pictureBox_sleep.Location = new System.Drawing.Point(674, 358);
            this.pictureBox_sleep.Name = "pictureBox_sleep";
            this.pictureBox_sleep.Size = new System.Drawing.Size(196, 133);
            this.pictureBox_sleep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_sleep.TabIndex = 11;
            this.pictureBox_sleep.TabStop = false;
            // 
            // pictureBox_sick
            // 
            this.pictureBox_sick.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_sick.Image = global::WindowsFormsApp_tamagotchi.Resource2.sick_status;
            this.pictureBox_sick.Location = new System.Drawing.Point(674, 219);
            this.pictureBox_sick.Name = "pictureBox_sick";
            this.pictureBox_sick.Size = new System.Drawing.Size(196, 133);
            this.pictureBox_sick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_sick.TabIndex = 10;
            this.pictureBox_sick.TabStop = false;
            // 
            // pictureBox_play
            // 
            this.pictureBox_play.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_play.Image = global::WindowsFormsApp_tamagotchi.Resource2.play_status;
            this.pictureBox_play.Location = new System.Drawing.Point(674, 80);
            this.pictureBox_play.Name = "pictureBox_play";
            this.pictureBox_play.Size = new System.Drawing.Size(196, 133);
            this.pictureBox_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_play.TabIndex = 9;
            this.pictureBox_play.TabStop = false;
            // 
            // pictureBox_walk
            // 
            this.pictureBox_walk.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_walk.Image = global::WindowsFormsApp_tamagotchi.Resource2.walk_status1;
            this.pictureBox_walk.Location = new System.Drawing.Point(12, 358);
            this.pictureBox_walk.Name = "pictureBox_walk";
            this.pictureBox_walk.Size = new System.Drawing.Size(196, 133);
            this.pictureBox_walk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_walk.TabIndex = 8;
            this.pictureBox_walk.TabStop = false;
            // 
            // pictureBox_hungry
            // 
            this.pictureBox_hungry.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_hungry.Image = global::WindowsFormsApp_tamagotchi.Resource2.hungry_status;
            this.pictureBox_hungry.Location = new System.Drawing.Point(12, 219);
            this.pictureBox_hungry.Name = "pictureBox_hungry";
            this.pictureBox_hungry.Size = new System.Drawing.Size(196, 133);
            this.pictureBox_hungry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_hungry.TabIndex = 7;
            this.pictureBox_hungry.TabStop = false;
            // 
            // pictureBox_dirty
            // 
            this.pictureBox_dirty.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_dirty.Image = global::WindowsFormsApp_tamagotchi.Resource2.dirty_status;
            this.pictureBox_dirty.Location = new System.Drawing.Point(12, 80);
            this.pictureBox_dirty.Name = "pictureBox_dirty";
            this.pictureBox_dirty.Size = new System.Drawing.Size(196, 133);
            this.pictureBox_dirty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_dirty.TabIndex = 5;
            this.pictureBox_dirty.TabStop = false;
            // 
            // button_wash
            // 
            this.button_wash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_wash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_wash.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_wash.FlatAppearance.BorderSize = 0;
            this.button_wash.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_wash.Image = global::WindowsFormsApp_tamagotchi.Resource2.dirty_wash;
            this.button_wash.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_wash.Location = new System.Drawing.Point(12, 499);
            this.button_wash.Name = "button_wash";
            this.button_wash.Size = new System.Drawing.Size(282, 62);
            this.button_wash.TabIndex = 4;
            this.button_wash.Text = "Wash";
            this.button_wash.UseVisualStyleBackColor = false;
            this.button_wash.Click += new System.EventHandler(this.button_wash_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 641);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(897, 680);
            this.MinimumSize = new System.Drawing.Size(897, 680);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My puppy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_walk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hungry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dirty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public string pets_name;
        public bool reload=false;
        private bool[] needs = new bool[] { false, false, false, false, false, false };
        private Image[]skins=new Image[8];
        private PictureBox[] pictures=new PictureBox[6];
        private Button[] buttons=new Button[6];
        private string[] sounds = new string[]
        {
                  "I'm very dirty, wash me, please!",
                  "I am hungry! Feed me, please!",
                  "Let's go for a walk!",
                  "Let's play together!",
                  "I am very sick, please help me!",
                  "I'm tired and want to sleep!"
        };

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_dirty;
        private System.Windows.Forms.Button button_sleep;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_feed;
        private System.Windows.Forms.Button button_heal;
        private System.Windows.Forms.Button button_walk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox_sleep;
        private System.Windows.Forms.PictureBox pictureBox_sick;
        private System.Windows.Forms.PictureBox pictureBox_play;
        private System.Windows.Forms.PictureBox pictureBox_walk;
        private System.Windows.Forms.PictureBox pictureBox_hungry;
        private System.Windows.Forms.PictureBox pictureBox_hero;
        private System.Windows.Forms.Button button_wash;
        public System.Windows.Forms.Label label_name;
    }
}