namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int speed_vertical = 4;
        private int speed_horizontal = 4;
        private int score = 0;
        public Form1()
        {
            InitializeComponent();
            timer.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            this.Bounds = Screen.PrimaryScreen.Bounds;
            gamepanel.Top = background.Bottom - (background.Bottom / 10);
            loselabel.Visible = false;
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (e.KeyCode == Keys.R)
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_horizontal = 2;
                score = 0;
                speed_vertical = 2;
                loselabel.Visible=false;
                timer.Enabled=true;
                result.Text = "Результат: 0";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            gamepanel.Left = Cursor.Position.X - (gamepanel.Width / 2);

            ball.Left += speed_horizontal;
            ball.Top += speed_vertical;
            if (ball.Left <= background.Left)
                speed_horizontal *= -1;
            if (ball.Right >= background.Right)
                speed_horizontal *= -1;
            if (ball.Top <= background.Top)
                speed_vertical *= -1;
            if (ball.Bottom >= background.Bottom)
            {
                loselabel.Visible = true;
                timer.Enabled = false;
            }
            if (ball.Bottom >= gamepanel.Top && ball.Bottom <= gamepanel.Bottom && ball.Left >= gamepanel.Left && ball.Right <= gamepanel.Right)
            {
                speed_horizontal += 3;
                speed_vertical += 3;
                speed_vertical *= -1;
                score += 1;
                result.Text = "Результат: " + score.ToString();
                background.BackColor = Color.FromArgb(new Random().Next(150, 255), new Random().Next(150, 255), new Random().Next(150, 255));
            }
        }
    }
}