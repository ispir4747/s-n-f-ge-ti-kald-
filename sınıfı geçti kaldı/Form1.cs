using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınıfı_geçti_kaldı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int viz = Convert.ToInt32(textBox1.Text);
            int fin = Convert.ToInt32(textBox2.Text);
            int yuz = (viz * 40) + (fin * 60) / 200;
            if (yuz>=50)
            { label3.Text = ("sınıfı_geçt"); }
            else
            { label3.Text = ("kaldınız"); }

        }
    }
}
