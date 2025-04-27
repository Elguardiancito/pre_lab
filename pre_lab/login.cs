using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pre_lab
{
    public partial class login: Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Alejandro" && textBox2.Text == "pan con queso")
            {
                MessageBox.Show("Usuario ingresado, pase adelante!");
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("nop, esa no es");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
