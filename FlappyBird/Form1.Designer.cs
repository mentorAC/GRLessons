namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbBird = new System.Windows.Forms.PictureBox();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.pbPipeUp = new System.Windows.Forms.PictureBox();
            this.pbPipeDown = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipeDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBird
            // 
            this.pbBird.Image = global::FlappyBird.Properties.Resources.bird;
            this.pbBird.Location = new System.Drawing.Point(3, 230);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(80, 60);
            this.pbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBird.TabIndex = 0;
            this.pbBird.TabStop = false;
            // 
            // pbGround
            // 
            this.pbGround.Image = global::FlappyBird.Properties.Resources.ground;
            this.pbGround.Location = new System.Drawing.Point(3, 558);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(975, 94);
            this.pbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround.TabIndex = 1;
            this.pbGround.TabStop = false;
            // 
            // pbPipeUp
            // 
            this.pbPipeUp.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pbPipeUp.Location = new System.Drawing.Point(497, -3);
            this.pbPipeUp.Name = "pbPipeUp";
            this.pbPipeUp.Size = new System.Drawing.Size(94, 218);
            this.pbPipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipeUp.TabIndex = 2;
            this.pbPipeUp.TabStop = false;
            // 
            // pbPipeDown
            // 
            this.pbPipeDown.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pbPipeDown.Location = new System.Drawing.Point(752, 360);
            this.pbPipeDown.Name = "pbPipeDown";
            this.pbPipeDown.Size = new System.Drawing.Size(94, 292);
            this.pbPipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipeDown.TabIndex = 3;
            this.pbPipeDown.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(978, 654);
            this.Controls.Add(this.pbBird);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.pbPipeDown);
            this.Controls.Add(this.pbPipeUp);
            this.Name = "Form1";
            this.Text = "Flappy bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipeDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbBird;
        private PictureBox pbGround;
        private PictureBox pbPipeUp;
        private PictureBox pbPipeDown;
        private System.Windows.Forms.Timer timer1;
    }
}