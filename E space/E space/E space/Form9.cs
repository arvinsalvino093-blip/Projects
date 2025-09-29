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
    public partial class Form9 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2CKM1J2;Initial Catalog=E_Space;Integrated Security=True");
        public Form9()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Astronomer")
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
            }
            else if (comboBox1.Text == "Pilot")
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_SpaceDataSet44.Pilot' table. You can move, or remove it, as needed.
            this.pilotTableAdapter1.Fill(this.e_SpaceDataSet44.Pilot);
            // TODO: This line of code loads data into the 'e_SpaceDataSet43.Astronomer' table. You can move, or remove it, as needed.
            this.astronomerTableAdapter.Fill(this.e_SpaceDataSet43.Astronomer);
            // TODO: This line of code loads data into the 'e_SpaceDataSet34.E_Jet' table. You can move, or remove it, as needed.
            //this.e_JetTableAdapter.Fill(this.e_SpaceDataSet34.E_Jet);
            // TODO: This line of code loads data into the 'e_SpaceDataSet29.Astronomer' table. You can move, or remove it, as needed.
            //this.astronomerTableAdapter4.Fill(this.e_SpaceDataSet29.Astronomer);
            // TODO: This line of code loads data into the 'e_SpaceDataSet28.Astronomer' table. You can move, or remove it, as needed.
            //this.astronomerTableAdapter3.Fill(this.e_SpaceDataSet28.Astronomer);
            // TODO: This line of code loads data into the 'e_SpaceDataSet27.Astronomer' table. You can move, or remove it, as needed.
            //this.astronomerTableAdapter2.Fill(this.e_SpaceDataSet27.Astronomer);
            // TODO: This line of code loads data into the 'e_SpaceDataSet26.Pilot' table. You can move, or remove it, as needed.
            //this.pilotTableAdapter.Fill(this.e_SpaceDataSet26.Pilot);
            // TODO: This line of code loads data into the 'e_SpaceDataSet25.Astronomer' table. You can move, or remove it, as needed.
           // this.astronomerTableAdapter1.Fill(this.e_SpaceDataSet25.Astronomer);
            // TODO: This line of code loads data into the 'e_SpaceDataSet8.Astronomer' table. You can move, or remove it, as needed.
           // this.astronomerTableAdapter.Fill(this.e_SpaceDataSet8.Astronomer);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form23 form = new Form23();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox9.Text == "" || textBox2.Text == "" || textBox5.Text == "" || textBox7.Text == "" || textBox3.Text == "" || comboBox6.Text == "")
            {
                MessageBox.Show("Fillout the Empty Fields", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Astronomer (Astronomer_ID, Frist_Name, Middle_Name, Last_Name, Designation, Number_of_Space_Hours, Jet_ID) VALUES(' " + textBox1.Text + " ' , ' " + textBox2.Text + " ' ,  ' " + textBox9.Text + " ' , ' " + textBox3.Text + " ' , ' " + textBox5.Text + " ', ' " + textBox7.Text + " ', ' " + comboBox6.Text + " ' ) ", con);
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
                SqlCommand cmd = new SqlCommand("UPDATE Astronomer SET Astronomer_ID='" + textBox1.Text + "', Frist_Name='" + textBox2.Text + "', Middle_Name='" + textBox9.Text + "', Last_Name='" + textBox3.Text + "', Designation='" + textBox5.Text + "', Number_of_Space_Hours='" + textBox5.Text + "', Jet_ID='" + comboBox6.Text + "' WHERE Astronomer_ID='" + textBox4.Text + "' ", con);
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
                SqlCommand cmd = new SqlCommand("DELETE fROM Astronomer where Astronomer_ID like '" + textBox1.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Existing Client Details Deleted Successfull", "Client Details Deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                clearMethod();
                gridviewUpdate();
                con.Close();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || textBox10.Text == "")
            {
                MessageBox.Show("Fillout the Empty Fields", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Pilot (Astronomer_ID, Frist_Name, Middle_Name, Last_Name, Number_of_Space_Hours ) VALUES(' " + comboBox1.Text + " ' , ' " + comboBox2.Text + " ' ,  ' " + comboBox3.Text + " ' , ' " + comboBox4.Text + " ' , ' " + textBox10.Text + " ') ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearMethod2();
                gridviewupdate();
                con.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want to Update the Data ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Pilot SET Astronomer_ID='" + comboBox1.Text + "', Frist_Name='" + comboBox2.Text + "', Middle_Name='" + comboBox3.Text + "', Last_Name='" + comboBox4.Text + "', Number_of_Space_Hours='" + textBox10.Text + "' WHERE Astronomer_ID='" + textBox8.Text + "' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearMethod2();
                gridviewupdate();
                con.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                SqlCommand cmd = new SqlCommand("DELETE fROM Pilot where Astronomer_ID like '" + comboBox1.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Existing Client Details Deleted Successfull", "Client Details Deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                clearMethod2();
                gridviewupdate();
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Astronomer where Astronomer_ID LIKE '" + textBox4.Text + "'", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                textBox1.Text = sdr["Astronomer_ID"].ToString();
                textBox9.Text = sdr["Frist_Name"].ToString();
                textBox2.Text = sdr["Middle_Name"].ToString();
                textBox5.Text = sdr["Last_Name"].ToString();
                textBox7.Text = sdr["Designation"].ToString();
                textBox3.Text = sdr["Number_of_Space_Hours"].ToString();
                comboBox6.Text = sdr["Jet_ID"].ToString();
            }
            else
            {
                MessageBox.Show("Data Not Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Pilot where Astronomer_ID LIKE '" + textBox8.Text + "'", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                comboBox1.Text = sdr["Astronomer_ID"].ToString();
                comboBox2.Text = sdr["Frist_Name"].ToString();
                comboBox3.Text = sdr["Middle_Name"].ToString();
                comboBox4.Text = sdr["Last_Name"].ToString();
                textBox10.Text = sdr["Number_of_Space_Hours"].ToString();
            }
            else
            {
                MessageBox.Show("Data Not Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clearMethod();
        }
        public void clearMethod()
        {
            textBox1.Clear();
            textBox9.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox6.ResetText();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clearMethod2();
        }
        public void clearMethod2()
        {
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox1.ResetText();
            comboBox1.ResetText();
            textBox10.Clear();
            textBox8.Clear();
        }
        public void gridviewUpdate()
        {

            string select = "SELECT * from Astronomer";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Astronomer");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Astronomer";

        }
        public void gridviewupdate()
        {

            string select = "SELECT * from Pilot";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Pilot");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Pilot";

        }

    }
}
