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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2CKM1J2;Initial Catalog=E_Space;Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_SpaceDataSet39.House' table. You can move, or remove it, as needed.
            this.houseTableAdapter.Fill(this.e_SpaceDataSet39.House);
            // TODO: This line of code loads data into the 'e_SpaceDataSet21.House' table. You can move, or remove it, as needed.
            //this.houseTableAdapter.Fill(this.e_SpaceDataSet21.House);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox9.Text == "" )
            {
                MessageBox.Show("Fillout the Empty Fields", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO House (Colony_Lot_No, Number_OF_Rooms, Square_Feet) VALUES(' " + textBox1.Text + " ' , ' " + textBox2.Text + " ' , ' " + textBox9.Text + " ' ) ", con);
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
                SqlCommand cmd = new SqlCommand("UPDATE House SET Number_OF_Rooms='" + textBox2.Text + "', Square_Feet='" + textBox9.Text + "' WHERE Colony_Lot_No='" + textBox1.Text + "' ", con);
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
                SqlCommand cmd = new SqlCommand("DELETE fROM House where Colony_Lot_No like '" + textBox4.Text + "'", con);
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
            SqlCommand cmd = new SqlCommand("select * from House where Colony_Lot_No LIKE '" + textBox4.Text + "'", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
           // if (sdr.Read())
              while (sdr.Read())
            {
                textBox1.Text = sdr["Colony_Lot_No"].ToString();
                textBox2.Text = sdr["Number_OF_Rooms"].ToString();
                textBox9.Text = sdr["Square_Feet"].ToString();
            }
           // else
           // {
           //    MessageBox.Show("Data Not Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            textBox2.Clear();
            textBox9.Clear();
            textBox4.Clear();
        }
        public void gridviewUpdate()
        {

            string select = "SELECT * from House";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "House");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "House";

        }

    }
}
