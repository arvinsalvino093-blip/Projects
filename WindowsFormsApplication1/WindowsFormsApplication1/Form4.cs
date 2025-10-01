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
    public partial class Form4 : Form
    {
        string connectionString = @"Data Source=DESKTOP-2CKM1J2;Initial Catalog=SkillsInternationalSystem;Integrated Security=True";

        public Form4()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = checkBox1.Checked ? "Male" : checkBox2.Checked ? "Female" : "";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Students (Username, FirstName, LastName, DateOfBirth, Gender, Address, Email, MobileNo, HomeNo, ParentName, NIC, ContactNo) " +
                               "VALUES (@Username, @FirstName, @LastName, @DOB, @Gender, @Address, @Email, @MobileNo, @HomeNo, @ParentName, @NIC, @ContactNo)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", textBox2.Text);
                cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                cmd.Parameters.AddWithValue("@LastName", textBox3.Text);
                cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Address", textBox5.Text);
                cmd.Parameters.AddWithValue("@Email", textBox4.Text);
                cmd.Parameters.AddWithValue("@MobileNo", textBox6.Text);
                cmd.Parameters.AddWithValue("@HomeNo", textBox7.Text);
                cmd.Parameters.AddWithValue("@ParentName", textBox11.Text);
                cmd.Parameters.AddWithValue("@NIC", textBox10.Text);
                cmd.Parameters.AddWithValue("@ContactNo", textBox9.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields(); // ✅ Clear after success}
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gender = checkBox1.Checked ? "Male" : checkBox2.Checked ? "Female" : "";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Students SET FirstName=@FirstName, LastName=@LastName, DateOfBirth=@DOB, Gender=@Gender, " +
                               "Address=@Address, Email=@Email, MobileNo=@MobileNo, HomeNo=@HomeNo, ParentName=@ParentName, NIC=@NIC, ContactNo=@ContactNo " +
                               "WHERE Username=@Username";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", textBox2.Text);
                cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                cmd.Parameters.AddWithValue("@LastName", textBox3.Text);
                cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Address", textBox5.Text);
                cmd.Parameters.AddWithValue("@Email", textBox4.Text);
                cmd.Parameters.AddWithValue("@MobileNo", textBox6.Text);
                cmd.Parameters.AddWithValue("@HomeNo", textBox7.Text);
                cmd.Parameters.AddWithValue("@ParentName", textBox11.Text);
                cmd.Parameters.AddWithValue("@NIC", textBox10.Text);
                cmd.Parameters.AddWithValue("@ContactNo", textBox9.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields(); // ✅ Clear after success}
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Students WHERE Username=@Username";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", textBox2.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("No record found with the given Username.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearFields(); // ✅ Clear after success}
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string Username = textBox2.Text.Trim();

            if (Username == "")
            {
                MessageBox.Show("Please enter a username to search.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Students WHERE Username=@Username";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", textBox2.Text);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBox1.Text = reader["FirstName"].ToString();
                    textBox3.Text = reader["LastName"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(reader["DateOfBirth"]);

                    if (reader["Gender"].ToString() == "Male")
                    {
                        checkBox1.Checked = true;
                        checkBox2.Checked = false;
                    }
                    else if (reader["Gender"].ToString() == "Female")
                    {
                        checkBox2.Checked = true;
                        checkBox1.Checked = false;
                    }

                    textBox5.Text = reader["Address"].ToString();
                    textBox4.Text = reader["Email"].ToString();
                    textBox6.Text = reader["MobileNo"].ToString();
                    textBox7.Text = reader["HomeNo"].ToString();
                    textBox11.Text = reader["ParentName"].ToString();
                    textBox10.Text = reader["NIC"].ToString();
                    textBox9.Text = reader["ContactNo"].ToString();

                    MessageBox.Show("Student record found!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No student record found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearFields(); // ✅ Clear if not found
                }

                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearFields(); // ✅ This clears all textboxes, checkboxes, and resets the date
        }

        private void ClearFields()
        {
            textBox1.Text = "";   // First Name
            textBox2.Text = "";   // Username
            textBox3.Text = "";   // Last Name
            textBox4.Text = "";   // Email
            textBox5.Text = "";   // Address
            textBox6.Text = "";   // Mobile No
            textBox7.Text = "";   // Home No
            textBox9.Text = "";   // Contact No
            textBox10.Text = "";  // NIC
            textBox11.Text = "";  // Parent Name

            dateTimePicker1.Value = DateTime.Now; // Reset to today’s date

            checkBox1.Checked = false; // Gender Male
            checkBox2.Checked = false; // Gender Female
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
    }
}
