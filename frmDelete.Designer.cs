namespace WindowsFormsApp2
{
    partial class frmDelete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstAccounts = new System.Windows.Forms.ListBox();
            this.lblSelectAccount = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAccounts
            // 
            this.lstAccounts.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstAccounts.ForeColor = System.Drawing.Color.Yellow;
            this.lstAccounts.FormattingEnabled = true;
            this.lstAccounts.ItemHeight = 23;
            this.lstAccounts.Location = new System.Drawing.Point(210, 118);
            this.lstAccounts.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lstAccounts.Name = "lstAccounts";
            this.lstAccounts.Size = new System.Drawing.Size(283, 326);
            this.lstAccounts.TabIndex = 0;
            // 
            // lblSelectAccount
            // 
            this.lblSelectAccount.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAccount.ForeColor = System.Drawing.Color.Yellow;
            this.lblSelectAccount.Location = new System.Drawing.Point(206, 32);
            this.lblSelectAccount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSelectAccount.Name = "lblSelectAccount";
            this.lblSelectAccount.Size = new System.Drawing.Size(269, 62);
            this.lblSelectAccount.TabIndex = 1;
            this.lblSelectAccount.Text = "Select an Account to Delete";
            this.lblSelectAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(242, 466);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(223, 42);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(691, 522);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSelectAccount);
            this.Controls.Add(this.lstAccounts);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmDelete";
            this.Text = "Delete";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAccounts;
        private System.Windows.Forms.Label lblSelectAccount;
        private System.Windows.Forms.Button btnDelete;
    }
}