using System;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class accountDetails : Form
    {
        //db variables
        dbStuff db = new dbStuff();

        public accountDetails()
        {
            InitializeComponent();
        }

        private void accountDetails_Load(object sender, EventArgs e)
        {
            //string usersname;
            //string uid;

            //Make back hidden on startup
            last.Visible = false;

            //Default panel
            settings1 set1 = new settings1();
            set1.TopLevel = false;
            set1.AutoScroll = false;
            settingsPanel.Controls.Clear();
            settingsPanel.Controls.Add(set1);
            set1.Show();

            //set label to welcome user
           // label1.Text = $"Welcome, {usersname}";
           // Console.WriteLine(uid);
           // Console.WriteLine("hi");


        }

        private void next_Click(object sender, EventArgs e)
        {
            next.Visible = false;
            last.Visible = true;
            settings2 set2 = new settings2();
            set2.TopLevel = false;
            set2.AutoScroll = false;
            settingsPanel.Controls.Clear();
            settingsPanel.Controls.Add(set2);
            set2.Show();
        }

        private void last_Click(object sender, EventArgs e)
        {
            last.Visible = false;
            next.Visible = true;
            settings1 set1 = new settings1();
            set1.TopLevel = false;
            set1.AutoScroll = false;
            settingsPanel.Controls.Clear();
            settingsPanel.Controls.Add(set1);
            set1.Show();
        }
    }
}
