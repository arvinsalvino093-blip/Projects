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
    public partial class Form10 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\A.S.Asbury\OneDrive\Documents\programming\leave management system\leave management system\Database1.mdf;Integrated Security=True");
        public Form10()
        {
            InitializeComponent();
            comboBox2.SelectedIndexChanged += new EventHandler(comboBox2_SelectedIndexChanged);
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet22.Apply_Leaves' table. You can move, or remove it, as needed.
            this.apply_LeavesTableAdapter.Fill(this.database1DataSet22.Apply_Leaves);
            // TODO: This line of code loads data into the 'database1DataSet16.Apply_Leaves' table. You can move, or remove it, as needed.
            //this.apply_LeavesTableAdapter4.Fill(this.database1DataSet16.Apply_Leaves);
            // TODO: This line of code loads data into the 'database1DataSet15.Apply_Leaves' table. You can move, or remove it, as needed.
           // this.apply_LeavesTableAdapter3.Fill(this.database1DataSet15.Apply_Leaves);
            // TODO: This line of code loads data into the 'database1DataSet14.Apply_Leaves' table. You can move, or remove it, as needed.
            //this.apply_LeavesTableAdapter2.Fill(this.database1DataSet14.Apply_Leaves);
            // TODO: This line of code loads data into the 'database1DataSet10.Apply_Leaves' table. You can move, or remove it, as needed.
           // this.apply_LeavesTableAdapter1.Fill(this.database1DataSet10.Apply_Leaves);
            // TODO: This line of code loads data into the 'database1DataSet9.Apply_Leaves' table. You can move, or remove it, as needed.
          //  this.apply_LeavesTableAdapter.Fill(this.database1DataSet9.Apply_Leaves);
            // Populate ComboBox with leave types
           
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLeave_Type = comboBox2.SelectedItem.ToString();
            string query = "SELECT * FROM Apply_Leaves WHERE Leave_Type = @Leave_Type";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Leave_Type", selectedLeave_Type);

            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
