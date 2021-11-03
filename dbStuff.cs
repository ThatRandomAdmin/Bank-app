using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace BankingApp
{
    class dbStuff
    {
        public OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\willf\Documents\Code\c#\bank-app\BankingApp\Accdata.mdb;Jet OLEDB:Database Password=login;");
        public OleDbCommand cmd = new OleDbCommand();
    }

}
