using System;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class menu1 : Form
    {
        public menu1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            //Exits application
            this.Hide();
            this.Close();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            //Opens signin menu
            signinmenu sin = new signinmenu();
            sin.TopLevel = false;
            sin.AutoScroll = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(sin);
            sin.Show();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            //Opens signup menu
            signupmenu sup = new signupmenu();
            sup.TopLevel = false;
            sup.AutoScroll = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(sup);
            sup.Show();
        }
    }
}
