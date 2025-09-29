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
    public partial class Form7 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2CKM1J2;Initial Catalog=E_Space;Integrated Security=True");
        public Form7()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || guna2ComboBox1.Text == "" || dateTimePicker1.Text == "" || dateTimePicker2.Text == "")
            {
                MessageBox.Show("Fillout the Empty Fields", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Trip (Trip_ID, Launch_Date, Return_Date, Jet_ID) VALUES(' " + textBox1.Text + " ' , ' " + dateTimePicker1.Text + " ' , ' " + dateTimePicker2.Text + " ', ' " + guna2ComboBox1.Text + " ' ) ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearMethod();
                gridviewUpdate();
                con.Close();
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_SpaceDataSet80.Trip' table. You can move, or remove it, as needed.
            this.tripTableAdapter.Fill(this.e_SpaceDataSet80.Trip);
            // TODO: This line of code loads data into the 'e_SpaceDataSet79.E_Jet' table. You can move, or remove it, as needed.
            this.e_JetTableAdapter.Fill(this.e_SpaceDataSet79.E_Jet);
            // TODO: This line of code loads data into the 'e_SpaceDataSet56.E_Jet' table. You can move, or remove it, as needed.
           // this.e_JetTableAdapter.Fill(this.e_SpaceDataSet56.E_Jet);
            // TODO: This line of code loads data into the 'e_SpaceDataSet41.Trip' table. You can move, or remove it, as needed.
            //this.tripTableAdapter.Fill(this.e_SpaceDataSet41.Trip);
            // TODO: This line of code loads data into the 'e_SpaceDataSet23.Trip' table. You can move, or remove it, as needed.
            //this.tripTableAdapter.Fill(this.e_SpaceDataSet23.Trip);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want to Update the Data ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Trip SET  Launch_Date='" + dateTimePicker1.Text + "', Return_Date='" + dateTimePicker2.Text + "', Jet_ID='" + guna2ComboBox1.Text + "' WHERE Trip_ID='" + textBox1.Text + "' ", con);
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
                SqlCommand cmd = new SqlCommand("DELETE fROM Trip where Trip_ID like '" + textBox4.Text + "'", con);
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
            MessageBox.Show(textBox4.Text);
            SqlCommand cmd = new SqlCommand("select * from Trip where Trip_ID LIKE '" + textBox4.Text + "'", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
           // if (sdr.Read())
                while (sdr.Read())
            {
                textBox1.Text = sdr["Trip_ID"].ToString();
                guna2ComboBox1.Text = sdr["Jet_ID"].ToString();
                dateTimePicker1.Text = sdr["Launch_Date"].ToString();
                dateTimePicker2.Text = sdr["Return_Date"].ToString();
            }
           // else
           // {
           //     MessageBox.Show("Data Not Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // }
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clearMethod();
        }
        public void clearMethod()
        {
            textBox1.Clear();
            guna2ComboBox1.ResetText();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
            textBox4.Clear();
        }
        public void gridviewUpdate()
        {

            string select = "SELECT * from Trip";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Trip");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Trip";

        }
    }
}
