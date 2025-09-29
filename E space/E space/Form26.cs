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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void Form26_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_SpaceDataSet18.Colonist_Job' table. You can move, or remove it, as needed.
            this.colonist_JobTableAdapter.Fill(this.e_SpaceDataSet18.Colonist_Job);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form19 form = new Form19();
            form.Show();
            this.Hide();
        }
    }
}
