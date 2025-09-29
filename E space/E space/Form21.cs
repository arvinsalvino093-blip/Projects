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
    public partial class Form21 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2CKM1J2;Initial Catalog=E_Space;Integrated Security=True");
        public Form21()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_SpaceDataSet91.E_Jet' table. You can move, or remove it, as needed.
            this.e_JetTableAdapter1.Fill(this.e_SpaceDataSet91.E_Jet);
            // TODO: This line of code loads data into the 'e_SpaceDataSet90.Trip' table. You can move, or remove it, as needed.
            this.tripTableAdapter1.Fill(this.e_SpaceDataSet90.Trip);
            // TODO: This line of code loads data into the 'e_SpaceDataSet89.Colonist' table. You can move, or remove it, as needed.
            this.colonistTableAdapter1.Fill(this.e_SpaceDataSet89.Colonist);
            // TODO: This line of code loads data into the 'e_SpaceDataSet33.GO_TO' table. You can move, or remove it, as needed.
            this.gO_TOTableAdapter.Fill(this.e_SpaceDataSet33.GO_TO);
            // TODO: This line of code loads data into the 'e_SpaceDataSet4.E_Jet' table. You can move, or remove it, as needed.
            this.e_JetTableAdapter.Fill(this.e_SpaceDataSet4.E_Jet);
            // TODO: This line of code loads data into the 'e_SpaceDataSet3.Trip' table. You can move, or remove it, as needed.
            this.tripTableAdapter.Fill(this.e_SpaceDataSet3.Trip);
            // TODO: This line of code loads data into the 'e_SpaceDataSet2.Colonist' table. You can move, or remove it, as needed.
            this.colonistTableAdapter.Fill(this.e_SpaceDataSet2.Colonist);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (guna2ComboBox1.Text == "" || guna2ComboBox2.Text == "" || guna2ComboBox3.Text == "")
            {
                MessageBox.Show("Fillout the Empty Fields", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO GO_TO (Mars_Colonization_ID, Trip_ID, Jet_ID) VALUES(' " + guna2ComboBox1.Text + " ' , ' " + guna2ComboBox2.Text + " ' , ' " + guna2ComboBox3.Text + " ' ) ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearMethod();
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want to Update the Data ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE GO_TO SET  Trip_ID='" + guna2ComboBox2.Text + "', Jet_ID='" + guna2ComboBox3.Text + "' WHERE Mars_Colonization_ID='" + guna2ComboBox1.Text + "' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearMethod();
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                SqlCommand cmd = new SqlCommand("DELETE fROM GO_TO where Mars_Colonization_ID like '" + textBox4.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Existing Client Details Deleted Successfull", "Client Details Deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                clearMethod();
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox4.Text);
            SqlCommand cmd = new SqlCommand("select * from House where Mars_Colonization_ID LIKE '" + textBox4.Text + "'", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
           // if (sdr.Read())
            while (sdr.Read())
            {
                guna2ComboBox1.Text = sdr["Mars_Colonization_ID"].ToString();
                guna2ComboBox2.Text = sdr["Trip_ID"].ToString();
                guna2ComboBox3.Text = sdr["Jet_ID"].ToString();
            }
           // else
          //  {
          //      MessageBox.Show("Data Not Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
          //  }
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clearMethod();
        }
        public void clearMethod()
        {
            guna2ComboBox1.ResetText();
            guna2ComboBox2.ResetText();
            guna2ComboBox3.ResetText();
            textBox4.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
