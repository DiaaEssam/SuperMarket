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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                                                 
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True");

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }


        //Log In button (As Customer there is also removed else statment'admin')
        private void button1_Click(object sender, EventArgs e)
        {
            String user_name, user_password;

            user_name = txtUserName.Text;
            user_password = txtPassword.Text;

            try
            {
                String querry = "select * from CUSTOMER where username = '" + txtUserName.Text + "' AND password ='" + txtPassword.Text + "' ";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                adapter.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                   // user_name = txtUserName.Text;
                   // user_password = txtPassword.Text;


                    // this code will run if data table has more than 0 rows, means there is at least 1 row in  data table, data table is not empty.
                    //page that needed to be load next
                    new CustomerForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The Username or Password are incorrect, please try again!");
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();

                }
            }

            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }

          
        }

        //Exit button
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Clear button
        private void button2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet1.ADMIN' table. You can move, or remove it, as needed.
            //this.aDMINTableAdapter.Fill(this.masterDataSet1.ADMIN);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new UpdateFormcs().Show();
            this.Hide();
        }


        //Log In As Admin
        private void button6_Click(object sender, EventArgs e)
        {
            String user_namee, user_passwordd;

            user_namee = txtUserName.Text;
            user_passwordd = txtPassword.Text;

            try
            {
                String querry = "select * from dbo.[ADMIN] where USERNAME = '" + txtUserName.Text + "' AND ADMINPASS ='" + txtPassword.Text + "'  ";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                adapter.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    //user_namee = txtUserName.Text;
                   // user_passwordd = txtPassword.Text;


                    // this code will run if data table has more than 0 rows, means there is at least 1 row in  data table, data table is not empty.
                    //page that needed to be load next
                    new Form2().Show();
                    this.Hide();
                }
                else if (txtUserName.Text == "admin" && txtPassword.Text == "admin")
                {
                    new Form2().Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("The Username or Password are incorrect, please try again!");
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();

                }
            }

            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }


        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
