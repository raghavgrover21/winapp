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
namespace Books
{
    public partial class Form1 : Form
    {
       // Book1 inst;
        public Form1()
        {
            InitializeComponent();
            
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public string conString = "Data Source=ALBO-PC\\SQLEXPRESS;Initial Catalog=cred;Integrated Security=True"; //use \\ due to the error bcoz when you copy it from the properties
        private void button1_Click(object sender, EventArgs e)
        {
            Book1 ob1 = new Book1
            {
                book_ISBN = int.Parse(ISBN.Text),
                author_name = Author_name.ToString(),
                book_name = Book_name.ToString()
            };
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open) //check if connection is open or not 
            {

                // string insert="insert into books values('"+ob1.book_ISBN+"','"+ob1.book_name+"','"+ob1.author_name+"')";
                string insert = "insert into books values(@ISBN , @book_name,@author)";

                SqlCommand cmd = new SqlCommand(insert,conn);
                cmd.Parameters.AddWithValue("@ISBN", ISBN.Text);
                cmd.Parameters.AddWithValue("@book_name", Book_name.Text);
                cmd.Parameters.AddWithValue("@author", Author_name.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            Console.WriteLine(ob1.book_ISBN);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
