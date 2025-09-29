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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2CKM1J2;Initial Catalog=E_Space;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_SpaceDataSet72.Trip' table. You can move, or remove it, as needed.
            this.tripTableAdapter.Fill(this.e_SpaceDataSet72.Trip);
            // TODO: This line of code loads data into the 'e_SpaceDataSet71.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.e_SpaceDataSet71.Job);
            // TODO: This line of code loads data into the 'e_SpaceDataSet70.House' table. You can move, or remove it, as needed.
            this.houseTableAdapter.Fill(this.e_SpaceDataSet70.House);
            // TODO: This line of code loads data into the 'e_SpaceDataSet69.Colonist2' table. You can move, or remove it, as needed.
            this.colonist2TableAdapter.Fill(this.e_SpaceDataSet69.Colonist2);
            // TODO: This line of code loads data into the 'e_SpaceDataSet68.Colonist' table. You can move, or remove it, as needed.
           // this.colonistTableAdapter.Fill(this.e_SpaceDataSet68.Colonist);
            // TODO: This line of code loads data into the 'e_SpaceDataSet67.Trip' table. You can move, or remove it, as needed.
            //this.tripTableAdapter.Fill(this.e_SpaceDataSet67.Trip);
            // TODO: This line of code loads data into the 'e_SpaceDataSet66.Job' table. You can move, or remove it, as needed.
            //this.jobTableAdapter.Fill(this.e_SpaceDataSet66.Job);
            // TODO: This line of code loads data into the 'e_SpaceDataSet65.House' table. You can move, or remove it, as needed.
           // this.houseTableAdapter.Fill(this.e_SpaceDataSet65.House);
            // TODO: This line of code loads data into the 'e_SpaceDataSet49.Trip' table. You can move, or remove it, as needed.
           // this.tripTableAdapter.Fill(this.e_SpaceDataSet49.Trip);
            // TODO: This line of code loads data into the 'e_SpaceDataSet47.Job' table. You can move, or remove it, as needed.
           // this.jobTableAdapter.Fill(this.e_SpaceDataSet47.Job);
            // TODO: This line of code loads data into the 'e_SpaceDataSet45.House' table. You can move, or remove it, as needed.
           // this.houseTableAdapter.Fill(this.e_SpaceDataSet45.House);
            // TODO: This line of code loads data into the 'e_SpaceDataSet37.Colonist' table. You can move, or remove it, as needed.
            //this.colonistTableAdapter.Fill(this.e_SpaceDataSet37.Colonist);
            // TODO: This line of code loads data into the 'e_SpaceDataSet19.Colonist' table. You can move, or remove it, as needed.
            //this.colonistTableAdapter.Fill(this.e_SpaceDataSet19.Colonist);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want to Update the Data ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Colonist2 SET Frist_Name='" + textBox2.Text + "', Middle_Name='" + textBox9.Text + "', Last_Name='" + textBox10.Text + "', Civil_Status='" + comboBox1.Text + "', Gender='" + comboBox2.Text + "', Contact_No='" + textBox3.Text + "', Earth_Address='" + textBox5.Text + "', DOB='" + dateTimePicker1.Text + "', Number_of_people_bring_to_Mars='" + textBox11.Text + "', Colony_Lot_No='" + guna2ComboBox1.Text + "', Job_ID='" + guna2ComboBox2.Text + "', Trip_ID='" + guna2ComboBox3.Text + "' WHERE Mars_Colonization_ID='" + textBox1.Text + "' ", con);
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
                SqlCommand cmd = new SqlCommand("DELETE fROM Colonist2 where Mars_Colonization_ID like '" + textBox4.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Existing Client Details Deleted Successfull", "Client Details Deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                clearMethod();
                gridviewUpdate();
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox9.Text == "" || textBox10.Text == "" || dateTimePicker1.Text == "" || textBox3.Text == "" || textBox5.Text == "" || comboBox2.Text == "" || comboBox1.Text == "" || textBox11.Text == "" || guna2ComboBox1.Text == "" || guna2ComboBox2.Text == "" || guna2ComboBox3.Text == "")
            {
                MessageBox.Show("Fillout the Empty Fields", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Colonist2 (Mars_Colonization_ID, Frist_Name, Middle_Name, Last_Name, DOB, Contact_No, Earth_Address, Gender, Civil_Status, Number_of_people_bring_to_Mars, Colony_Lot_No, Job_ID, Trip_ID) VALUES(' " + textBox1.Text + " ' , ' " + textBox2.Text + " ' , ' " + textBox9.Text + " ' , ' " + textBox10.Text + " ' , ' " + dateTimePicker1.Text + " ' , ' " + textBox3.Text + " ' , ' " + textBox5.Text + " ', ' " + comboBox2.Text + " ', ' " + comboBox1.Text + " ', ' " + textBox11.Text + " ', ' " + guna2ComboBox1.Text + " ', ' " + guna2ComboBox2.Text + " ', ' " + guna2ComboBox3.Text + " ') ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            textBox4.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox5.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
            guna2ComboBox1.ResetText();
            guna2ComboBox2.ResetText();
            guna2ComboBox3.ResetText();
            dateTimePicker1.ResetText();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox4.Text);
            SqlCommand cmd = new SqlCommand("select * from Colonist2 where Mars_Colonization_ID LIKE '" + textBox4.Text + "'", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            //if (sdr.Read())
            while (sdr.Read())
            {
                textBox1.Text = sdr["Mars_Colonization_ID"].ToString();
                textBox2.Text = sdr["Frist_Name"].ToString();
                textBox9.Text = sdr["Middle_Name"].ToString();
                textBox10.Text = sdr["Last_Name"].ToString();
                dateTimePicker1.Text = sdr["DOB"].ToString();
                textBox3.Text = sdr["Contact_No"].ToString();
                textBox5.Text = sdr["Earth_Address"].ToString();
                comboBox2.Text = sdr["Gender"].ToString();
                comboBox1.Text = sdr["Civil_Status"].ToString();
                textBox11.Text = sdr["Number_of_people_bring_to_Mars"].ToString();
                guna2ComboBox1.Text = sdr["Colony_Lot_No"].ToString();
                guna2ComboBox2.Text = sdr["Job_ID"].ToString();
                guna2ComboBox3.Text = sdr["Trip_ID"].ToString();
            }
          //  else
          //  {
           //    MessageBox.Show("Data Not Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form22 form = new Form22();
            form.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void gridviewUpdate()
        {

            string select = "SELECT * from Colonist";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Colonist");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Colonist";

        }
        
    }
}
