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

namespace CarRacing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=RAIHAN\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string FirstName = this.SecondName.Text;
            string SecondName = this.FirstName.Text;
            string Query = "INSERT INTO Names (FirstName, SecondName) VALUES ('"+FirstName+"','"+SecondName+"')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been saved");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
