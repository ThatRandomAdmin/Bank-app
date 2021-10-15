using System;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class menu2 : Form
    {

        public menu2()
        {
            InitializeComponent();
        }

        private void menu2_Load(object sender, EventArgs e)
        {
            //Default panel
            cardMenu cardmen = new cardMenu();
            cardmen.TopLevel = false;
            cardmen.AutoScroll = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(cardmen);
            cardmen.Show();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            //Opens card selection menu
            cardMenu cardmen = new cardMenu();
            cardmen.TopLevel = false;
            cardmen.AutoScroll = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(cardmen);
            cardmen.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            //Closes form
            this.Hide();
            this.Close();
        }

        private void account_Click(object sender, EventArgs e)
        {
            //Opens account form
            accountDetails accdet = new accountDetails();
            accdet.TopLevel = false;
            accdet.AutoScroll = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(accdet);
            accdet.Show();
        }
    }
}
