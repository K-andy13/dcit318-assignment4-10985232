using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUp
{
    public partial class Address : Form

        
    {public String Name{ set;get; }
        public String email { set;get; }
        public String phone {  set;get; }
        public Address()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name = textBox1.Text;
            email = textBox2.Text;
            phone = textBox3.Text;
            MessageBox.Show("Saved");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();



        }
    }
}
