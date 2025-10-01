using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = textBox2.Text.Trim();
            string Password = textBox3.Text.Trim();

            if (Username == "" || Password == "")
            {
                MessageBox.Show("Please enter both Username and Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = @"Data Source=DESKTOP-2CKM1J2;Initial Catalog=SkillsInternationalSystem;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Check if username and password exist
                    string query = "SELECT COUNT(*) FROM Users WHERE Username=@Username AND Password=@Password";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@Password", Password);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Login Successful! Redirecting...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields(); // ✅ This clears all textboxes, checkboxes, and resets the date

                            // Redirect to Dashboard/Welcome Page
                            Form4 form = new Form4();
                            form.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearFields(); // ✅ This clears all textboxes, checkboxes, and resets the date
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearFields(); // ✅ This clears all textboxes, checkboxes, and resets the date
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void ClearFields()
        {
            textBox2.Text = "";   // Username
            textBox3.Text = "";   // Last Name
        }
    }
}
