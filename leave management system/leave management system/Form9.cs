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
    public partial class Form9 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\A.S.Asbury\OneDrive\Documents\programming\leave management system\leave management system\Database1.mdf;Integrated Security=True");
        public Form9()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet19.Apply_Leaves' table. You can move, or remove it, as needed.
            this.apply_LeavesTableAdapter3.Fill(this.database1DataSet19.Apply_Leaves);
            // TODO: This line of code loads data into the 'database1DataSet18.Employee_Apply_Leaves' table. You can move, or remove it, as needed.
            this.employee_Apply_LeavesTableAdapter.Fill(this.database1DataSet18.Employee_Apply_Leaves);
            // TODO: This line of code loads data into the 'database1DataSet17.Apply_Leaves' table. You can move, or remove it, as needed.
            //this.apply_LeavesTableAdapter2.Fill(this.database1DataSet17.Apply_Leaves);
            // TODO: This line of code loads data into the 'database1DataSet11.Apply_Leaves' table. You can move, or remove it, as needed.
            //this.apply_LeavesTableAdapter1.Fill(this.database1DataSet11.Apply_Leaves);
            // TODO: This line of code loads data into the 'database1DataSet8.Apply_Leaves' table. You can move, or remove it, as needed.
            //this.apply_LeavesTableAdapter.Fill(this.database1DataSet8.Apply_Leaves);
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // this coding is for the seraching 
            SqlCommand cmd = new SqlCommand("select * from Apply_Leaves where Leave_ID LIKE '" + textBox6.Text + "'", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                comboBox3.Text = sdr["Leave_Type"].ToString();
                textBox1.Text = sdr["Employee_ID"].ToString();
                textBox2.Text = sdr["Employee_Name"].ToString();
                textBox9.Text = sdr["Annuals_Leaves"].ToString();
                textBox10.Text = sdr["Casuals_Leaves"].ToString();
                textBox11.Text = sdr["Shorts_Leaves"].ToString();
                dateTimePicker2.Text = sdr["Annual_Start_Date"].ToString();
                dateTimePicker1.Text = sdr["Annual_End_Date"].ToString();
                textBox3.Text = sdr["Total_Annuals"].ToString();
                textBox4.Text = sdr["Balance_Annuals"].ToString();
                dateTimePicker3.Text = sdr["Casual_Start_Date"].ToString();
                dateTimePicker4.Text = sdr["Casual_End_Date"].ToString();
                textBox7.Text = sdr["Total_Casual"].ToString();
                textBox5.Text = sdr["Balance_Casual"].ToString();
                dateTimePicker7.Text = sdr["Short_Leave_Day"].ToString();
                comboBox1.Text = sdr["Short_Leave_Start_Time"].ToString();
                comboBox2.Text = sdr["Short_Leave_End_Time"].ToString();
                textBox8.Text = sdr["Balance_Short_Leave_Days"].ToString();
            }
            else
            {
                MessageBox.Show("Data Not Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            // this coding is for the clearing 
            clearMethod();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
                      
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            var Casual_Start_Date = Convert.ToDateTime(dateTimePicker4.Value);
            var Casual_End_Date = Convert.ToDateTime(dateTimePicker3.Value);

            var difren = Casual_End_Date - Casual_Start_Date;

            textBox7.Text = difren.Days.ToString();


            int st, end, fin;
            st = int.Parse(textBox7.Text);
            if (string.IsNullOrEmpty(textBox10.Text))
            {
                textBox10.Text = "0";
            }
            end = int.Parse(textBox10.Text);
            fin = end - st;
            textBox5.Text = fin.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && textBox11.Text != "0")
            {
                int val = int.Parse(textBox11.Text);
                int ans = val - 1;
                textBox8.Text = ans.ToString();

            }
            else
            {
                MessageBox.Show("You Cant Apply short leave", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // this coding is for the saving 
            if (textBox1.Text == "" || textBox2.Text == "" ||  textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || comboBox3.Text == "")
            {
                MessageBox.Show("Fillout the Empty Fields", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Apply_Leaves (Leave_ID, Leave_Type, Employee_ID, Employee_Name, Annuals_Leaves, Casuals_Leaves, Shorts_Leaves, Annual_Start_Date, Annual_End_Date, Total_Annuals, Balance_Annuals, Casual_Start_Date, Casual_End_Date, Total_Casual, Balance_Casual, Short_Leave_Day, Short_Leave_Start_Time, Short_Leave_End_Time, Balance_Short_Leave_Days) VALUES(' " + textBox6.Text + " ' , ' " + comboBox3.Text + " ' , ' " + textBox1.Text + " ' , ' " + textBox2.Text + " ' , ' " + textBox9.Text + " ' , ' " + textBox10.Text + " ' , ' " + textBox11.Text + " ', ' " + dateTimePicker1.Text + " ', ' " + dateTimePicker2.Text + " ', ' " + textBox3.Text + " ', ' " + textBox4.Text + " ', ' " + dateTimePicker3.Text + " ', ' " + dateTimePicker4.Text + " ', ' " + textBox7.Text + " ', ' " + textBox5.Text + " ', ' " + dateTimePicker7.Text + " ', ' " + comboBox1.Text + " ' , ' " + comboBox2.Text + " ', ' " + textBox8.Text + " ' ) ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridviewUpdate();
                clearMethod();
                con.Close();
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            // this coding is for the updating 
            if (DialogResult.Yes == MessageBox.Show("Do You Want to Update the Data ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Apply_Leaves SET Leave_Type= ' " + comboBox3.Text + " ', Employee_ID= ' " + textBox1.Text + " ', Employee_Name= ' " + textBox2.Text + " ', Annuals_Leaves= ' " + textBox9.Text + " ', Casuals_Leaves= ' " + textBox10.Text + " ', Shorts_Leaves= ' " + textBox11.Text + " ', Annual_Start_Date=' " + dateTimePicker1.Text + " ', Annual_End_Date= ' " + dateTimePicker2.Text + " ', Total_Annuals= ' " + textBox3.Text + " ', Balance_Annuals= ' " + textBox4.Text + " ', Casual_Start_Date= ' " + dateTimePicker3.Text + " ', Casual_End_Date= ' " + dateTimePicker4.Text + " ', Total_Casual= ' " + textBox7.Text + " ', Balance_Casual= ' " + textBox5.Text + " ', Short_Leave_Day= ' " + dateTimePicker7.Text + " ', Short_Leave_Start_Time= ' " + comboBox1.Text + " ', Short_Leave_End_Time= ' " + comboBox2.Text + " ', Balance_Short_Leave_Days= ' " + textBox8.Text + " ' WHERE Leave_ID ='" + textBox6.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridviewUpdate();
                clearMethod();
                con.Close();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // this coding is for the deleting
            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                SqlCommand cmd = new SqlCommand("DELETE fROM Apply_Leaves where Leave_ID like '" + textBox6.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Existing Client Details Deleted Successfull", "Client Details Deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                gridviewUpdate();
                clearMethod();
                con.Close();
            }
        }
        public void gridviewUpdate()
        {

            string select = "SELECT * from Apply_Leaves";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Apply_Leaves");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Apply_Leaves";

        }
        public void clearMethod()
        {
            // this coding is for the clearing 
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
            dateTimePicker3.ResetText();
            dateTimePicker4.ResetText();
            dateTimePicker7.ResetText();
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_2(object sender, EventArgs e)
        {
            var Annual_Start_Date = Convert.ToDateTime(dateTimePicker2.Value);
            var Annual_End_Date = Convert.ToDateTime(dateTimePicker1.Value);

            var difren = Annual_End_Date - Annual_Start_Date;

            textBox3.Text = difren.Days.ToString();


            int st, end, fin;
            st = int.Parse(textBox3.Text);
            if (string.IsNullOrEmpty(textBox9.Text))
            {
                textBox9.Text = "0";
            }
            end = int.Parse(textBox9.Text);
            fin = end - st;
            textBox4.Text = fin.ToString();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox9.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox9.Text = textBox9.Text.Remove(textBox9.Text.Length - 1);
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker2_ValueChanged_2(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Annuals_Leaves")
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            }
            else if (comboBox3.Text == "Casuals_Leaves")
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
            }
            else if (comboBox3.Text == "Shorts_Leaves")
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
            }
            {

                SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\A.S.Asbury\OneDrive\Documents\programming\leave management system\leave management system\Database1.mdf;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee_Leaves  WHERE Leave_ID LIKE '" + textBox6.Text + "'", con1);
                con1.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {

                    textBox1.Text = sdr["Employee_ID"].ToString();
                    textBox2.Text = sdr["Employee_Name"].ToString();
                    textBox9.Text = sdr["Employee_Annual_Leave_Days"].ToString();
                    textBox10.Text = sdr["Employee_Casual_Leave_Days"].ToString();
                    textBox11.Text = sdr["Employee_Short_Leaves"].ToString();


                }
                else
                {
                    ///MessageBox.Show("Data Not Found");
                }
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox9.ReadOnly = true;
                textBox10.ReadOnly = true;
                textBox11.ReadOnly = true;
                con1.Close();
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

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox10.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox10.Text = textBox10.Text.Remove(textBox10.Text.Length - 1);
            }
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox11.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox11.Text = textBox11.Text.Remove(textBox11.Text.Length - 1);
            }
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // this coding is for the upadting 
            
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Employee_Leaves SET Employee_Annual_Leave_Days= ' " + textBox4.Text + " ', Employee_Casual_Leave_Days= ' " + textBox5.Text + " ',  Employee_Short_Leaves= ' " + textBox8.Text + " ' WHERE Leave_ID ='" + textBox6.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridviewUpdate();
                con.Close();
            }
        }
    }
}
