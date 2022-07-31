using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_No_Generator
{
    public partial class DICL : Form
    {
        List<int> genValues =new List<int>();
        List<Players> PlayersList = new List<Players>();
        public DICL()
        {
            InitializeComponent();
            
            lstArray.Text = "";
            lstArray.MaximumSize = new Size(600, 0);
            lstArray.AutoSize = true;
            lblGenName.Text = "";
            this.WindowState = FormWindowState.Maximized;

            //int height = Screen.PrimaryScreen.Bounds.Height;
            //int width = Screen.PrimaryScreen.Bounds.Width;

            //WindowState = FormWindowState.Maximized;
            //MinimumSize = this.Size;
            //MaximumSize = this.Size;

            GetAllUsers();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text == "" || txtTo.Text == "")
                MessageBox.Show("Please provide From and To value.");
            else if((Convert.ToInt32(txtTo.Text)) < (Convert.ToInt32(txtFrom.Text)))
                MessageBox.Show("From Value is greater than To value.");
            else if (Convert.ToInt32(txtTo.Text) > 56)
                MessageBox.Show("To Value should not be greater than 56.");
            else
            {
                if ((Convert.ToInt32(txtTo.Text)+ 1) - (Convert.ToInt32(txtFrom.Text)) != genValues.Count)
                {
                    Random rnd = new Random();
                    int value = 0;
                    do
                    {
                        value = rnd.Next(Convert.ToInt32(txtFrom.Text), Convert.ToInt32(txtTo.Text) + 1);

                        if (genValues.Count == 0)
                            break;

                    } while (genValues.Contains(value));

                    genValues.Add(value);

                    Players Pl = new Players();
                    Pl = PlayersList.Where(m => m.Id == value).FirstOrDefault();

                    lblGenNo.Text = value.ToString() + ".";
                    lblGenName.Text = "";
                    llblPlLink.ImageKey = Pl.BasePrice;
                    llblPlLink.Text = Pl.Name;
                    lblGenName.Text = Pl.BasePrice;
                    lstArray.Text = "";
                    foreach (int a in genValues)
                    {
                        lstArray.Text += a.ToString() + " | ";
                    }
                    lstArray.ToString().TrimEnd('|');
                    //if(Pl.Retained != "0")
                    //{
                    //    lblGenName.Text = Pl.Name + " is Retained";
                    //}
                }
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            genValues.Clear();
            lstArray.Text = "";
            lblGenNo.Text = "No";
            lblGenName.Text = "";
            txtFrom.Text = "";
            txtTo.Text = "";
            llblPlLink.Text = "Player Name";
        }
        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            genValues.Clear();
            lstArray.Text = "";
            lblGenNo.Text = "No";
            lblGenName.Text = "";
            llblPlLink.Text = "Player Name";
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {
            genValues.Clear();
            lstArray.Text = "";
            lblGenNo.Text = "No";
            lblGenName.Text = "";
            llblPlLink.Text = "Player Name";
        }

        private void GetAllUsers()
        {            
            PlayersList.Add(new Players(1, "Nabakishore Prusty", "Base Amount 500K", "0"));
            PlayersList.Add(new Players(2, "Dheeraj More", "Base Amount 500K", "0"));
            PlayersList.Add(new Players(3, "Akash Giri", "Base Amount 500K", "0"));
            PlayersList.Add(new Players(4, "Pratheek Acharya", "Base Amount 500K", "0"));
            PlayersList.Add(new Players(5, "Shubhank Manoj", "Base Amount 500K", "0"));
            PlayersList.Add(new Players(6, "Navneet Padhy", "Base Amount 500K", "0"));
            PlayersList.Add(new Players(7, "Agrim Vaibhav", "Base Amount 500K", "0"));
            PlayersList.Add(new Players(8, "Shailesh Jha", "Base Amount 200K", "0"));
            PlayersList.Add(new Players(9, "Ramesh  Subramanian", "Base Amount 200K", "0"));
            PlayersList.Add(new Players(10, "Pushkaraj Badbade", "Base Amount 200K", "0"));
            PlayersList.Add(new Players(11, "Ravikumar Ganti", "Base Amount 200K", "0"));
            PlayersList.Add(new Players(12, "Sadananda Nayak", "Base Amount 200K", "0"));
            PlayersList.Add(new Players(13, "Saumil Bhavsar", "Base Amount 200K", "0"));
            PlayersList.Add(new Players(14, "Chhannoo lal Verma", "Base Amount 200K", "0"));
            PlayersList.Add(new Players(15, "Akhilesh Pendharkar", "Base Amount 200K", "0"));
            PlayersList.Add(new Players(16, "Santosh Shelke", "Base Amount 200K", "0"));
            PlayersList.Add(new Players(17, "Ramesh Mandal", "Base Amount 200K", "0"));
            PlayersList.Add(new Players(18, "Rajiv Pillai", "Base Amount 200K", "0"));
            PlayersList.Add(new Players(19, "Tapan Singh", "Base Amount 200K", "0"));
            PlayersList.Add(new Players(20, "Divyam  Dama", "Base Amount 200K", "0"));
            PlayersList.Add(new Players(21, "Anmol Rai", "Base Amount 200K", "0"));
            PlayersList.Add(new Players(22, "Dr Sudhakar Babras", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(23, "Devaki nandan Aggarwal", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(24, "Vinod Dighe", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(25, "Vijay Kumar", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(26, "Kalyanam Narayanswamy", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(27, "Shivram Iyer", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(28, "Valayapathy Thangaraju", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(29, "Prakash Shinde", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(30, "Sham d lone Lone", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(31, "Rajesh Singh", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(32, "Pradeep Dubey", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(33, "Abhrajit Kundu", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(34, "Nagraj Wadimath", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(35, "DUMMY", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(36, "Ashish Pandey", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(37, "Tripurari Pratap", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(38, "Abhishek Bajpayee", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(39, "Swapnil Gawde", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(40, "Atul Khairnar", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(41, "Pratik Shevle", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(42, "Ankit Agarwal", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(43, "Pearl  Dhamesha", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(44, "Swati  Sharma", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(45, "Lekha mishra  Hedge", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(46, "DUMMY", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(47, "Sadiya Vanjara", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(48, "Arya Talaulikar", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(49, "Dhruv Narula", "Base Amount 100K", "0"));
            PlayersList.Add(new Players(50, "Pratik Salian", "Base Amount 50K", "0"));
            PlayersList.Add(new Players(51, "Anish Shirke", "Base Amount 50K", "0"));
            PlayersList.Add(new Players(52, "DUMMY", "Base Amount 50K", "0"));
            PlayersList.Add(new Players(53, "Harshal Salian", "Base Amount 50K", "0"));
            PlayersList.Add(new Players(54, "Dhruv Maheshwari", "Base Amount 50K", "0"));
            PlayersList.Add(new Players(55, "Vedant Misal", "Base Amount 50K", "0"));
            PlayersList.Add(new Players(56, "Saransh Dwivedi", "Base Amount 50K", "0"));




        }

        private void llblPlLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start(((System.Windows.Forms.LinkLabel)sender).ImageKey);
        }

        private void lblGenNo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DICL_Load(object sender, EventArgs e)
        {
            lblGenName.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblGenName_Click(object sender, EventArgs e)
        {

        }

        private void lstArray_Click(object sender, EventArgs e)
        {

        }
    }

    public class Players
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BasePrice { get; set; }

        public string Retained { get; set; }

        public Players()
        {

        }
        public Players(int ID, string Name, string Link, string retained)
        {
            this.Id = ID;
            this.Name = Name;
            this.BasePrice = Link;
            this.Retained = retained;

        }
    }
}
