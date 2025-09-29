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

namespace leave_management_system
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\A.S.Asbury\OneDrive\Documents\programming\leave management system\leave management system\Database1.mdf;Integrated Security=True");


        public Form4()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Employee_Registration' table. You can move, or remove it, as needed.
            this.employee_RegistrationTableAdapter.Fill(this.database1DataSet1.Employee_Registration);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form1 = new Form3();
            form1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Fillout the Empty Fields", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Employee_Registration (Employee_ID, Employee_Name, Employee_NIC, Employee_Type, Employee_Qualification, Employee_Experience, Employee_Account_Number, Employee_DOB) VALUES(' " + textBox1.Text + " ' , ' " + textBox2.Text + " ' , ' " + textBox3.Text + " ' , ' " + textBox5.Text + " ' , ' " + textBox6.Text + " ' , ' " + textBox7.Text + " ' , ' " + textBox8.Text + " ', ' " + dateTimePicker1.Text + " ') ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearMethod();
                gridviewUpdate();
                con.Close();
            }

        }


        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Employee_Registration where Employee_ID LIKE '" + textBox4.Text + "'", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                textBox1.Text = sdr["Employee_ID"].ToString();
                textBox2.Text = sdr["Employee_Name"].ToString();
                textBox3.Text = sdr["Employee_NIC"].ToString();
                dateTimePicker1.Text = sdr["Employee_DOB"].ToString();
                textBox5.Text = sdr["Employee_Type"].ToString();
                textBox6.Text = sdr["Employee_Qualification"].ToString();
                textBox7.Text = sdr["Employee_Experience"].ToString();
                textBox8.Text = sdr["Employee_Account_Number"].ToString();
            }
            else
            {
                MessageBox.Show("Data Not Found","Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want to Update the Data ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Employee_Registration SET  Employee_Name='" + textBox2.Text + "', Employee_NIC='" + textBox3.Text + "', Employee_Type='" + textBox5.Text + "', Employee_Qualification='" + textBox6.Text + "', Employee_Experience='" + textBox7.Text + "', Employee_Account_Number='" + textBox8.Text + "', Employee_DOB=' " + dateTimePicker1.Text + " ' WHERE Employee_ID='"+textBox4.Text+"' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearMethod();
                gridviewUpdate();
                con.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                SqlCommand cmd = new SqlCommand("DELETE fROM Employee_Registration where Employee_ID like '" + textBox1.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Existing Client Details Deleted Successfull", "Client Details Deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                clearMethod();
                gridviewUpdate();
                con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clearMethod();
        }
        public void clearMethod()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox4.Clear();
            dateTimePicker1.ResetText();
        }
        public void gridviewUpdate()
        {

            string select = "SELECT * from Employee_Registration";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employee_Registration");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Employee_Registration";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

}
