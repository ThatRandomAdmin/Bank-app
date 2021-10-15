using System;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class cardList : Form
    {
        public cardList()
        {
            InitializeComponent();
        }

        private void cardList_Load(object sender, EventArgs e)
        {
            addCard add = new addCard();
            if(add.btn1 == true)
            {
                button1.Visible = true;
                cardMenu crdm = new cardMenu();
                crdm.addCard.Visible = true;
                Console.WriteLine(add.btn1);
            }
        }
    }
}
