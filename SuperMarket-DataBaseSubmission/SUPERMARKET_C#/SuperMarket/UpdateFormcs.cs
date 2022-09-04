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
    public partial class UpdateFormcs : Form
    {
        string connectionString = @"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True";
        public UpdateFormcs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //Update Data
        private void Submit_Click(object sender, EventArgs e)
        {
           
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                if (txtUserName.Text == "" || txtPassword.Text == "" || txtID.Text =="")
                {
                    MessageBox.Show("Please Fill In the Username, Password and ID Fields!");
                }
                else
                {
                    sqlconn.Open();
                    SqlCommand sqlcmd = new SqlCommand("Update CUSTOMER set FNAME = @a1, LNAME = @a2, C_ADDRESS = @a3, USERNAME = @a4, PASSWORD =@a5, DISCOUNT = @a7 where CUSTOMER_ID = @a8", sqlconn);
                    //SqlCommand sqlcmd = new SqlCommand("update dbo.CUSTOMER set FNAME = @a1,LNAME = @a2, C_ADDRESS = @a3,USERNAME = @a4,PASSWORD = @a5,FREQUENT_C = @a6,DISCOUNT = @a7 where CUSTOMER_ID = @a8", sqlconn);
                    //sqlcmd.CommandType = CommandType.StoredProcedure;
                    //sqlcmd.Parameters.AddWithValue("@CUSTOMER_ID", txtFirstName.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("a1", txtFirstName.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("a2", txtLastName.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("a3", txtAddress.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("a4", txtUserName.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("a5", txtPassword.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("a7", txtDiscount.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("a8", txtID.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully");

                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();


        }

        //Delete Customer
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                if(txtID.Text == "")
                {
                    MessageBox.Show("Please Fill in The ID Field!");
                }else
                {
                    sqlconn.Open();
                    SqlCommand sqlcmd = new SqlCommand("delete from CUSTOMER where CUSTOMER_ID = @a9", sqlconn);
                    sqlcmd.Parameters.AddWithValue("a9", txtID.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted successfully");
                }

            }
        }

        private void UpdateFormcs_Load(object sender, EventArgs e)
        {

        }

        private void txtFrequency_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
