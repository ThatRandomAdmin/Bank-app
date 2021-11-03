using System;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class cardMenu : Form
    {
        public cardMenu()
        {
            InitializeComponent();
        }

        private void cardMenu_Load(object sender, EventArgs e)
        {
            //Default panel
            cardList cardlis = new cardList();
            cardlis.TopLevel = false;
            cardlis.AutoScroll = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(cardlis);
            cardlis.Show();
        }

        private void addCard_Click(object sender, EventArgs e)
        {
            addCard cardadd = new addCard();
            cardadd.TopLevel = false;
            cardadd.AutoScroll = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(cardadd);
            cardadd.Show();
            addCard.Visible = false;
        }

        
    }
}
