using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class logWindow : Form
    {
        public logWindow()
        {
            InitializeComponent();
            this.passField.AutoSize = false;
        }


        private void game_stats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = logField.Text;
            String passUser = passField.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`= @uL AND `password`=@uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                gameWindow saper = new gameWindow();
                saper.Show();
            }
            else
                MessageBox.Show("Попробуйте еще раз!");
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void logField_TextChanged(object sender, EventArgs e)
        {

        }
        private void regBotton_Click(object sender, EventArgs e)
        {
            this.Hide();
            regWindow register = new regWindow();

            register.Show();
        }
        private void regBotton_MouseEnter_1(object sender, EventArgs e)
        {
            regBotton.ForeColor = Color.Gray;
        }
        private void regBotton_MouseLeave_1(object sender, EventArgs e)
        {
            regBotton.ForeColor = Color.Black;
        }
        private void exitButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void exitButton1_MouseEnter(object sender, EventArgs e)
        {
            exitButton1.ForeColor = Color.Red;
        }

        private void exitButton1_MouseLeave(object sender, EventArgs e)
        {
            exitButton1.ForeColor = Color.Black;
        }
    }
}
