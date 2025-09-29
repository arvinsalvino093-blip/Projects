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
    public partial class Form23 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2CKM1J2;Initial Catalog=E_Space;Integrated Security=True");
        public Form23()
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
            if (comboBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Fillout the Empty Fields", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Astronomer_Qualification (Astronomer_ID, Qualification) VALUES(' " + comboBox1.Text + " ' , ' " + textBox2.Text + " ' ) ", con);
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
                SqlCommand cmd = new SqlCommand("UPDATE Astronomer_Qualification SET  Astronomer_ID='" + comboBox1.Text + "', Qualification='" + textBox2.Text + "' WHERE Qualification='" + textBox4.Text + "' ", con);
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
                SqlCommand cmd = new SqlCommand("DELETE fROM Astronomer_Qualification where Astronomer_ID like '" + comboBox1.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Existing Client Details Deleted Successfull", "Client Details Deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                clearMethod();
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Astronomer_Qualification where Qualification LIKE '" + textBox4.Text + "'", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                comboBox1.Text = sdr["Astronomer_ID"].ToString();
                textBox2.Text = sdr["Qualification"].ToString();
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
            comboBox1.ResetText();
            textBox2.Clear();
            textBox4.Clear();
        }

        private void Form23_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_SpaceDataSet31.Astronomer_Qualification' table. You can move, or remove it, as needed.
            this.astronomer_QualificationTableAdapter.Fill(this.e_SpaceDataSet31.Astronomer_Qualification);
            // TODO: This line of code loads data into the 'e_SpaceDataSet6.Astronomer' table. You can move, or remove it, as needed.
            this.astronomerTableAdapter.Fill(this.e_SpaceDataSet6.Astronomer);

        }

    }
}
