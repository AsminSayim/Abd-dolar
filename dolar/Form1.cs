using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dolar=Convert.ToDouble(textBox1.Text);
            double miktar=Convert.ToDouble(textBox2.Text);
            double toplam = dolar * miktar;
            label3.Text = "Toplam Tutar:" + toplam;
        }
    }
}
