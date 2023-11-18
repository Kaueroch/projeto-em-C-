using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vetor_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] num = new int[10];
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (i <= 9)
            {
                num[i] = Convert.ToInt32(textBox1.Text);
                i++;
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= 9; i++)
            {
                listBox1.Items.Add("Num[" + i + "]=" + num[i]);
                if (num[i] % 2 == 0)
                {
                    listBox2.Items.Add("Num[" + i + "]=" + num[i]);
                }
                else
                {
                    listBox1.Items.Add("Num[" + i + "]=" + num[i]);
                }
                if (num[i] % 3 == 0)
                {
                    listBox3.Items.Add("Num[" + i + "]=" + num[i]);
                }
                else
                {
                    listBox1.Items.Add("Num[" + i + "]=" + num[i]);
                }
            }
        }

    }

}
