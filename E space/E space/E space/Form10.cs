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
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == "1" && password == "2")
            {
                MessageBox.Show("You have logged in Successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form18 form18 = new Form18();
                form18.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Please try again.", "Notification", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
