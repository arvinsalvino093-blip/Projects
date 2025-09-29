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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (textBox1.Text == "1" && textBox2.Text == "2")
            {
                MessageBox.Show("Login Successfully");
                Form2 form= new Form2();
                form.Show();
                this.Hide();
            }
            else if (textBox1.Text == "3" && textBox2.Text == "4")
            {
                MessageBox.Show("Login Successfully");
                Form18 form = new Form18();
                form.Show();
                this.Hide();

            }

            else if (textBox1.Text == "5" && textBox2.Text == "6")
            {
                MessageBox.Show("Login Successfully");
                Form19 form = new Form19();
                form.Show();
                this.Hide();

            }

            else if (textBox1.Text == "7" && textBox2.Text == "8")
            {
                MessageBox.Show("Login Successfully");
                Form20 form = new Form20();
                form.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Please Enter a Correct Login Details", "Login Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
