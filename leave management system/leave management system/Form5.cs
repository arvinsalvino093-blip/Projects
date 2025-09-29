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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\A.S.Asbury\OneDrive\Documents\programming\leave management system\leave management system\Database1.mdf;Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
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
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox5.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form1 = new Form3();
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form1 = new Form3();
            form1.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Employee_Leaves where Leave_ID LIKE '" + textBox5.Text + "'", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                textBox1.Text = sdr["Leave_ID"].ToString();
                textBox2.Text = sdr["Employee_ID"].ToString();
                textBox3.Text = sdr["Employee_Name"].ToString();
                textBox4.Text = sdr["Employee_Experiences"].ToString();
                textBox6.Text = sdr["Employee_Annual_Leave_Days"].ToString();
                textBox7.Text = sdr["Employee_Casual_Leave_Days"].ToString();
                textBox8.Text = sdr["Employee_Short_Leaves"].ToString();
            }
            else
            {
                MessageBox.Show("Data Not Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                SqlCommand cmd = new SqlCommand("DELETE fROM Employee_Leaves where Leave_ID like '" + textBox1.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Existing Client Details Deleted Successfull", "Client Details Deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                gridviewUpdate();
                clearMethod();
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text ==  "")
            {
                MessageBox.Show("Fillout the Empty Fields", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Employee_Leaves (Leave_ID, Employee_ID, Employee_Name, Employee_Experiences, Employee_Annual_Leave_Days, Employee_Casual_Leave_Days, Employee_Short_Leaves) VALUES(' " + textBox1.Text + " ' , ' " + textBox2.Text + " ' , ' " + textBox3.Text + " ' , ' " + textBox4.Text + " ' , ' " + textBox6.Text + " ' , ' " + textBox7.Text + " ' , ' " + textBox8.Text + " ') ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridviewUpdate();
                clearMethod();
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want to Update the Data ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Employee_Leaves SET  Employee_ID='" + textBox2.Text + "', Employee_Name='" + textBox3.Text + "', Employee_Experiences='" + textBox4.Text + "', Employee_Annual_Leave_Days='" + textBox6.Text + "', Employee_Casual_Leave_Days='" + textBox7.Text + "', Employee_Short_Leaves='" + textBox8.Text + "' WHERE Leave_ID='" + textBox1.Text + "' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridviewUpdate();
                clearMethod();
                con.Close();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet13.Employee_Leaves' table. You can move, or remove it, as needed.
            this.employee_LeavesTableAdapter2.Fill(this.database1DataSet13.Employee_Leaves);
            // TODO: This line of code loads data into the 'database1DataSet12.Employee_Leaves' table. You can move, or remove it, as needed.
            this.employee_LeavesTableAdapter1.Fill(this.database1DataSet12.Employee_Leaves);
            // TODO: This line of code loads data into the 'database1DataSet4.Employee_Leaves' table. You can move, or remove it, as needed.
            //this.employee_LeavesTableAdapter.Fill(this.database1DataSet4.Employee_Leaves);
            // TODO: This line of code loads data into the 'database1DataSet2.Employee_Leaves' table. You can move, or remove it, as needed.
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        
        }
        public void gridviewUpdate()
        {

            string select = "SELECT * from Employee_Leaves";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employee_Leaves");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Employee_Leaves";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
