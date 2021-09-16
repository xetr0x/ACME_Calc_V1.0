using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACME_Calc_V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }


        private void button1_Click(object sender, EventArgs e)
        {
            int i, j;
            i = Int32.Parse(textBox1.Text);
            j = Int32.Parse(textBox2.Text);
            listBox1.Items.Add($"{i} + {j} = {i + j}");
            listBox1.Items.Add($"{j} + {i} = {j + i}");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, j;
            i = Int32.Parse(textBox1.Text);
            j = Int32.Parse(textBox2.Text);
            listBox1.Items.Add($"{i} - {j} = {i - j}");
            listBox1.Items.Add($"{j} - {i} = {j - i}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, j;
            i = Int32.Parse(textBox1.Text);
            j = Int32.Parse(textBox2.Text);
            listBox1.Items.Add($"{i} / {j} = {i / j}");
            listBox1.Items.Add($"{j} / {i} = {j / i}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i, j;
            i = Int32.Parse(textBox1.Text);
            j = Int32.Parse(textBox2.Text);
            listBox1.Items.Add($"{i} * {j} = {i * j}");
            listBox1.Items.Add($"{j} * {i} = {j * i}");
        }

    }
}
