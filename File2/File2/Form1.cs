using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstNames.Items.Add(txtInput.Text);
            txtInput.Text = String.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach (string item in lstNames.Items)
                   {
                        sw.WriteLine(item);
                   }
            //close file
            sw.Close();
            }
            
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            while (sr.Peek() != -1)
            {
                lstNames.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }
    }
}
