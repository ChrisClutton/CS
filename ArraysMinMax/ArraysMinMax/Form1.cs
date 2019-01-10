using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysMinMax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] minMax = { 45, 25, 21, 26 };

        private void btnMax_Click(object sender, EventArgs e)
        {
            int max = minMax.Max();
            lblMax.Text = max.ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int min = minMax.Min();
            lblMin.Text = min.ToString();
        }
    }
}
