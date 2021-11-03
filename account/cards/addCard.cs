using System.Windows.Forms;

namespace BankingApp
{
    public partial class addCard : Form
    {
        public bool btn1;
        public bool btn2;
        public bool btn3;
        public bool btn4;
        public bool btn5;

        public addCard()
        {
            InitializeComponent();
        }

        private void addCard_Load(object sender, System.EventArgs e)
        {
            save.Checked = true;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            while (txt.Text != "")
            {
                cardList crdl = new cardList();
                btn1 = true;

                this.Hide();
                this.Close();
            }
        }
    }
}
