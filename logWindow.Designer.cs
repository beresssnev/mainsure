namespace Minesweeper
{
    partial class logWindow
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
            game_stats = new Panel();
            exitButton1 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            regBotton = new Label();
            logIn = new Button();
            label3 = new Label();
            passField = new TextBox();
            label2 = new Label();
            logField = new TextBox();
            game_stats.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // game_stats
            // 
            game_stats.BackColor = SystemColors.MenuHighlight;
            game_stats.Controls.Add(exitButton1);
            game_stats.Controls.Add(label1);
            game_stats.Dock = DockStyle.Top;
            game_stats.Location = new Point(0, 0);
            game_stats.Margin = new Padding(2, 2, 2, 8);
            game_stats.Name = "game_stats";
            game_stats.Size = new Size(797, 88);
            game_stats.TabIndex = 1;
            game_stats.Paint += game_stats_Paint;
            // 
            // exitButton1
            // 
            exitButton1.AutoSize = true;
            exitButton1.Cursor = Cursors.Hand;
            exitButton1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton1.Location = new Point(779, 0);
            exitButton1.Name = "exitButton1";
            exitButton1.Size = new Size(20, 20);
            exitButton1.TabIndex = 1;
            exitButton1.Text = "X";
            exitButton1.Click += exitButton1_Click;
            exitButton1.MouseEnter += exitButton1_MouseEnter;
            exitButton1.MouseLeave += exitButton1_MouseLeave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Font = new Font("Seagull", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(194, 7);
            label1.Name = "label1";
            label1.Size = new Size(426, 75);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(regBotton);
            panel1.Controls.Add(logIn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(logField);
            panel1.Location = new Point(0, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 401);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // regBotton
            // 
            regBotton.AutoSize = true;
            regBotton.Cursor = Cursors.Hand;
            regBotton.Location = new Point(643, 372);
            regBotton.Name = "regBotton";
            regBotton.Size = new Size(151, 20);
            regBotton.TabIndex = 6;
            regBotton.Text = "Зарегистрироваться";
            regBotton.Click += regBotton_Click;
            regBotton.MouseEnter += regBotton_MouseEnter_1;
            regBotton.MouseLeave += regBotton_MouseLeave_1;
            // 
            // logIn
            // 
            logIn.Location = new Point(342, 243);
            logIn.Name = "logIn";
            logIn.Size = new Size(138, 34);
            logIn.TabIndex = 5;
            logIn.Text = "Играть!";
            logIn.UseVisualStyleBackColor = true;
            logIn.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlDarkDark;
            label3.Font = new Font("Seagull", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(320, 138);
            label3.Name = "label3";
            label3.Size = new Size(180, 25);
            label3.TabIndex = 4;
            label3.Text = "Введите пароль:";
            // 
            // passField
            // 
            passField.Location = new Point(220, 163);
            passField.Name = "passField";
            passField.Size = new Size(366, 27);
            passField.TabIndex = 3;
            passField.UseSystemPasswordChar = true;
            passField.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Seagull", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(326, 53);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 2;
            label2.Text = "Введите логин:";
            label2.Click += label2_Click;
            // 
            // logField
            // 
            logField.Location = new Point(220, 78);
            logField.Multiline = true;
            logField.Name = "logField";
            logField.Size = new Size(366, 27);
            logField.TabIndex = 0;
            // 
            // logWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 486);
            Controls.Add(game_stats);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(30, -15);
            Name = "logWindow";
            Text = "Авторизация";
            game_stats.ResumeLayout(false);
            game_stats.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel game_stats;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox logField;
        private TextBox passField;
        private Label label3;
        private Button logIn;
        private Label regBotton;
        private Label exitButton1;
    }
}