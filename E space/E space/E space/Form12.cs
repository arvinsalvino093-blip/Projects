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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form18 form = new Form18();
            form.Show();
            this.Hide();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_SpaceDataSet11.Dependent' table. You can move, or remove it, as needed.
            this.dependentTableAdapter.Fill(this.e_SpaceDataSet11.Dependent);

        }
    }
}
