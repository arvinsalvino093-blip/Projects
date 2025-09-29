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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2CKM1J2;Initial Catalog=E_Space;Integrated Security=True");
        public Form4()
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
            if (guna2ComboBox1.Text == "" || textBox2.Text == "" || dateTimePicker1.Text == "" || textBox3.Text == "" ||  comboBox1.Text == "" )
            {
                MessageBox.Show("Fillout the Empty Fields", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Dependent (Mars_Colonization_ID, Frist_Name, Last_Name, Gender, DOB, Relationship_To_The_Colonist) VALUES(' " + guna2ComboBox1.Text + " ' , ' " + textBox2.Text + " ' ,  ' " + textBox5.Text + " ' , ' " + comboBox1.Text + " ' , ' " + dateTimePicker1.Text + " ', ' " + textBox3.Text + " ') ", con);
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
                SqlCommand cmd = new SqlCommand("UPDATE Dependent SET Frist_Name='" + textBox2.Text + "', Last_Name='" + textBox5.Text + "', Gender='" + comboBox1.Text + "', DOB='" + dateTimePicker1.Text + "', Relationship_To_The_Colonist='" + textBox3.Text + "' WHERE Mars_Colonization_ID='" + guna2ComboBox1.Text + "' ", con);
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
                SqlCommand cmd = new SqlCommand("DELETE fROM Dependent where Mars_Colonization_ID like '" + textBox4.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Existing Client Details Deleted Successfull", "Client Details Deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
            comboBox1.ResetText();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            guna2ComboBox1.ResetText();
            dateTimePicker1.ResetText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox4.Text);
            SqlCommand cmd = new SqlCommand("select * from Dependent where Mars_Colonization_ID LIKE '" + textBox4.Text + "'", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            //if (sdr.Read())
            while (sdr.Read())
            {
                comboBox1.Text = sdr["Mars_Colonization_ID"].ToString();
                textBox2.Text = sdr["Frist_Name"].ToString();
                textBox5.Text = sdr["Last_Name"].ToString();
                dateTimePicker1.Text = sdr["DOB"].ToString();
                guna2ComboBox1.Text = sdr["Gender"].ToString();
                textBox3.Text = sdr["Relationship_To_The_Colonist"].ToString();
            }
           //else
           // {
           //     MessageBox.Show("Data Not Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }
            con.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_SpaceDataSet76.Dependent' table. You can move, or remove it, as needed.
            this.dependentTableAdapter.Fill(this.e_SpaceDataSet76.Dependent);
            // TODO: This line of code loads data into the 'e_SpaceDataSet75.Colonist' table. You can move, or remove it, as needed.
            this.colonistTableAdapter.Fill(this.e_SpaceDataSet75.Colonist);
            // TODO: This line of code loads data into the 'e_SpaceDataSet74.Dependent' table. You can move, or remove it, as needed.
            //this.dependentTableAdapter.Fill(this.e_SpaceDataSet74.Dependent);
            // TODO: This line of code loads data into the 'e_SpaceDataSet73.Colonist2' table. You can move, or remove it, as needed.
            //this.colonist2TableAdapter.Fill(this.e_SpaceDataSet73.Colonist2);
            // TODO: This line of code loads data into the 'e_SpaceDataSet64.Dependent' table. You can move, or remove it, as needed.
            //this.dependentTableAdapter.Fill(this.e_SpaceDataSet64.Dependent);
            // TODO: This line of code loads data into the 'e_SpaceDataSet63.Colonist' table. You can move, or remove it, as needed.
            //this.colonistTableAdapter.Fill(this.e_SpaceDataSet63.Colonist);
            // TODO: This line of code loads data into the 'e_SpaceDataSet59.Colonist' table. You can move, or remove it, as needed.
            //this.colonistTableAdapter.Fill(this.e_SpaceDataSet59.Colonist);
            // TODO: This line of code loads data into the 'e_SpaceDataSet38.Dependent' table. You can move, or remove it, as needed.
           // this.dependentTableAdapter.Fill(this.e_SpaceDataSet38.Dependent);
            // TODO: This line of code loads data into the 'e_SpaceDataSet20.Dependent' table. You can move, or remove it, as needed.
            //this.dependentTableAdapter.Fill(this.e_SpaceDataSet20.Dependent);
            // TODO: This line of code loads data into the 'e_SpaceDataSet9.Colonist' table. You can move, or remove it, as needed.
            //this.colonistTableAdapter.Fill(this.e_SpaceDataSet9.Colonist);

        }
        public void gridviewUpdate()
        {

            string select = "SELECT * from Dependent";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Dependent");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Dependent";

        }
    }
}
