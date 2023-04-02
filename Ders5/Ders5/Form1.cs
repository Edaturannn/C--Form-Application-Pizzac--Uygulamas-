using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox6.Items.Add(comboBox2.Text);
            if (checkBox1.Checked==true)
            {
                listBox7.Items.Add(checkBox1.Text);
            }
            if (checkBox2.Checked==true)
            {
                listBox7.Items.Add(checkBox2.Text);
            }
            if (checkBox3.Checked==true)
            {
                listBox7.Items.Add(checkBox3.Text);
            }
            if (checkBox4.Checked==true)
            {
                listBox7.Items.Add(checkBox3.Text);
            }
            if (checkBox5.Checked==true)
            {
                listBox7.Items.Add(checkBox5.Text);
            }
            if (checkBox6.Checked==true)
            {
                listBox7.Items.Add(checkBox6.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
        }
    }
}
