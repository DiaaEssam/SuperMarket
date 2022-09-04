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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True");

        private void button6_Click(object sender, EventArgs e)
        {


        }

        private void Queries_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            new Form1().Show();
            this.Hide();
        }


        //Browse Product  Button
        private void button15_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select PNAME , STANDARD_PRICE,QUANTITY,PRODUCT_DESCRIPTION from PRODUCT where PNAME like '%'+@a1+'%'", conn);
            cmd.Parameters.AddWithValue("a1", txtPname.Text.Trim());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
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

        //CUstomer Of the Month Button
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

        //NOT Bought Product Button
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


        //Never Bought Button
        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from product where product_id not in (select product_id from [order] where datepart(year, ORDER_DATE)= datepart(year,@a1) and datepart(Month, ORDER_DATE)= datepart(month,@a1))", conn);
            // cmd.Parameters.AddWithValue("a1", txtDate.Text.Trim());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        //ShowAllProd Button
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

        //Need Restock button
        private void button3_Click(object sender, EventArgs e)
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

        //ShowData Button
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateCustomerForm().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //new DeleteCustomer().Show();
            // this.Hide();    
        }


        //Buy Product Button
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (txtPname.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Please Fill  Product name text and Quantity text Field!");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2JB7FNI;Initial Catalog=Smarket2;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update PRODUCT set QUANTITY = QUANTITY-@a1 where PNAME = @a2  ", conn);
                cmd.Parameters.AddWithValue("a1", txtQuantity.Text.Trim());
                cmd.Parameters.AddWithValue("a2", txtPname.Text.Trim());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Product bought successfully!");


            }


        }
    }
}


