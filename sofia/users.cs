using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sofia
{
    public partial class users : Form
    {
        readonly user _user;
        private SqlConnection sql_connection = null;
        public users(user user)
        {
            InitializeComponent();
            _user = user;
        }

        private void users_Load(object sender, EventArgs e)
        {
            sql_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
            sql_connection.Open();
            switch (_user.role)
            {
                case "husband":
                    this.usersTableAdapter.Fill(this.database1DataSet.users);
                    break;
                case "wife":
                    this.usersTableAdapter.Fill(this.database1DataSet.users);
                    break;
                case "kid":
                    this.usersTableAdapter.FillByCurrentUserId(this.database1DataSet.users, _user.id);
                    insert_button.Visible = false;
                    delete_button.Visible = false;
                    update_button.Visible = false;
                    select_button.Visible = false;
                    break;
                default:
                    MessageBox.Show("Некорректный запрос");
                    break;
            }
        }
        DataTable FillDataGridView(string sqlSelect)
        {
            //Создаем объект command для SQL команды
            SqlCommand command = sql_connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результата запроса
            DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C) ТУСУР, БИС, Букина София Германовна, 740-1, 2022", "О программе",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            categories categories = new categories(_user);
            categories.Show();
        }

        private void transactionsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            transaction_types tr_type = new transaction_types(_user);
            tr_type.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            transactions transactions = new transactions(_user);
            transactions.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlcommand = "INSERT INTO users (surname, name, middlename, role, login, password) " +
                "VALUES (@surname, @name, @middlename, @role, @login, @password)";
                SqlCommand command = sql_connection.CreateCommand();
                command.CommandText = sqlcommand;
                command.Parameters.AddWithValue("@surname", surname_txt_users.Text);
                command.Parameters.AddWithValue("@name", name_txt_users.Text);
                command.Parameters.AddWithValue("@middlename", middlename_txt_users.Text);
                command.Parameters.AddWithValue("@role", comboBox1.SelectedItem.ToString());
                command.Parameters.AddWithValue("@login", login_txt_users.Text);
                command.Parameters.AddWithValue("@password", password_txt_users.Text);
                command.ExecuteNonQuery();
                dataGridView1.DataSource = FillDataGridView("select * FROM users");
                MessageBox.Show("Succesfully inserted", "Success", MessageBoxButtons.OK);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error query.\n" + err.Message,
                "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlcommand = "DELETE FROM users WHERE Id = @id";
                SqlCommand command = sql_connection.CreateCommand();
                command.CommandText = sqlcommand;
                command.Parameters.AddWithValue("@id", Convert.ToInt32(id_txt_users.Text));
                command.ExecuteNonQuery();
                dataGridView1.DataSource = FillDataGridView("select * FROM users");
                MessageBox.Show("Succesfully deleted", "Success", MessageBoxButtons.OK);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error query.\n" + err.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlcommand = "UPDATE users SET login = @login, password=@password WHERE Id = @Id";
                SqlCommand command = sql_connection.CreateCommand();
                command.CommandText = sqlcommand;
                command.Parameters.AddWithValue("@Id", Convert.ToInt32(id_txt_users.Text));
                command.Parameters.AddWithValue("@login", login_txt_users.Text);
                command.Parameters.AddWithValue("@password", password_txt_users.Text);
                command.ExecuteNonQuery();
                dataGridView1.DataSource = FillDataGridView("select * FROM users");
                MessageBox.Show("Succesfully updated", "Success", MessageBoxButtons.OK);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error query.\n" + err.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void select_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FillDataGridView("select * FROM users");
        }

        private void insert_button_MouseEnter(object sender, EventArgs e)
        {
            insert_button.BackColor = Color.Silver;
        }

        private void insert_button_MouseLeave(object sender, EventArgs e)
        {
            insert_button.BackColor = Color.White;
        }

        private void delete_button_MouseEnter(object sender, EventArgs e)
        {
            delete_button.BackColor = Color.Silver;
        }

        private void delete_button_MouseLeave(object sender, EventArgs e)
        {
            delete_button.BackColor = Color.White;
        }

        private void update_button_MouseEnter(object sender, EventArgs e)
        {
            update_button.BackColor = Color.Silver;
        }

        private void update_button_MouseLeave(object sender, EventArgs e)
        {
            update_button.BackColor = Color.White;
        }

        private void select_button_MouseEnter(object sender, EventArgs e)
        {
            select_button.BackColor = Color.Silver;
        }

        private void select_button_MouseLeave(object sender, EventArgs e)
        {
            select_button.BackColor = Color.White;
        }
    }
}
