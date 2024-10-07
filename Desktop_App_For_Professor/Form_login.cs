using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //to connect sql db
namespace Desktop_App_For_Professor
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label_account_id_Click(object sender, EventArgs e)
        {

        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void button_login_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            //call MY_DB.cs
            MY_DB db = new MY_DB();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM mydb.user_info where 'User_Name' = @usn AND 'Student_id' = @pass", db.getConnection);

            //under line take text boxes' input information as login access data.
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBox_account.Text; //account id is username, temporary
            command.Parameters.Add("@pass", MySqlDbType.Int16).Value = textBox_password.Text; //password temporary user ID. change it as DB column type

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if(table.Rows.Count > 0) //db exist
            {
                MessageBox.Show("YES");
            }
            else
            {
                MessageBox.Show("NO");
            }



        }
    }
}
