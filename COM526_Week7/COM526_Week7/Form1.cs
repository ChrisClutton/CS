using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COM526_Week7
{
    public partial class Form1 : Form
    {
        Paint paint;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            paint = new Paint();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Wall wall = new Wall();
            wall.Height = double.Parse(txtHeight.Text);
            wall.Length = double.Parse(txtLength.Text);
            lstHeight.Items.Add(wall.Height);
            txtHeight.Text = String.Empty;
            lstLength.Items.Add(wall.Length);
            txtLength.Text = String.Empty;
            paint.AddWall(wall);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            paint.Price = double.Parse(txtPrice.Text);
            paint.Area = double.Parse(txtArea.Text);

            txtCost.Text = paint.Cost().ToString();
        }
    }
}
