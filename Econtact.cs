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
namespace $safeprojectname$
{
    public partial class Econtact : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=MR-FSOCIETY;Initial Catalog=MarkoDatabase;Integrated Security=True");

        public Econtact()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Idphone = txtBoxContactId.Text;
            String Name = txtboxfirstname.Text;
            String adress = textBox2.Text;
            String Problem = richTextBox1.Text;
            SqlDataAdapter da = new SqlDataAdapter();
            String apos = ",";
        
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Table] (CustomerIDPhone,DName,Address) VALUES('Idphone' , 'MarkSiaf' ,'{adress}')",connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            connection.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            
        }

        private void lbltypeofproblem_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxContactId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
