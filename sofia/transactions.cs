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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sofia
{
    public partial class transactions : Form
    {
        readonly user _user;
        private SqlConnection sql_connection = null;
        public transactions(user user)
        {
            _user = user;
            InitializeComponent();
        }

        private void transactions_Load(object sender, EventArgs e)
        {
            sql_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
            sql_connection.Open();
            switch (_user.role)
            {
                case "husband":
                    this.transactionsTableAdapter.Fill(this.database1DataSet2.transactions);
                    break;
                case "wife":
                    this.transactionsTableAdapter.Fill(this.database1DataSet2.transactions);
                    break;
                case "kid":
                    this.transactionsTableAdapter.FillByCurrentUserId(this.database1DataSet2.transactions, _user.id);
                    insert_button.Visible = false;
                    delete_button.Visible = false;
                    update_button.Visible = false;
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlcommand = "INSERT INTO transactions (category_id, transaction_type_id, user_id, cost, date) " +
                "VALUES ((SELECT Id FROM categories WHERE category_name = @category_name), " +
                "(SELECT Id FROM transaction_types WHERE transaction_name = @transaction_type_name), @user_id, @cost, @date)";
                SqlCommand command = sql_connection.CreateCommand();
                command.CommandText = sqlcommand;
                command.Parameters.AddWithValue("@category_name", category_box.Text);
                command.Parameters.AddWithValue("@transaction_type_name", transactions_box.Text);
                command.Parameters.AddWithValue("@user_id", Convert.ToInt32(userid_txt_transaction.Text));
                command.Parameters.AddWithValue("@cost", Convert.ToDecimal(cost_txt_transaction.Text));
                command.Parameters.AddWithValue("@date", Convert.ToDateTime(transdate_trasactions.Value));
                command.ExecuteNonQuery();
                dataGridView1.DataSource = FillDataGridView("select * FROM transactions");
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
                string sqlcommand = "DELETE FROM transactions WHERE Id = @id";
                SqlCommand command = sql_connection.CreateCommand();
                command.CommandText = sqlcommand;
                command.Parameters.AddWithValue("@id", Convert.ToInt32(id_txt_transaction.Text));
                command.ExecuteNonQuery();
                dataGridView1.DataSource = FillDataGridView("select * FROM transactions");
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
                string sqlcommand = "UPDATE transactions SET category_id = (SELECT Id FROM categories WHERE category_name = @category_name), cost = @cost, " +
                    "user_id = @user_id, transaction_type_id = (SELECT Id FROM transaction_types WHERE transaction_name = @transaction_name), date = @date WHERE Id = @Id";
                SqlCommand command = sql_connection.CreateCommand();
                command.CommandText = sqlcommand;
                command.Parameters.AddWithValue("@Id", Convert.ToInt32(id_txt_transaction.Text));
                command.Parameters.AddWithValue("@category_name", category_box.Text);
                command.Parameters.AddWithValue("@cost", Convert.ToDecimal(cost_txt_transaction.Text));
                command.Parameters.AddWithValue("@user_id", Convert.ToInt32(userid_txt_transaction.Text));
                command.Parameters.AddWithValue("@transaction_name", transactions_box.Text);
                command.Parameters.AddWithValue("@date", Convert.ToDateTime(transdate_trasactions.Value));
                command.ExecuteNonQuery();
                dataGridView1.DataSource = FillDataGridView("select * FROM transactions");
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
            SqlCommand thisCommand = sql_connection.CreateCommand();
            SqlDataReader thisReader = null; 
            var answer = "";
            switch (_user.role)
            {
                case "husband":
                    if(transactions_box.Text == "income")
                    {
                        thisCommand.CommandText = $"SELECT SUM(cost) as 'Sum', categories.category_name FROM transactions join categories on category_id = categories.Id WHERE transaction_type_id = '4' and (date BETWEEN @date_from AND @date_to) group by categories.category_name";
                        thisCommand.Parameters.AddWithValue("@date_from", Convert.ToDateTime(transdate_from.Value));
                        thisCommand.Parameters.AddWithValue("@date_to", Convert.ToDateTime(transdate_to.Value));
                        thisReader = thisCommand.ExecuteReader();
                        break;
                    }
                    else if(transactions_box.Text == "outcome")
                    {
                        thisCommand.CommandText = $"SELECT SUM(cost) as 'Sum', categories.category_name FROM transactions join categories on category_id = categories.Id WHERE transaction_type_id = '5' and (date BETWEEN @date_from AND @date_to) group by categories.category_name";
                        thisCommand.Parameters.AddWithValue("@date_from", Convert.ToDateTime(transdate_from.Value));
                        thisCommand.Parameters.AddWithValue("@date_to", Convert.ToDateTime(transdate_to.Value));
                        thisReader = thisCommand.ExecuteReader();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Выберите опцию");
                        break;
                    }
                case "wife":
                    if (transactions_box.Text == "income")
                    {
                        thisCommand.CommandText = $"SELECT SUM(cost) as 'Sum', categories.category_name FROM transactions join categories on category_id = categories.Id WHERE transaction_type_id = '4' and (date BETWEEN @date_from AND @date_to) group by categories.category_name";
                        thisCommand.Parameters.AddWithValue("@date_from", Convert.ToDateTime(transdate_from.Value));
                        thisCommand.Parameters.AddWithValue("@date_to", Convert.ToDateTime(transdate_to.Value));
                        thisReader = thisCommand.ExecuteReader();
                        break;
                    }
                    else if(transactions_box.Text == "outcome")
                    {
                        thisCommand.CommandText = $"SELECT SUM(cost) as 'Sum', categories.category_name FROM transactions join categories on category_id = categories.Id WHERE transaction_type_id = '5' and (date BETWEEN @date_from AND @date_to) group by categories.category_name";
                        thisCommand.Parameters.AddWithValue("@date_from", Convert.ToDateTime(transdate_from.Value));
                        thisCommand.Parameters.AddWithValue("@date_to", Convert.ToDateTime(transdate_to.Value));
                        thisReader = thisCommand.ExecuteReader();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Выберите опцию");
                        break;
                    }
                case "kid":
                    if (transactions_box.Text == "income")
                    {
                        thisCommand.CommandText = $"SELECT SUM(cost) as 'Sum', categories.category_name FROM transactions join categories on category_id = categories.Id WHERE user_id={_user.id} and transaction_type_id = '4' and (date BETWEEN @date_from AND @date_to) group by categories.category_name";
                        thisCommand.Parameters.AddWithValue("@date_from", Convert.ToDateTime(transdate_from.Value));
                        thisCommand.Parameters.AddWithValue("@date_to", Convert.ToDateTime(transdate_to.Value));
                        thisReader = thisCommand.ExecuteReader();
                        break;
                    }
                    else if(transactions_box.Text == "outcome")
                    {
                        thisCommand.CommandText = $"SELECT SUM(cost) as 'Sum', categories.category_name FROM transactions join categories on category_id = categories.Id WHERE user_id={_user.id} and transaction_type_id = '5' and (date BETWEEN @date_from AND @date_to) group by categories.category_name";
                        thisCommand.Parameters.AddWithValue("@date_from", Convert.ToDateTime(transdate_from.Value));
                        thisCommand.Parameters.AddWithValue("@date_to", Convert.ToDateTime(transdate_to.Value));
                        thisReader = thisCommand.ExecuteReader();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Выберите опцию");
                        break;
                    }
                default:
                    MessageBox.Show("Некорректный запрос");
                    break;
            }
            if(thisReader!=null)
            {
                while (thisReader.Read())
                {
                    if (thisReader["Sum"] == null)
                    {
                        MessageBox.Show("Нет транзакций за этот период");
                    }
                    else if (thisReader["Sum"] != null && Convert.ToDouble(thisReader["Sum"].ToString()) >0)
                    {
                        answer += $"{thisReader["Sum"].ToString()} ";
                        answer += $"{thisReader["category_name"].ToString()} \n";
                    }
                }

                if (transactions_box.Text == "income")
                {
                    var info_str = $"Cуммарный доход за период с {transdate_from.Value} по {transdate_to.Value} = \n{answer}";
                    MessageBox.Show(info_str);
                    thisReader.Close();
                }
                else if (transactions_box.Text == "outcome")
                {
                    var info_str = $"Cуммарные расходы за период с {transdate_from.Value} по {transdate_to.Value} = {answer}";
                    MessageBox.Show(info_str);
                    thisReader.Close();
                }
            }
            else
            {
                MessageBox.Show("Нечего показывать");
            }

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            users users = new users(_user);
            users.Show();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            categories categories = new categories(_user);
            categories.Show();
        }

        private void transactiontypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            transaction_types tr_type = new transaction_types(_user);
            tr_type.Show();
        }

        private void sum_income_Click(object sender, EventArgs e)
        {
            SqlCommand thisCommand = sql_connection.CreateCommand();
            SqlDataReader thisReader = null;
            var answer = "";
            switch (_user.role)
            {
                case "husband":
                    thisCommand.CommandText = $"SELECT SUM(cost) as 'Sum' FROM transactions WHERE transaction_type_id = '4' and (date BETWEEN @date_from AND @date_to)";
                    thisCommand.Parameters.AddWithValue("@date_from", Convert.ToDateTime(transdate_from.Value));
                    thisCommand.Parameters.AddWithValue("@date_to", Convert.ToDateTime(transdate_to.Value));
                    thisReader = thisCommand.ExecuteReader();
                    break;
                case "wife":
                    thisCommand.CommandText = $"SELECT SUM(cost) as 'Sum' FROM transactions WHERE transaction_type_id = '4' and (date BETWEEN @date_from AND @date_to)";
                    thisCommand.Parameters.AddWithValue("@date_from", Convert.ToDateTime(transdate_from.Value));
                    thisCommand.Parameters.AddWithValue("@date_to", Convert.ToDateTime(transdate_to.Value));
                    thisReader = thisCommand.ExecuteReader();
                    break;
                case "kid":
                    thisCommand.CommandText = $"SELECT SUM(cost) as 'Sum' FROM transactions WHERE user_id = {_user.id} and transaction_type_id = '4' and (date BETWEEN @date_from AND @date_to)";
                    thisCommand.Parameters.AddWithValue("@date_from", Convert.ToDateTime(transdate_from.Value));
                    thisCommand.Parameters.AddWithValue("@date_to", Convert.ToDateTime(transdate_to.Value));
                    thisReader = thisCommand.ExecuteReader();
                    break;
                default:
                    MessageBox.Show("Некорректный запрос");
                    break;
            }
            while (thisReader.Read())
            {
                if (thisReader["Sum"] == null)
                {
                    answer += "0";
                }
                else if (thisReader["Sum"] != null)
                {
                    answer += $"{thisReader["Sum"].ToString()} ";
                }
            }
            var info_str = $"Cуммарный доход за период с {Convert.ToDateTime(transdate_from.Value)} по {Convert.ToDateTime(transdate_to.Value)} = {answer}";
            MessageBox.Show(info_str);
            thisReader.Close();
        }

        private void sum_outcome_Click(object sender, EventArgs e)
        {
            SqlCommand thisCommand = sql_connection.CreateCommand();
            SqlDataReader thisReader = null;
            var answer = "";
            switch (_user.role)
            {
                case "husband":
                    thisCommand.CommandText = $"SELECT SUM(cost) as 'Sum' FROM transactions WHERE transaction_type_id = '5' and (date BETWEEN @date_from AND @date_to)";
                    thisCommand.Parameters.AddWithValue("@date_from", Convert.ToDateTime(transdate_from.Value));
                    thisCommand.Parameters.AddWithValue("@date_to", Convert.ToDateTime(transdate_to.Value));
                    thisReader = thisCommand.ExecuteReader();
                    break;
                case "wife":
                    thisCommand.CommandText = $"SELECT SUM(cost) as 'Sum' FROM transactions WHERE transaction_type_id = '5' and (date BETWEEN @date_from AND @date_to)";
                    thisCommand.Parameters.AddWithValue("@date_from", Convert.ToDateTime(transdate_from.Value));
                    thisCommand.Parameters.AddWithValue("@date_to", Convert.ToDateTime(transdate_to.Value));
                    thisReader = thisCommand.ExecuteReader();
                    break;
                case "kid":
                    thisCommand.CommandText = $"SELECT SUM(cost) as 'Sum' FROM transactions WHERE user_id = {_user.id} and transaction_type_id = '5' and (date BETWEEN @date_from AND @date_to)";
                    thisCommand.Parameters.AddWithValue("@date_from", Convert.ToDateTime(transdate_from.Value));
                    thisCommand.Parameters.AddWithValue("@date_to", Convert.ToDateTime(transdate_to.Value));
                    thisReader = thisCommand.ExecuteReader();
                    break;
                default:
                    MessageBox.Show("Некорректный запрос");
                    break;
            }
            while (thisReader.Read())
            {
                if (thisReader["Sum"] == null)
                {
                    answer += "0";
                }
                else if (thisReader["Sum"] != null)
                {
                    answer += $"{thisReader["Sum"].ToString()} ";
                }
            }
            var info_str = $"Cуммарные расходы за период с {Convert.ToDateTime(transdate_from.Text)} по {Convert.ToDateTime(transdate_to.Text)} = {answer}";
            MessageBox.Show(info_str);
            thisReader.Close();
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

        private void sum_income_MouseEnter(object sender, EventArgs e)
        {
            sum_income.BackColor = Color.Silver;
        }

        private void sum_income_MouseLeave(object sender, EventArgs e)
        {
            sum_income.BackColor = Color.White;
        }

        private void sum_outcome_MouseEnter(object sender, EventArgs e)
        {
            sum_outcome.BackColor = Color.Silver;
        }

        private void sum_outcome_MouseLeave(object sender, EventArgs e)
        {
            sum_outcome.BackColor = Color.White;
        }
    }
}
