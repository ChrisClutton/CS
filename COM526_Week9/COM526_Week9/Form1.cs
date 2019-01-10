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

namespace COM526_Week9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                List<string> cList = GetInputFromFile(path);
                addToDb(cList);
                DBEntities db = new DBEntities();
                populateGrid(db.Conservatives.ToList());
            }
        }

        private void populateGrid(List<Conservative> list)
        {
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].HeaderCell.Value = "Importance";
        }

        private void addToDb(List<string> cList)
        {
            DBEntities db = new DBEntities();
            foreach (var item in cList)
            {
                string[] wordArray = item.Split(',');
                Conservative c = new Conservative();
                c.Position = wordArray[0].ToString();
                c.Name = wordArray[1].ToString();
                c.Usefulness = false;
                db.Conservatives.Add(c);
            }
            db.SaveChanges();
        }

        private List<string> GetInputFromFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            List<string> memberList = new List<string>();
            while(sr.Peek()!=-1)
            {
                memberList.Add(sr.ReadLine());
            }
            sr.Close();
            return memberList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            int c = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            DBEntities db = new DBEntities();
            Conservative con = db.Conservatives.Where(i => i.Id == c).First();
            textBox2.Text = con.Id.ToString();
            textBox3.Text = con.Position.ToString();
            textBox4.Text = con.Name.ToString();
            checkBox1.Checked = con.Usefulness;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DBEntities db = new DBEntities();
            int i = int.Parse(textBox2.Text);
            Conservative con = db.Conservatives.Where(a => a.Id == i).First();
            con.Position = textBox3.Text;
            con.Name = textBox4.Text;
            con.Usefulness = checkBox1.Checked;
            db.SaveChanges();
            populateGrid(db.Conservatives.ToList());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DBEntities db = new DBEntities();
            string str = txtSearch.Text;
            List<Conservative> conList = db.Conservatives.Where(c => c.Position.ToUpper().Contains(str)).ToList();
            populateGrid(conList);
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DBEntities db = new DBEntities();
            List<Conservative> conList;
            switch (e.ColumnIndex)
            {
                case 0:
                    conList = db.Conservatives.OrderBy(c => c.Id).ToList();
                    break;
                case 1:
                    conList = db.Conservatives.OrderBy(c => c.Position).ToList();
                    break;
                case 2:
                    conList = db.Conservatives.OrderBy(c => c.Name).ToList();
                    break;
                case 3:
                    conList = db.Conservatives.OrderBy(c => c.Usefulness).ToList();
                    break;
                default:
                    conList = db.Conservatives.ToList();
                    break;  
            }
            populateGrid(conList);
        }
    }
}
