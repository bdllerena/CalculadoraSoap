using Calculadora.Calculadora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Calculos obj = new Calculos();

        int a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);

            b = Convert.ToInt32(textBox2.Text);

            c = obj.Add(a, b);

            label4.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);

            b = Convert.ToInt32(textBox2.Text);

            c = obj.Sub(a, b);

            label4.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);

            b = Convert.ToInt32(textBox2.Text);

            c = obj.Div(a, b);

            label4.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);

            b = Convert.ToInt32(textBox2.Text);

            c = obj.Mul(a, b);

            label4.Text = c.ToString();
        }
    }
}
