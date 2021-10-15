using System;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class signinmenu : Form
    {
        public signinmenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void sin_Click(object sender, EventArgs e)
        {
            //Opens account menu
            menu2 frm = new menu2();
            frm.ShowDialog();
        }
    }
}
