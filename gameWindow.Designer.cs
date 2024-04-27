

namespace Minesweeper
{
    partial class gameWindow
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
            game_stats = new Panel();
            panel_flag = new Panel();
            gamemode_selector_pannel = new Panel();
            difficulty_selector = new ComboBox();
            reset_pannel = new Panel();
            exitButton3 = new Label();
            reset_button = new Button();
            game_stats.SuspendLayout();
            gamemode_selector_pannel.SuspendLayout();
            reset_pannel.SuspendLayout();
            SuspendLayout();
            // 
            // game_stats
            // 
            game_stats.BackColor = SystemColors.MenuHighlight;
            game_stats.Controls.Add(panel_flag);
            game_stats.Controls.Add(gamemode_selector_pannel);
            game_stats.Controls.Add(reset_pannel);
            game_stats.Dock = DockStyle.Top;
            game_stats.Location = new Point(0, 0);
            game_stats.Margin = new Padding(2, 2, 2, 8);
            game_stats.Name = "game_stats";
            game_stats.Size = new Size(760, 62);
            game_stats.TabIndex = 0;
            // 
            // panel_flag
            // 
            panel_flag.Location = new Point(138, 0);
            panel_flag.Margin = new Padding(2);
            panel_flag.Name = "panel_flag";
            panel_flag.Size = new Size(209, 62);
            panel_flag.TabIndex = 2;
            panel_flag.Paint += panel_flag_Paint;
            // 
            // gamemode_selector_pannel
            // 
            gamemode_selector_pannel.BackColor = SystemColors.MenuHighlight;
            gamemode_selector_pannel.Controls.Add(difficulty_selector);
            gamemode_selector_pannel.Dock = DockStyle.Left;
            gamemode_selector_pannel.Location = new Point(0, 0);
            gamemode_selector_pannel.Margin = new Padding(2);
            gamemode_selector_pannel.Name = "gamemode_selector_pannel";
            gamemode_selector_pannel.Size = new Size(139, 62);
            gamemode_selector_pannel.TabIndex = 1;
            // 
            // difficulty_selector
            // 
            difficulty_selector.Anchor = AnchorStyles.None;
            difficulty_selector.AutoCompleteCustomSource.AddRange(new string[] { "Easy" });
            difficulty_selector.BackColor = SystemColors.ControlLightLight;
            difficulty_selector.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            difficulty_selector.Location = new Point(22, 17);
            difficulty_selector.Margin = new Padding(2);
            difficulty_selector.Name = "difficulty_selector";
            difficulty_selector.Size = new Size(88, 28);
            difficulty_selector.TabIndex = 0;
            difficulty_selector.SelectedIndexChanged += difficulty_selector_SelectedIndexChanged;
            // 
            // reset_pannel
            // 
            reset_pannel.BackColor = SystemColors.MenuHighlight;
            reset_pannel.Controls.Add(exitButton3);
            reset_pannel.Controls.Add(reset_button);
            reset_pannel.Dock = DockStyle.Right;
            reset_pannel.Location = new Point(502, 0);
            reset_pannel.Margin = new Padding(2);
            reset_pannel.Name = "reset_pannel";
            reset_pannel.Size = new Size(258, 62);
            reset_pannel.TabIndex = 0;
            // 
            // exitButton3
            // 
            exitButton3.AutoSize = true;
            exitButton3.Cursor = Cursors.Hand;
            exitButton3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton3.Location = new Point(237, 0);
            exitButton3.Name = "exitButton3";
            exitButton3.Size = new Size(20, 20);
            exitButton3.TabIndex = 3;
            exitButton3.Text = "X";
            exitButton3.Click += exitButton3_Click_1;
            exitButton3.MouseEnter += exitButton3_MouseEnter;
            exitButton3.MouseLeave += exitButton3_MouseLeave_1;
            // 
            // reset_button
            // 
            reset_button.BackColor = Color.DarkSalmon;
            reset_button.Location = new Point(95, 18);
            reset_button.Margin = new Padding(2);
            reset_button.Name = "reset_button";
            reset_button.Size = new Size(86, 27);
            reset_button.TabIndex = 0;
            reset_button.Text = "ЗАНОВО";
            reset_button.UseVisualStyleBackColor = false;
            reset_button.Click += reset_burron_Click;
            // 
            // gameWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(760, 416);
            Controls.Add(game_stats);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "gameWindow";
            Text = "Minesweeper";
            Load += Window_Load;
            game_stats.ResumeLayout(false);
            gamemode_selector_pannel.ResumeLayout(false);
            reset_pannel.ResumeLayout(false);
            reset_pannel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel game_stats;
        private Panel gamemode_selector_pannel;
        private Panel reset_pannel;
        private ComboBox difficulty_selector;
        private Panel panel_flag;
        private Button reset_button;
        private Label exitButton3;
    }
}