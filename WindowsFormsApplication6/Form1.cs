using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int sayı;
            for (sayı = 0; sayı <= 100; sayı++)
            {
                if (sayı % 10 != 0) listBox1.Items.Add(sayı);
                toplam += sayı;
            }
            label1.Text = ("Toplamları:" + toplam.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
