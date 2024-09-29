using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLi
{
    public partial class LoginForm : Form
    {
        MyDB db = new MyDB();
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string cmdstr = "SELECT * FROM login WHERE username = '" + Textbox_username.Text + "' AND password = '" + Textbox_password.Text + "'";
            SqlCommand cmd = new SqlCommand(cmdstr, db.getConnection);
            db.openConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);


            MainForm mainForm = new MainForm();
            mainForm.dataGridView1.DataSource = table;
            mainForm.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (table.Rows.Count > 0)
            {
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
