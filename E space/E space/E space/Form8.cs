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


namespace E_space
{
    public partial class Form8 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2CKM1J2;Initial Catalog=E_Space;Integrated Security=True");

        public Form8()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox9.Text == "" || textBox6.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Fillout the Empty Fields", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO E_Jet (Jet_ID, Made_Year, Weight, Engine_type, Power_Source, Number_Of_Passenger_Seats) VALUES(' " + textBox1.Text + " ' , ' " + textBox3.Text + " ' ,  ' " + textBox9.Text + " ' , ' " + comboBox2.Text + " ' , ' " + comboBox1.Text + " ', ' " + textBox6.Text + " ') ", con);
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
                SqlCommand cmd = new SqlCommand("UPDATE E_Jet SET  Jet_ID='" + textBox1.Text + "', Made_Year='" + textBox3.Text + "', Weight='" + textBox9.Text + "', Engine_type='" + comboBox2.Text + "', Power_Source='" + comboBox1.Text + "', Number_Of_Passenger_Seats='" + textBox6.Text + "' WHERE Jet_ID='" + textBox4.Text + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearMethod();
                gridviewUpdate();
                con.Close();
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_SpaceDataSet42.E_Jet' table. You can move, or remove it, as needed.
            this.e_JetTableAdapter.Fill(this.e_SpaceDataSet42.E_Jet);
            // TODO: This line of code loads data into the 'e_SpaceDataSet36.E_Jet' table. You can move, or remove it, as needed.
            //this.e_JetTableAdapter.Fill(this.e_SpaceDataSet36.E_Jet);
            // TODO: This line of code loads data into the 'e_SpaceDataSet24.E_Jet' table. You can move, or remove it, as needed.
            //this.e_JetTableAdapter.Fill(this.e_SpaceDataSet24.E_Jet);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                SqlCommand cmd = new SqlCommand("DELETE fROM E_Jet where Jet_ID like '" + textBox1.Text + "'", con);
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
            SqlCommand cmd = new SqlCommand("select * from E_Jet where Jet_ID= '" + textBox1.Text + "'", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            //if (sdr.Read())
                while(sdr.Read())
            {
                textBox1.Text = sdr["Jet_ID"].ToString();
                textBox3.Text = sdr["Made_Year"].ToString();
                textBox9.Text = sdr["Weight"].ToString();
                comboBox2.Text = sdr["Engine_type"].ToString();
                comboBox1.Text = sdr["Power_Source"].ToString();
                textBox6.Text = sdr["Number_Of_Passenger_Seats"].ToString();
            }
           /* else
            {
                MessageBox.Show("Data Not Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clearMethod();
        }
        public void clearMethod()
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox9.Clear();
            textBox6.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
        }
        public void gridviewUpdate()
        {

            string select = "SELECT * from E_Jet";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "E_Jet");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "E_Jet";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
