using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ems_system
{
    public partial class LoginForm : Form
    {
        public static string username;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void singin_btn_Click(object sender, EventArgs e)
        {
            // Database connection string
            string myconnectionString = @"server=localhost;database=ems_system;userid=root;password=";

            // Using statement ensures proper disposal of resources
            using (MySqlConnection con = new MySqlConnection(myconnectionString))
            {
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader dr;

                try
                {
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM login_tb  WHERE Username=@Username AND Password=@Password";

                    // Use parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox2.Text);

                    dr = cmd.ExecuteReader();

                    // Check if there is at least one row in the result set
                    if (dr.Read())
                    {
                        MessageBox.Show("Success");

                        // Set DialogResult to OK before hiding the form
                        this.DialogResult = DialogResult.OK;

                        // Store the username
                        username = textBox1.Text;

                        // Check if an instance of HomeForm is already open
                        HomeForm hf = Application.OpenForms.OfType<HomeForm>().FirstOrDefault();

                        if (hf == null)
                        {
                            hf = new HomeForm();
                            this.Hide();
                            hf.Show();
                        }
                        else
                        {
                            hf.BringToFront();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the correct username and password");
                    }
                }
                finally
                {
                    // Ensure the connection is closed, even if an exception occurs
                    con.Close();
                }
            }
        }

       
    }
}
