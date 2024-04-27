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
    public partial class regWindow : Form
    {
        public regWindow()
        {
            InitializeComponent();
        }
        private void backBut_MouseEnter(object sender, EventArgs e)
        {
            backBut.ForeColor = Color.White;
        }

        private void backBut_MouseLeave(object sender, EventArgs e)
        {
            backBut.ForeColor = Color.Black;
        }

        private void createAcc_Click(object sender, EventArgs e)
        {
            if (isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`) VALUES (@login, @pass)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = logField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт зарегистрирован");
            else
                MessageBox.Show("Произошла ошибка, повторите еще раз!");

            db.closeConnection();
        }

        public Boolean isUserExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`= @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = logField.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует.");
                return true;
            }
            else
                return false;
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            logWindow back = new logWindow();
  
            back.Show();
        }

        private void exitButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitButton2_MouseEnter(object sender, EventArgs e)
        {
            exitButton2.ForeColor = Color.Red;
        }

        private void exitButton2_MouseLeave(object sender, EventArgs e)
        {
            exitButton2.ForeColor = Color.Black;
        }
    }
}
