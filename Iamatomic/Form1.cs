using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iamatomic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 8; 
            int y = 8;
            if (x<y)
            {
                label1.Text = "X Küçüktür";
            }
            if (x>y)
            {
                label1.Text = "X Büyüktür";
            }
            if (x==y)
            {
                label1.Text = "Sayılar Eşittir";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1, s2;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            if (s1<s2)
            {
                label2.Text = "s1 küçüktür";
            }
            if (s2 < s1)
            {
                label2.Text = "s2 küçüktür";
            }
            if (s1 == s2)
            {
                label2.Text = "sayılar eşittir";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label5.Text = "Kadın Seçildi";
            }
            if (radioButton2.Checked)
            {
                label5.Text = "Erkek Seçildi";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
