namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            background = new Panel();
            result = new Label();
            ball = new PictureBox();
            gamepanel = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            loselabel = new Label();
            background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gamepanel).BeginInit();
            SuspendLayout();
            // 
            // background
            // 
            background.Controls.Add(loselabel);
            background.Controls.Add(result);
            background.Controls.Add(ball);
            background.Controls.Add(gamepanel);
            background.Dock = DockStyle.Fill;
            background.Location = new Point(0, 0);
            background.Name = "background";
            background.Size = new Size(861, 504);
            background.TabIndex = 0;
            // 
            // result
            // 
            result.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 18.25F, FontStyle.Bold, GraphicsUnit.Point);
            result.ForeColor = Color.Coral;
            result.Location = new Point(642, 0);
            result.Name = "result";
            result.Size = new Size(165, 35);
            result.TabIndex = 2;
            result.Text = "Результат : 0";
            // 
            // ball
            // 
            ball.BackColor = Color.Yellow;
            ball.Location = new Point(285, 212);
            ball.Name = "ball";
            ball.Size = new Size(50, 50);
            ball.TabIndex = 1;
            ball.TabStop = false;
            // 
            // gamepanel
            // 
            gamepanel.BackColor = Color.Red;
            gamepanel.Location = new Point(263, 447);
            gamepanel.Name = "gamepanel";
            gamepanel.Size = new Size(104, 17);
            gamepanel.TabIndex = 0;
            gamepanel.TabStop = false;
            // 
            // timer
            // 
            timer.Interval = 1;
            timer.Tick += timer_Tick;
            // 
            // loselabel
            // 
            loselabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loselabel.AutoSize = true;
            loselabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            loselabel.Location = new Point(389, 212);
            loselabel.Name = "loselabel";
            loselabel.Size = new Size(143, 41);
            loselabel.TabIndex = 3;
            loselabel.Text = "You lose!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(861, 504);
            Controls.Add(background);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            background.ResumeLayout(false);
            background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ((System.ComponentModel.ISupportInitialize)gamepanel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel background;
        private PictureBox ball;
        private PictureBox gamepanel;
        private System.Windows.Forms.Timer timer;
        private Label result;
        private Label loselabel;
    }
}