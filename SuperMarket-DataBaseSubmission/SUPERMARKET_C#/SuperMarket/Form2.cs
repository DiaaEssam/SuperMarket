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
    public partial class Form2 : Form
                                   
    {
        string connectionString = @"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //Show Data
        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select s.name 'Schemas', t.name 'Tables' , c.name , c.column_id from sys.columns c inner join sys.tables t on c.object_id = t.object_id inner join sys.schemas s on t.schema_id = s.schema_id order by t.name , c.column_id", conn);
            // SqlCommand cmd = new SqlCommand("select * from customer", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
            //Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("with counts as (select  p.pname,o.product_id, count(distinct o.customer_id) as number_of_customers from [order] o  join product p on  o.product_id = p.product_id group by o.product_id,p.pname)  select  pname,product_id,number_of_customers  from counts where number_of_customers = (select max(number_of_customers) from counts)", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //ADD Product
        private void Insert_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                if (txtPname.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "" || txtDesc.Text == "")
                {
                    MessageBox.Show("Please Fill In the Fields!");
                }
                else
                {
                    sqlconn.Open();
                    SqlCommand sqlcmd = new SqlCommand("UserInsertProduct", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    //sqlcmd.Parameters.AddWithValue("@CUSTOMER_ID", txtFirstName.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@PNAME", txtPname.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@STANDARD_PRICE", txtPrice.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@QUANTITY", txtQuantity.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@PRODUCT_DESCRIPTION", txtDesc.Text.Trim());
                    // sqlcmd.Parameters.AddWithValue("@PASSWORD", txtPassword.Text.Trim());
                    //sqlcmd.Parameters.AddWithValue("@STREET", txtAddress.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Added Product Successfully");
                    Clear();

                }
                
            }



        }
        void Clear()
        {
            txtProdID.Text = txtDate.Text = txtDesc.Text = txtPname.Text = txtPrice.Text = txtQuantity.Text = "";
        }

        //ShowAllProd button
        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from PRODUCT  ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //Remove Button
        private void button8_Click(object sender, EventArgs e)
        {
            if (txtProdID.Text == "")
            {
                MessageBox.Show("Please Fill In the Product ID Field!");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand(" delete from PRODUCT where PRODUCT_ID = @a1", conn);
                cmd.Parameters.AddWithValue("a1", txtProdID.Text.Trim());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Product Removed Successfully");

            }
            

        }

        //Update Product Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtProdID.Text == "" || txtPname.Text == "" || txtPrice.Text == "" || txtQuantity.Text=="" || txtDesc.Text =="")
            {
                MessageBox.Show("Please Fill In the Fields!");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand(" update PRODUCT set PNAME = @a1 , STANDARD_PRICE = @a2, QUANTITY = @a3 , PRODUCT_DESCRIPTION = @a4 where PRODUCT_ID = @a5", conn);
                cmd.Parameters.AddWithValue("a1", txtPname.Text.Trim());
                cmd.Parameters.AddWithValue("a2", txtPrice.Text.Trim());
                cmd.Parameters.AddWithValue("a3", txtQuantity.Text.Trim());
                cmd.Parameters.AddWithValue("a4", txtDesc.Text.Trim());
                cmd.Parameters.AddWithValue("a5", txtProdID.Text.Trim());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Product Updated Successfully");

            }
            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }


        //Most Bought Button
        private void button6_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("with counts as (select  p.pname,o.product_id, count(distinct o.customer_id) as number_of_customers from [order] o  join product p on  o.product_id = p.product_id group by o.product_id,p.pname)  select  pname,product_id,number_of_customers  from counts where number_of_customers = (select max(number_of_customers) from counts)", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //NOT Bought Product
        private void button12_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select  c.fname as First_Name,c.lname as Last_Name from customer as c where c.customer_id not in (select customer_id from [order] where order_date >= DATEADD(year,-1,GETDATE()))", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        //Retrive Button
        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select product.*,n.number_of_customers from product join (select P.PRODUCT_ID ,count(distinct o.customer_id) as number_of_customers from PRODUCT AS P left join[order] as o on p.PRODUCT_ID=o.PRODUCT_ID group by p.PRODUCT_ID) n on n.PRODUCT_ID = PRODUCT.PRODUCT_ID", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //Food-Electric Button
        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select top(1) WITH TIES pg_name, number_purchased from product_group where pg_id in (1,5) order by number_purchased desc", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        //CUstomer Of the Month
        private void button13_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select fname,lname from CUSTOMER as c join(select top(1) with ties CUSTOMER_id ,sum(purchasing) as purchase from [order] where  datepart(month,GETDATE())=datepart(month,ORDER_DATE) and datepart(year,GETDATE())=datepart(year,ORDER_DATE) group by CUSTOMER_ID order by purchase desc) n on c.CUSTOMER_ID=n.CUSTOMER_ID", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        //Never Bought Button
        private void button9_Click_1(object sender, EventArgs e)
        {
            if (txtDate.Text == "")
            {
                MessageBox.Show("Please Fill In the Date Field!");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from product where product_id not in (select product_id from [order] where datepart(year, ORDER_DATE)= datepart(year,@a1) and datepart(Month, ORDER_DATE)= datepart(month,@a1))", conn);
                cmd.Parameters.AddWithValue("a1", txtDate.Text.Trim());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        //Browse Product Button
        private void button15_Click(object sender, EventArgs e)
        {
            if (txtPname.Text == "")
            {
                MessageBox.Show("Please Fill In the Product Name Field!");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from PRODUCT where PNAME like '%'+@a1+'%'", conn);
                cmd.Parameters.AddWithValue("a1", txtPname.Text.Trim());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            

        }

        //Need Restock button
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Please Fill In the Quantity Field!");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select* from PRODUCT where QUANTITY <= @a1;", conn);
                cmd.Parameters.AddWithValue("a1", txtQuantity.Text.Trim());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            
            

        }
        //Show All Customers Button
        private void button20_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from CUSTOMER", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        //FreqCustomer Button
        private void button14_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer as c join (select * from (select CUSTOMER_ID,count(order_id2)as number_of_orders from [ORDER] group by CUSTOMER_ID) A where a.number_of_orders=( select max(number_of_orders) from( select CUSTOMER_ID,count(order_id2)as number_of_orders from [ORDER] group by CUSTOMER_ID)n)) S on c.customer_id=s.customer_id", conn);
            cmd.Parameters.AddWithValue("a1", txtQuantity.Text.Trim());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtProdID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bRANCHBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cASHIERBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cLEANINGSTAFFBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cUSTOMERBindingSource3_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dEALWITHBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dELIVERYBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void eLECTRONICSTAFFBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void eMPLOYEEBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void gETSBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void oRDERBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void oRDERSBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pRODUCTBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pRODUCTGROUPBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pURCHASEDBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void sECTIONBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void sECTIONLOCATIONBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void sUPERMARKETBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void sUPPLIERBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void sUPPLIESBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void vISITBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void aDMINBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void masterDataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cUSTOMERBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bRANCHBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void aDMINBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cUSTOMERBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cUSTOMERBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateFormcs().Show();
        }
    }
}
