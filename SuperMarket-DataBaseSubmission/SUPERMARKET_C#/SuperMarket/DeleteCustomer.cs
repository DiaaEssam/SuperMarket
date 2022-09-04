using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperMarket
{
    public partial class DeleteCustomer : Form
    {
        string connectionString = @"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True";
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user_name;

            user_name = txtUserName.Text;

            String querry = "select * from CUSTOMER where username = '" + txtUserName.Text + "' ";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, connectionString);

            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            if (dtable.Rows.Count > 0)
            {
                user_name = txtUserName.Text;
                using (SqlConnection sqlconn = new SqlConnection(connectionString))
                {

                    sqlconn.Open();
                    SqlCommand sqlcmd = new SqlCommand("delete from CUSTOMER where USERNAME = @a9", sqlconn);
                    sqlcmd.Parameters.AddWithValue("a9", txtUserName.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted successfully");


                }

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
