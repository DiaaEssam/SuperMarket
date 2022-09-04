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
    public partial class Form3 : Form
    {
        string connectionString = @"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
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
                MessageBox.Show("The Username Already Exists");
             
            }else if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter UserName and Password");

            }else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password Do not Match");
            }
            else
            {
                using (SqlConnection sqlconn = new SqlConnection(connectionString))
                {
                    sqlconn.Open();
                    SqlCommand sqlcmd = new SqlCommand("UserAdd", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    //sqlcmd.Parameters.AddWithValue("@CUSTOMER_ID", txtFirstName.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@FNAME", txtFirstName.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@LNAME", txtLastName.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@C_ADDRESS", txtAddress.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@USERNAME", txtUserName.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@PASSWORD", txtPassword.Text.Trim());
                    //sqlcmd.Parameters.AddWithValue("@STREET", txtAddress.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Registered successfully");




                    Clear();
                    


                }

            }
            
        }

        void Clear()
        {
            txtFirstName.Text = txtLastName.Text = txtAddress.Text = txtUserName.Text = txtPassword.Text = txtConfirmPassword.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            new Form1().Show();
            this.Hide();

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
