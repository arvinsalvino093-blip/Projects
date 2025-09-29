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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form20 form = new Form20();
            form.Show();
            this.Hide();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_SpaceDataSet15.E_Jet' table. You can move, or remove it, as needed.
            this.e_JetTableAdapter.Fill(this.e_SpaceDataSet15.E_Jet);

        }
    }
}
