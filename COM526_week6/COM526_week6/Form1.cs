using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace COM526_week6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"courseList.xml");
            XmlNodeList fNumbers = doc.GetElementsByTagName("number");
            XmlNodeList fTitles = doc.GetElementsByTagName("title");
            XmlNodeList fCredits = doc.GetElementsByTagName("credits");
            for (int i = 0; i < fNumbers.Count; i++)
            {
                lsbXML.Items.Add(string.Format("{0},{1},{2}", fNumbers[i].InnerText, fTitles[i].InnerText, fCredits[i].InnerText));
            }
        }

        private List<Course> AddToGenericList()
        {
            List<Course> myList = new List<Course>();
            foreach (string item in lsbXML.Items) 
            {
                string[] words = item.Split(',');
                Course c = new Course();
                c.Number = words[0].Trim();
                c.Title = words[1].Trim();
                c.Credit = words[2].Trim();
                myList.Add(c);
            }
            return myList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Course> myCourseList = AddToGenericList();
            if (addToXmlDoc(myCourseList))
            {
                MessageBox.Show("Saved!");
            }
        }

        private bool addToXmlDoc(List<Course>xmllist)
        {
            XDocument doc = new XDocument(new XElement("course_list",
                from a in xmllist
                select
                new XElement("course",
                new XElement("number",a.Number),
                new XElement("title",a.Title),
                new XElement("credit",a.Credit))));
            doc.Save(@"document.xml");
            return true;
        }
    }
}
