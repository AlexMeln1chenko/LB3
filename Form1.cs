using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double l=0, k=0;
            double x = double.Parse(textBoxX.Text);
            double p = double.Parse(textBoxP.Text);
            if (radioButton1.Checked)
                k = Math.Sinh(x);
            if (radioButton2.Checked)
                k = x * x;
            if (radioButton3.Checked)
                k = Math.Pow(Math.E, x);
            textBox3.Text += Environment.NewLine + "x =" + x.ToString() + Environment.NewLine + "p =" + p.ToString();
            if (x > Math.Abs(p)) l = 2 * Math.Pow(k, 3) + 3 * p * p;
            else if (3 < x && x < Math.Abs(p)) l = Math.Abs(k - p);
            else if (x == Math.Abs(p)) l = Math.Pow(k - p, 2);
            else textBox3.Text += Environment.NewLine + "Функция не имеет решений при данных P и X";
            textBox3.Text += Environment.NewLine + "l =" + l.ToString() + Environment.NewLine;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxX.Text) || String.IsNullOrEmpty(textBoxP.Text))
                button1.Enabled = false;
            else button1.Enabled = true;
        }
    }
}
