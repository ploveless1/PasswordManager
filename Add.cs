using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using DB;

namespace _1st_Tasks
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str_addname;
            string str_adduser;
            string str_addpass;
            string str_addq;
            string str_adda;
            string str_addnotes;

            str_addname = txtAdd_name.Text;
            str_adduser = txtAdd_user.Text;
            str_addpass = txtAdd_pass.Text;
            str_addq = txtAdd_q.Text;
            str_adda = txtAdd_a.Text;
            str_addnotes = txtAdd_notes.Text;

            try
            {
                if (str_addname != "" && str_adduser != "" && str_addpass != "")
                {
                    SQLiteDB.DatabasePath = "credential.db";
                    SQLiteDB db = SQLiteDB.GetInstance;

                    db.NonSelectQuery("INSERT INTO credentials (Name, Username, Password, Question, Answer, Notes) VALUES ('" + str_addname + "', '" + str_adduser + "', '" + str_addpass + "', '" + str_addq + "', '" + str_adda + "', '" + str_addnotes + "')");

                    db.CloseConnection();
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Did not enter in all required fields");
            }


            
        }
    }
}
