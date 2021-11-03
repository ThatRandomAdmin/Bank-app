using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BankingApp
{
    public partial class signinmenu : Form
    {
        //db variables
        dbStuff db = new dbStuff();

        public signinmenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void sin_Click(object sender, EventArgs e)
        {
            //open connection to db
            db.con.Open();
            db.cmd.Connection = db.con;

            //checks if user entered data
            if (username.Text != "" && password.Text != "")
            {
                db.cmd.CommandText = "select * from logins where uname='" + username.Text + "' and pword='" + password.Text + "'";

                //read db for all instances of entered data
                OleDbDataReader read = db.cmd.ExecuteReader();


                //check how many times data was entered
                int count = 0;
                while (read.Read())
                {
                    count++;
                }
                read.Close();
                read.Dispose();

                //if account exists
                if (count > 0)
                {
                    //gets userID
                    db.cmd.CommandText = "SELECT ID FROM logins WHERE uname = [pid]";
                    db.cmd.Parameters.AddWithValue("pid", username.Text);
                    OleDbDataReader reader = db.cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string uid = reader["ID"].ToString();
                    }

                    //gets username
                    string usersname = username.Text;

                    //clears text entry in prep for logout
                    username.Clear();
                    password.Clear();

                    //opens account menu
                    menu2 frm = new menu2();
                    frm.ShowDialog();
                }
                //if it doesn't exist
                else
                {
                    //clears text entry box
                    username.Clear();
                    password.Clear();

                    //changes login button to display error message
                    sin.Text = "Wrong Username or Password";
                    var t = new Timer();
                    t.Interval = 2000;
                    t.Tick += (s, en) =>
                    {
                        sin.Text = "Sign in";
                        t.Stop();
                    };
                    t.Start();
                }
            }
            else
            {
                //clears text entry box
                username.Clear();
                password.Clear();

                //changes login button to display error message
                sin.Text = "You need to enter data";
                var t = new Timer();
                t.Interval = 2000;
                t.Tick += (s, en) =>
                {
                    sin.Text = "Sign in";
                    t.Stop();
                };
                t.Start();
            }

            //closes db connection
            db.con.Close();
        }
    }
}
