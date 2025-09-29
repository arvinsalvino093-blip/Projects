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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form18 form = new Form18();
            form.Show();
            this.Hide();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_SpaceDataSet13.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.e_SpaceDataSet13.Job);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form19 form = new Form19();
            form.Show();
            this.Hide();
        }
    }
}
