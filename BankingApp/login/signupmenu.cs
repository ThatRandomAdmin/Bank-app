using System;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class signupmenu : Form
    {
        public signupmenu()
        {
            InitializeComponent();
        }

        private void signupmenu_Load(object sender, EventArgs e)
        {

        }

        private void sup_Click(object sender, EventArgs e)
        {
            //Opens account menu
            menu2 frm = new menu2();
            frm.ShowDialog();
        }
    }
}
