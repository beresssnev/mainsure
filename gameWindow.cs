using Minesweeper.Properties;
using System.Reflection.Emit;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Minesweeper
{
    public partial class gameWindow : Form
    {
        private Field field;

        private PictureBox FlagPicture;


        private Label FlagTextLable;

        public gameWindow()
        {
            InitializeComponent();
            InitializeLogic();
        }


        private void InitializeLogic()
        {
            field = new Field(Difficulty.EASY, this);

            field.Location = new Point(100, 100);
            difficulty_selector.SelectedIndex = 0;
            Controls.Add(field);

            // 
            // picture
            // 
            FlagPicture = new PictureBox();
            panel_flag.Controls.Add(FlagPicture);
            FlagPicture.Image = Image.FromFile("../../../assets/flag.png");
            FlagPicture.SizeMode = PictureBoxSizeMode.Zoom;
            FlagPicture.Location = new Point(5, 12);
            FlagPicture.Name = "flag_box";
            FlagPicture.Size = new Size(50, 52);
            FlagPicture.TabIndex = 0;
            FlagPicture.TabStop = false;

            /// 
            /// lable
            /// 

            FlagTextLable = new Label();

            panel_flag.Controls.Add(FlagTextLable);

            FlagTextLable.AutoSize = true;
            FlagTextLable.Location = new Point(76, 22);
            FlagTextLable.Name = "FlagTextLable";
            FlagTextLable.Size = new Size(59, 25);
            FlagTextLable.TabIndex = 1;
            FlagTextLable.Font = new Font(FlagTextLable.Font.FontFamily, 10, FontStyle.Bold);
            FlagTextLable.Text = "No Bomb Flag";

            Reset();
        }

        public void SetFlagLable(string s)
        {
            FlagTextLable.Text = s;
        }


        private void difficulty_selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            switch (difficulty_selector.SelectedIndex)
            {

                case 0:
                    Controls.Remove(field);
                    field = new Field(Difficulty.EASY, this);
                    Controls.Add(field);
                    SetMinSize();
                    KeepFieldCenter();
                    break;
                case 1:
                    Controls.Remove(field);
                    field = new Field(Difficulty.MEDIUM, this);
                    Controls.Add(field);
                    SetMinSize();
                    KeepFieldCenter();
                    break;
                case 2:
                    Controls.Remove(field);
                    field = new Field(Difficulty.HARD, this);
                    Controls.Add(field);
                    KeepFieldCenter();
                    SetMinSize();
                    break;
            }
            if (FlagTextLable != null)
            {
                FlagTextLable.Text = "No Bomb Flag";
            }
        }


        // keep it center when rezized
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            KeepFieldCenter();
        }

        private void KeepFieldCenter()
        {
            if (field != null)
            {
                int height_game_stats = game_stats.Height;

                // Calculate the new position of the button when the form is resized
                int width = field.Width;
                int height = field.Height - height_game_stats;
                int x = (ClientSize.Width - width) / 2; // Center horizontally
                int y = (ClientSize.Height - height) / 2; // Center vertically

                // Set the new position of the button
                field.Location = new System.Drawing.Point(x, y);
            }
        }

        private void SetMinSize()
        {
            int min_height = field.Height + game_stats.Height + 100;
            int min_width = Math.Max(field.Width + 100, 750);

            MinimumSize = new System.Drawing.Size(min_width, min_height);
        }
        private void Window_Load(object sender, EventArgs e)
        {

        }

        private void reset_burron_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // tell the player he as won
        public void MessageWin()
        {
            // Create a new instance of the form
            Form form = new Form();
            form.MaximumSize = new Size(400, 250);
            form.MinimumSize = new Size(400, 250);
            // Create a label with the message
            Label label = new Label();
            label.Text = "You Win!";
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            label.Location = new System.Drawing.Point(0, 0);
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label.ForeColor = System.Drawing.Color.Green;

            // Create an OK button
            Button button = new Button();
            button.Text = "OK";
            button.AutoSize = true;
            button.Location = new System.Drawing.Point(290, 150);
            button.Click += (sender, e) =>
            {
                // Close the form when the button is clicked
                form.Close();
            };

            // Add the label and button to the form
            form.Controls.Add(label);
            form.Controls.Add(button);

            // Set the form properties
            form.Text = "Congrats!";
            form.AutoSize = true;
            form.StartPosition = FormStartPosition.CenterScreen;

            form.Show();
        }

        // tel the player he has lose
        public void MessageLose()
        {
            // Create a new instance of the form
            Form form = new Form();

            form.MaximumSize = new Size(400, 250);
            form.MinimumSize = new Size(400, 250);

            // Create a label with the message
            Label label = new Label();
            label.Text = "You Lost!";
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            label.Size = new Size(20, 50);
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label.ForeColor = System.Drawing.Color.Red;

            // Create an OK button
            Button button = new Button();
            button.Text = "OK";
            button.AutoSize = true;
            button.Location = new System.Drawing.Point(290, 150);
            button.Click += (sender, e) =>
            {
                // Close the form when the button is clicked
                form.Close();
            };

            // Add the label and button to the form
            form.Controls.Add(label);
            form.Controls.Add(button);

            // Set the form properties
            form.Text = "Oops!";
            form.AutoSize = true;
            form.StartPosition = FormStartPosition.CenterScreen;

            form.Show();
        }

        private void panel_flag_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitButton3_MouseEnter(object sender, EventArgs e)
        {
            exitButton3.ForeColor = Color.Red;
        }

        private void exitButton3_MouseLeave_1(object sender, EventArgs e)
        {
            exitButton3.ForeColor = Color.Black;
        }

        private void exitButton3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}