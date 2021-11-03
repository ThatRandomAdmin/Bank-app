using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BankingApp
{
    public partial class signupmenu : Form
    {
        //db variables
        dbStuff db = new dbStuff();

        public signupmenu()
        {
            InitializeComponent();
        }

        private void signupmenu_Load(object sender, EventArgs e)
        {
            
        }

        private void sup_Click(object sender, EventArgs e)
        {
            //open connection to db
            db.con.Open();
            db.cmd.Connection = db.con;

            //check if data was entered
            if (username.Text != "" && password.Text != "" && npassword.Text != "")
            {
                db.cmd.CommandText = "select * from logins where uname='" + username.Text + "'";

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

                //if username is taken
                if (count > 0)
                {
                    //clears text entry box
                    username.Clear();
                    password.Clear();
                    npassword.Clear();

                    //changes login button to display error message
                    sup.Text = "Username already taken";
                    var t = new Timer();
                    t.Interval = 2000;
                    t.Tick += (s, en) =>
                    {
                        sup.Text = "Sign up";
                        t.Stop();
                    };
                    t.Start();
                }
                //if passwords aren't equal
                else if (password.Text != npassword.Text)
                {
                    //clears text entry box
                    username.Clear();
                    password.Clear();
                    npassword.Clear();

                    //changes login button to display error message
                    sup.Text = "Passwords entered not the same";
                    var t = new Timer();
                    t.Interval = 2000;
                    t.Tick += (s, en) =>
                    {
                        sup.Text = "Sign up";
                        t.Stop();
                    };
                    t.Start();
                }
                //if all data is good..
                else
                {
                    //creates account
                    db.cmd.CommandText = "insert into logins (uname,pword) values('" + username.Text + "','" + password.Text + "')";
                    db.cmd.ExecuteNonQuery();

                    //gets userID
                    db.cmd.CommandText = "SELECT ID FROM logins WHERE uname = [pid]";
                    db.cmd.Parameters.AddWithValue("pid", username.Text);
                    OleDbDataReader reader = db.cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //uid = reader["ID"].ToString();
                    }

                    //gets username
                   // usersname = username.Text;

                    //clears text entry in prep for logout
                    username.Clear();
                    password.Clear();
                    npassword.Clear();

                    //Opens account menu
                    menu2 frm = new menu2();
                    frm.ShowDialog();
                }
            }
            else
            {
                //clears text entry box
                username.Clear();
                password.Clear();
                npassword.Clear();

                //changes login button to display error message
                sup.Text = "You need to enter data";
                var t = new Timer();
                t.Interval = 2000;
                t.Tick += (s, en) =>
                {
                    sup.Text = "Sign up";
                    t.Stop();
                };
                t.Start();
            }
            db.con.Close();
        }
    }
}
