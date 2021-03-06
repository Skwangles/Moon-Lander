﻿namespace Moon_Lander
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
            this.Lander = new System.Windows.Forms.PictureBox();
            this.TrackBar = new System.Windows.Forms.TrackBar();
            this.FuelBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Label();
            this.Pad = new System.Windows.Forms.PictureBox();
            this.Bottempanel = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.speedtrav = new System.Windows.Forms.Label();
            this.Moonscape = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Movetmr = new System.Windows.Forms.Timer(this.components);
            this.SuccessFaillbl = new System.Windows.Forms.Label();
            this.Butt = new System.Windows.Forms.Button();
            this.PB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Lander)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bottempanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moonscape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Lander
            // 
            this.Lander.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lander.Location = new System.Drawing.Point(362, 12);
            this.Lander.Name = "Lander";
            this.Lander.Size = new System.Drawing.Size(37, 35);
            this.Lander.TabIndex = 1;
            this.Lander.TabStop = false;
            // 
            // TrackBar
            // 
            this.TrackBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TrackBar.Location = new System.Drawing.Point(132, 387);
            this.TrackBar.Maximum = 5;
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.Size = new System.Drawing.Size(449, 45);
            this.TrackBar.TabIndex = 2;
            // 
            // FuelBar
            // 
            this.FuelBar.Location = new System.Drawing.Point(639, 393);
            this.FuelBar.Name = "FuelBar";
            this.FuelBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FuelBar.Size = new System.Drawing.Size(129, 35);
            this.FuelBar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(690, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fuel";
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Speed.Location = new System.Drawing.Point(22, 393);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(65, 13);
            this.Speed.TabIndex = 5;
            this.Speed.Text = "Speed (m/s)";
            // 
            // Pad
            // 
            this.Pad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pad.Location = new System.Drawing.Point(327, 332);
            this.Pad.Name = "Pad";
            this.Pad.Size = new System.Drawing.Size(113, 17);
            this.Pad.TabIndex = 6;
            this.Pad.TabStop = false;
            // 
            // Bottempanel
            // 
            this.Bottempanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bottempanel.Location = new System.Drawing.Point(1, 349);
            this.Bottempanel.Margin = new System.Windows.Forms.Padding(0);
            this.Bottempanel.Name = "Bottempanel";
            this.Bottempanel.Size = new System.Drawing.Size(799, 102);
            this.Bottempanel.TabIndex = 7;
            this.Bottempanel.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thrust";
            // 
            // speedtrav
            // 
            this.speedtrav.AutoSize = true;
            this.speedtrav.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.speedtrav.Location = new System.Drawing.Point(22, 415);
            this.speedtrav.Name = "speedtrav";
            this.speedtrav.Size = new System.Drawing.Size(28, 13);
            this.speedtrav.TabIndex = 9;
            this.speedtrav.Text = "0.00";
            // 
            // Moonscape
            // 
            this.Moonscape.Location = new System.Drawing.Point(1, 0);
            this.Moonscape.Margin = new System.Windows.Forms.Padding(0);
            this.Moonscape.Name = "Moonscape";
            this.Moonscape.Size = new System.Drawing.Size(799, 349);
            this.Moonscape.TabIndex = 10;
            this.Moonscape.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(94, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "0.00";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(34, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(71, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(11, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "X:";
            // 
            // Movetmr
            // 
            this.Movetmr.Tick += new System.EventHandler(this.Movetmr_Tick);
            // 
            // SuccessFaillbl
            // 
            this.SuccessFaillbl.AutoSize = true;
            this.SuccessFaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessFaillbl.Location = new System.Drawing.Point(262, 147);
            this.SuccessFaillbl.Name = "SuccessFaillbl";
            this.SuccessFaillbl.Size = new System.Drawing.Size(119, 31);
            this.SuccessFaillbl.TabIndex = 15;
            this.SuccessFaillbl.Text = "WinLose";
            // 
            // Butt
            // 
            this.Butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt.Location = new System.Drawing.Point(297, 147);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(203, 47);
            this.Butt.TabIndex = 17;
            this.Butt.Text = "Start Game";
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.button2_Click);
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(1, 0);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(799, 451);
            this.PB.TabIndex = 18;
            this.PB.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Butt);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.SuccessFaillbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.speedtrav);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pad);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FuelBar);
            this.Controls.Add(this.TrackBar);
            this.Controls.Add(this.Lander);
            this.Controls.Add(this.Bottempanel);
            this.Controls.Add(this.Moonscape);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Lander)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bottempanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moonscape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Lander;
        private System.Windows.Forms.TrackBar TrackBar;
        private System.Windows.Forms.ProgressBar FuelBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.PictureBox Pad;
        private System.Windows.Forms.PictureBox Bottempanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label speedtrav;
        private System.Windows.Forms.PictureBox Moonscape;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer Movetmr;
        private System.Windows.Forms.Label SuccessFaillbl;
        private System.Windows.Forms.Button Butt;
        private System.Windows.Forms.PictureBox PB;
    }
}