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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form18 form = new Form18();
            form.Show();
            this.Hide();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_SpaceDataSet16.Astronomer' table. You can move, or remove it, as needed.
            this.astronomerTableAdapter.Fill(this.e_SpaceDataSet16.Astronomer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form20 form = new Form20();
            form.Show();
            this.Hide();
        }
    }
}
