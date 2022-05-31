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
    public partial class Ukol2 : Form
    {
        public Ukol2()
        {
            InitializeComponent();
        }

		List<int> list = new List<int>();
		public int DostatecnyPocetPrvku(List<int> list, int p)
		{
			int soucet = 0;
			if (list.Count >= p)
			{
				for (int i = 0; i < p; i++)
				{
					soucet += list[i];
				}
				return soucet;
			}
			else return 0;
		}
		private void button2_Click(object sender, EventArgs e)
        {
			listBox1.Items.Clear();
			int n = (int)numericUpDown1.Value;
			int a1 = (int)numericUpDown2.Value;
			int a2 = (int)numericUpDown3.Value;
			int rozdil = a2 - a1;
			list.Add(a1);
			listBox1.Items.Add(a1);

			for (int i = 0; i < n; i++)
			{
				list.Add(a2);
				listBox1.Items.Add(a2);
				a2 *= rozdil;
			}
			button3.Enabled = true;
		}

        private void button1_Click(object sender, EventArgs e)
        {
			Form1 form1 = new Form1();
			form1.Show();
			this.Close();
		}

        private void button3_Click(object sender, EventArgs e)
        {

			MessageBox.Show(DostatecnyPocetPrvku(list, (int)numericUpDown4.Value).ToString());
		}
    }
}
