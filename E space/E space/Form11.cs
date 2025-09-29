using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace E_space
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form18 form = new Form18();
            form.Show();
            this.Hide();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_SpaceDataSet10.Colonist' table. You can move, or remove it, as needed.
            this.colonistTableAdapter1.Fill(this.e_SpaceDataSet10.Colonist);
            // TODO: This line of code loads data into the 'e_SpaceDataSet.Colonist' table. You can move, or remove it, as needed.
            //this.colonistTableAdapter.Fill(this.e_SpaceDataSet.Colonist);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
