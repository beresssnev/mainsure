namespace Minesweeper
{
    partial class regWindow
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
            panel1 = new Panel();
            createAcc = new Button();
            backBut = new Label();
            label3 = new Label();
            passField = new TextBox();
            label2 = new Label();
            logField = new TextBox();
            game_stats = new Panel();
            exitButton2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            game_stats.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(createAcc);
            panel1.Controls.Add(backBut);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(logField);
            panel1.Location = new Point(0, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 366);
            panel1.TabIndex = 3;
            // 
            // createAcc
            // 
            createAcc.Location = new Point(350, 235);
            createAcc.Name = "createAcc";
            createAcc.Size = new Size(108, 32);
            createAcc.TabIndex = 7;
            createAcc.Text = "Создать!";
            createAcc.UseVisualStyleBackColor = true;
            createAcc.Click += createAcc_Click;
            // 
            // backBut
            // 
            backBut.AutoSize = true;
            backBut.Location = new Point(738, 337);
            backBut.Name = "backBut";
            backBut.Size = new Size(51, 20);
            backBut.TabIndex = 6;
            backBut.Text = "Назад";
            backBut.Click += backBut_Click;
            backBut.MouseEnter += backBut_MouseEnter;
            backBut.MouseLeave += backBut_MouseLeave;
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
            // 
            // logField
            // 
            logField.Location = new Point(220, 78);
            logField.Multiline = true;
            logField.Name = "logField";
            logField.Size = new Size(366, 27);
            logField.TabIndex = 0;
            // 
            // game_stats
            // 
            game_stats.BackColor = SystemColors.MenuHighlight;
            game_stats.Controls.Add(exitButton2);
            game_stats.Controls.Add(label1);
            game_stats.Dock = DockStyle.Top;
            game_stats.Location = new Point(0, 0);
            game_stats.Margin = new Padding(2, 2, 2, 8);
            game_stats.Name = "game_stats";
            game_stats.Size = new Size(800, 94);
            game_stats.TabIndex = 4;
            // 
            // exitButton2
            // 
            exitButton2.AutoSize = true;
            exitButton2.Cursor = Cursors.Hand;
            exitButton2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton2.Location = new Point(779, 1);
            exitButton2.Name = "exitButton2";
            exitButton2.Size = new Size(20, 20);
            exitButton2.TabIndex = 2;
            exitButton2.Text = "X";
            exitButton2.Click += exitButton2_Click;
            exitButton2.MouseEnter += exitButton2_MouseEnter;
            exitButton2.MouseLeave += exitButton2_MouseLeave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Font = new Font("Seagull", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(187, 6);
            label1.Name = "label1";
            label1.Size = new Size(426, 75);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            // 
            // regWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(game_stats);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "regWindow";
            Text = "Регистрация";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            game_stats.ResumeLayout(false);
            game_stats.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox passField;
        private Label label2;
        private TextBox logField;
        private Panel game_stats;
        private Label label1;
        private Label backBut;
        private Button createAcc;
        private Label exitButton2;
    }
}