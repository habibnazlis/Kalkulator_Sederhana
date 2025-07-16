using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            labelHasil.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {          
                MessageBox.Show("Angka 1 & Angka 2 harus diisi!");
            }
            else 
            {
                int a, b, c;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = a + b;
                this.labelHasil.Text = c.ToString();
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            labelHasil.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 & Angka 2 harus diisi!");
            }
            else
            {
                int a, b, c;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = a - b;
                this.labelHasil.Text = c.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 & Angka 2 harus diisi!");
            }
            else
            {
                int a, b, c;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = a * b;
                this.labelHasil.Text = c.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 & Angka 2 harus diisi!");
            }
            else
            {
                int a, b, c;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = a / b;
                this.labelHasil.Text = c.ToString();
            }
        }
    }
}
