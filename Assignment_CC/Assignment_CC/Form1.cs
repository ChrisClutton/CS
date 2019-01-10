using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Assignment_CC
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        DataTable dbdataset;

        public Form1()
        {
            InitializeComponent();
            LoadTable();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            //Pull values for text boxes needed for encryption. StringBuilder used as opposed to String
            //for the message as StringBuilder is mutable where String isn't. This makes it easier to 
            //encrypt and decrypt the messages
            StringBuilder s = new StringBuilder(txtInput.Text);
            string key = txtKeyword.Text;
            txtOutput.Text = Encrypt(ref s, key);
            InsertData();
        }

        private static string Encrypt(ref StringBuilder s, string key)
        {
            //Char represents characters as numerical values. by doing this, messages can easily be
            //encoded by cycling through the message to be encoded and keyword, while accounting for
            //the end of the alphabet. encrypted messages are then returned as a string for output.
            for (int i = 0; i < s.Length; i++) s[i] = Char.ToUpper(s[i]);
            key = key.ToUpper();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    s[i] = (char)(s[i] + key[j] - 'A');
                    if (s[i] > 'Z') s[i] = (char)(s[i] - 'Z' + 'A' - 1);
                }
                j = j + 1 == key.Length ? 0 : j + 1; //this is an if else statement written using shorthand
                                                     // with "?" and ":"
            }
            return (s.ToString());
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            //Process of pulling values and saving to database identical to the one used when encoding
            StringBuilder s = new StringBuilder(txtInput.Text);
            string key = txtKeyword.Text;
            txtOutput.Text = Decrypt(ref s, key);
            InsertData();
        }
        private static string Decrypt(ref StringBuilder s, string key)
        {
            //process for decoding messages is almost identical to the encoding process, but in reverse
            //i.e. by removing the key values from the encoded message in order to obtain the original
            //message.
            for (int i = 0; i < s.Length; i++) s[i] = Char.ToUpper(s[i]);
            key = key.ToUpper();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    s[i] = s[i] >= key[j] ?
                              (char)(s[i] - key[j] + 'A') :
                              (char)('A' + ('Z' - key[j] + s[i] - 'A') + 1);
                }
                j = j + 1 == key.Length ? 0 : j + 1;
            }
            return (s.ToString());
        }

        private void InsertData()
        {
            //create a connection between the application and database using the connection string.
            //once connection is open, an SQL command is generated to insert required data into the 
            //database
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Chris\OneDrive\Documents\Log.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            cmd = new SqlCommand("INSERT INTO Log (Initials, Keyword, Time) VALUES (@Initials, @Keyword, @Time)", con);
            cmd.Parameters.AddWithValue("@Initials", txtInitials.Text);
            cmd.Parameters.AddWithValue("@Keyword", txtKeyword.Text);
            cmd.Parameters.AddWithValue("@Time", DateTime.Now);
            cmd.ExecuteNonQuery();
            LoadTable();
        }

        //exception handling for preventing entry of numbers into initials, keyword and Input fields.
        private void txtInitials_TextChanged(object sender, EventArgs e)
        {
            string initials = txtInitials.Text;
            bool isnum = false;
            for (int i = 0; i < initials.Length; i++)
            {
                if (char.IsNumber(initials[i]))
                {
                    isnum = true;
                    break;
                }
            }
            if (isnum)
            {
                MessageBox.Show("Please use alpha characters only");
                txtInitials.Text = String.Empty;
            }
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text;
            bool isnum = false;
            for (int i = 0; i < keyword.Length; i++)
            {
                if (char.IsNumber(keyword[i]))
                {
                    isnum = true;
                    break;
                }
            }
            if (isnum)
            {
                MessageBox.Show("Please use alpha characters only");
                txtKeyword.Text = String.Empty;
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            bool isnum = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsNumber(input[i]))
                {
                    isnum = true;
                    break;
                }
            }
            if (isnum)
            {
                MessageBox.Show("Please use alpha characters only");
                txtInput.Text = String.Empty;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //text boxes cleared and focus set to initials field.
            txtInitials.Text = String.Empty;
            txtKeyword.Text = String.Empty;
            txtInput.Text = String.Empty;
            txtOutput.Text = String.Empty;
            txtInitials.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //process for saving encoded or decoded messages in .txt format. the inital file name,
            //directory, file extension, filters and title for the save window are all set here.
            SaveFileDialog sfdSave = new SaveFileDialog();
            sfdSave.FileName = string.Format(DateTime.Now.ToString("yyyMMddHHmmss"));
            sfdSave.InitialDirectory = @"C:\";
            sfdSave.Title = "Save Text Files";
            sfdSave.DefaultExt = "txt";
            sfdSave.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfdSave.FileName))
                    sw.WriteLine(txtOutput.Text);
            }
        }

        void LoadTable()
        {
            //this method loads data from the database wherever it's called. this happens when
            //the application is opened and whenever a new record is added to the database.
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Chris\OneDrive\Documents\Log.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("select * from Log", con);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dbdataset = new DataTable();
                da.Fill(dbdataset);
                BindingSource bs = new BindingSource();

                bs.DataSource = dbdataset;
                dgLog.DataSource = bs;
                da.Update(dbdataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDateOrder_Click(object sender, EventArgs e)
        {
            //this method sorts all records by date order when the sort by date button is pressed
            dgLog.Sort(dgLog.Columns[3], ListSortDirection.Descending);
        }

        private void btnFilterKeyword_Click(object sender, EventArgs e)
        {
            //this method filters records by keyword when the filter by keyword button is pressed
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Keyword LIKE '%{0}%'", txtFilter.Text);
            dgLog.DataSource = DV;
        }

        private void btnFilterInitials_Click(object sender, EventArgs e)
        {
            //this methiod filters records by initials when the filter by operator button is pressed
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Initials LIKE '%{0}%'", txtFilter.Text);
            dgLog.DataSource = DV;
        }

        private void btnFilterDateKeyword_Click(object sender, EventArgs e)
        {
            //this method filters by Keyword AND dates when the filter  by date and keyword button
            //is pressed.
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Time >= '{0}' AND Time <= '{1}' AND Keyword LIKE '%{2}%'", dtpStartDate.Value.Date, dtpEndDate.Value.Date, txtFilter.Text);
            dgLog.DataSource = DV;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Time >= '{0}' AND Time <= '{1}'", dtpStartDate.Value.Date, dtpEndDate.Value.Date);
            dgLog.DataSource = DV;
            lblTotal.Text = dgLog.RowCount.ToString();
        }
    }
}
