using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDecorador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            double total;
            String tot;
            int[] prices = { 60, 80, 100, 50, 70, 54, 40, 30, 98, 56 };
            total = prices[comboBox1.SelectedIndexChanged()];


            txt_preciounit.setText(" " + total);
            string selected = cmbbox.Text;
            MessageBox.Show(selected);
        }

    }
}