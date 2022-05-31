using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List2
{
    public partial class Ukol1 : Form
    {
        public Ukol1()
        {
            InitializeComponent();
        }

        List<int> list = new List<int>();
        public void AddToList(List<int> list, int pocet_prvku, int d)
        {
            int a1 = list.Max();
            for (int i = 0; i < pocet_prvku; i++)
            {
                list.Add(a1);
                a1 += d;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int n = (int)numericUpDown1.Value;
            int a1 = (int)numericUpDown2.Value;
            int d = (int)numericUpDown3.Value;

            for (int i = 0; i < n; i++)
            {
                list.Add(a1);
                listBox1.Items.Add(a1);
                a1 += d;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddToList(list, (int)numericUpDown1.Value, (int)numericUpDown3.Value);
            listBox1.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                listBox1.Items.Add(list[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();   
        }
    }
}
