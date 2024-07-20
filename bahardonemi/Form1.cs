using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bahardonemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim, soy;
            double v1, f1, bit,ort;
            isim = txtisim.Text;
            soy = txtsoy.Text;
            v1 = Convert.ToDouble(txtvize.Text);
            f1 = Convert.ToDouble(txtfinal.Text);
            bit = Convert.ToDouble(txtbit.Text);
            ort = (v1 * 0.2) + (f1 * 0.3) + (bit * 0.5);
            if(ort>=60)
            {
                listBox1.Items.Add(isim  + " " + soy + " =" + " " + v1 + " " + f1 + "  " + bit + " " + " = " + ort + " " + "Geçtiniz");
            }
            else
            {
                listBox1.Items.Add(isim  + " " + soy + " =" + " " + v1 + " " + f1 + "  " + bit + " "+" = "+ ort + " " + "Kaldınız");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtisim.Text = "";
            txtsoy.Text = "";
            txtvize.Text = "";
            txtfinal.Text = "";
            txtbit.Text = "";
            

        }
    }
}
