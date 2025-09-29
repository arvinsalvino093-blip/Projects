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
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\A.S.Asbury\OneDrive\Documents\programming\leave management system\leave management system\Database1.mdf;Integrated Security=True");
        public Form6()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form1 = new Form3();
            form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form1 = new Form3();
            form1.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Fillout the Empty Fields", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Employee_Roaster (Roaster_ID, Employee_ID, Employee_Name, Employee_Roaster_Start_Time, Employee_Roaster_End_Time, Employee_Total_Working_Time ) VALUES(' " + textBox1.Text + " ' , ' " + textBox2.Text + " ' , ' " + textBox3.Text + " ' , ' " + comboBox1.Text + " ' , ' " + comboBox2.Text + " ' , ' " + textBox4.Text + " ' ) ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearMethod();
                gridviewUpdate();
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want to Update the Data ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Employee_Roaster SET  Employee_ID='" + textBox2.Text + "', Employee_Name='" + textBox3.Text + "', Employee_Roaster_Start_Time='" + comboBox1.Text + "', Employee_Roaster_End_Time='" + comboBox2.Text + "', Employee_Total_Working_Time='" + textBox4.Text + "' WHERE Roaster_ID='" + textBox1.Text + "'", con);
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
                SqlCommand cmd = new SqlCommand("DELETE fROM Employee_Roaster where Roaster_ID like '" + textBox1.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Existing Client Details Deleted Successfull", "Client Details Deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                clearMethod();
                gridviewUpdate();
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearMethod();
        }
        public void clearMethod()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
            textBox4.Clear();
            textBox6.Clear();
            

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet21.Employee_Roaster' table. You can move, or remove it, as needed.
            this.employee_RoasterTableAdapter2.Fill(this.database1DataSet21.Employee_Roaster);
            // TODO: This line of code loads data into the 'database1DataSet20.Employee_Roaster' table. You can move, or remove it, as needed.
            this.employee_RoasterTableAdapter1.Fill(this.database1DataSet20.Employee_Roaster);
            // TODO: This line of code loads data into the 'database1DataSet5.Employee_Roaster' table. You can move, or remove it, as needed.
            //this.employee_RoasterTableAdapter.Fill(this.database1DataSet5.Employee_Roaster);
            // TODO: This line of code loads data into the 'database1DataSet3.Employee_Roaster' table. You can move, or remove it, as needed.
            this.employee_RoasterTableAdapter.Fill(this.database1DataSet5.Employee_Roaster);

        }
        public void gridviewUpdate()
        {

            string select = "SELECT * from Employee_Roaster";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employee_Roaster");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Employee_Roaster";

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Employee_Roaster where Roaster_ID LIKE '" + textBox6.Text + "'", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                textBox1.Text = sdr["Roaster_ID"].ToString();
                textBox2.Text = sdr["Employee_ID "].ToString();
                textBox3.Text = sdr["Employee_Name"].ToString();
                comboBox1.Text = sdr["Employee_Roaster_Start_Time"].ToString();
                comboBox2.Text = sdr["Employee_Roaster_End_Time"].ToString();
                textBox4.Text = sdr["Employee_Total_Working_Time"].ToString();
            }
            else
            {
                MessageBox.Show("Data Not Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Employee_Roaster_Start_Time, Employee_Roaster_End_Time, Employee_Total_Working_Time;
            Employee_Roaster_Start_Time = int.Parse(comboBox1.Text);
            Employee_Roaster_End_Time = int.Parse(comboBox2.Text);
            Employee_Total_Working_Time = Employee_Roaster_End_Time - Employee_Roaster_Start_Time;
            textBox4.Text = Employee_Total_Working_Time.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }
    }
}
