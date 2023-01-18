using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace sofia
{
    public partial class auth_form : Form
    {
        private SqlConnection conn = null;
        public auth_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void auth_button_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
                conn.Open();
                var user_login = auth_login_box.Text;
                var user_password = auth_pass_box.Text;

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();

                string query = $"select id, role from users where login = '{user_login}' and password = '{user_password}'";

                SqlCommand command = new SqlCommand(query, conn);

                adapter.SelectCommand = command;
                adapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    var user = new user(id: Convert.ToInt32(dt.Rows[0].ItemArray[0]), role: (dt.Rows[0].ItemArray[1]).ToString());
                    MessageBox.Show($"Вход произведен успешно от роли {user.role}");
                    users users = new users(user);
                    this.Hide();
                    conn.Close();
                    users.Show();
                }
                else
                {
                    MessageBox.Show("Некорректно введен логин или пароль");
                }
            }
            catch
            {
                MessageBox.Show("Некорректно введен логин или пароль");
            }
        }

        private void auth_button_MouseEnter(object sender, EventArgs e)
        {
            auth_button.BackColor = Color.Silver;
        }

        private void auth_button_MouseLeave(object sender, EventArgs e)
        {
            auth_button.BackColor = Color.White;
        }
    }
}
