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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text.Trim();
            string Username = textBox2.Text.Trim();
            string Password = textBox3.Text.Trim();

            if (Name == "" || Username == "" || Password == "")
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = @"Data Source=DESKTOP-2CKM1J2;Initial Catalog=SkillsInternationalSystem;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // First check if username already exists
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username=@Username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", Username);

                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists! Redirecting to Login...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Redirect to Login Form
                            Form3 form = new Form3();
                            form.Show();
                            this.Hide();
                            return;
                        }
                    }

                    // If username does not exist → insert new record
                    string query = "INSERT INTO Users (Name, Username, Password) VALUES (@Name, @Username, @Password)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@Password", Password); // For real apps: hash passwords!

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Sign Up Successful! Redirecting...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields(); // ✅ This clears all textboxes, checkboxes, and resets the date

                            // Redirect to Next Page (Dashboard/Welcome Form)
                            Form4 form = new Form4();
                            form.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Sign Up Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void ClearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";   // Username
            textBox3.Text = "";   // Last Name
        }
    }
}
