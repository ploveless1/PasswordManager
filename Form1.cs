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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtSMP = new System.Windows.Forms.TextBox();
            this.btnSMP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSMP
            // 
            this.txtSMP.Location = new System.Drawing.Point(197, 155);
            this.txtSMP.Name = "txtSMP";
            this.txtSMP.Size = new System.Drawing.Size(325, 20);
            this.txtSMP.TabIndex = 0;
            // 
            // btnSMP
            // 
            this.btnSMP.Location = new System.Drawing.Point(197, 248);
            this.btnSMP.Name = "btnSMP";
            this.btnSMP.Size = new System.Drawing.Size(155, 53);
            this.btnSMP.TabIndex = 1;
            this.btnSMP.Text = "Set Master Password";
            this.btnSMP.UseVisualStyleBackColor = true;
            this.btnSMP.Click += new System.EventHandler(this.btnSMP_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(725, 426);
            this.Controls.Add(this.btnSMP);
            this.Controls.Add(this.txtSMP);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void btnSMP_Click(object sender, EventArgs e)
        {
            string str_MP;
            int int_MPlength;

            str_MP = txtSMP.Text;
            int_MPlength = str_MP.Length;
            
            try
            {
                if (int_MPlength <= 15 && int_MPlength >=8)
                {
                    SQLiteDB.DatabasePath = "Task1SMP.db";
                    SQLiteDB db = SQLiteDB.GetInstance;
                    db.NonSelectQuery("INSERT INTO MasterPassword (MP) VALUES ('" + str_MP + "')");

                    db.CloseConnection(); 
                }
                else
                {
                    throw new ArgumentException();
                }
            }

            catch (Exception)
            {
                MessageBox.Show(int_MPlength.ToString(),  "This value is not in the correct range!");
            }
            
            

        }
    }
}
