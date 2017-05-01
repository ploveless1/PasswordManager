namespace WindowsFormsApp2
{
    partial class frmSettings
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMaster = new System.Windows.Forms.Label();
            this.lblSpecial = new System.Windows.Forms.Label();
            this.txtMaster = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtSpecial = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.chkCapital = new System.Windows.Forms.CheckBox();
            this.chkNumber = new System.Windows.Forms.CheckBox();
            this.chkSpecChar = new System.Windows.Forms.CheckBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(564, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblMaster
            // 
            this.lblMaster.AutoSize = true;
            this.lblMaster.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaster.ForeColor = System.Drawing.Color.Yellow;
            this.lblMaster.Location = new System.Drawing.Point(129, 144);
            this.lblMaster.Name = "lblMaster";
            this.lblMaster.Size = new System.Drawing.Size(143, 23);
            this.lblMaster.TabIndex = 1;
            this.lblMaster.Text = "Master Password";
            // 
            // lblSpecial
            // 
            this.lblSpecial.AutoSize = true;
            this.lblSpecial.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecial.ForeColor = System.Drawing.Color.Yellow;
            this.lblSpecial.Location = new System.Drawing.Point(12, 218);
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(260, 23);
            this.lblSpecial.TabIndex = 2;
            this.lblSpecial.Text = "Special Characters: !, $, &, etc.";
            // 
            // txtMaster
            // 
            this.txtMaster.BackColor = System.Drawing.Color.Black;
            this.txtMaster.ForeColor = System.Drawing.Color.Yellow;
            this.txtMaster.Location = new System.Drawing.Point(293, 148);
            this.txtMaster.Name = "txtMaster";
            this.txtMaster.Size = new System.Drawing.Size(377, 20);
            this.txtMaster.TabIndex = 3;
            // 
            // txtLength
            // 
            this.txtLength.BackColor = System.Drawing.Color.Black;
            this.txtLength.ForeColor = System.Drawing.Color.Yellow;
            this.txtLength.Location = new System.Drawing.Point(553, 222);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(117, 20);
            this.txtLength.TabIndex = 5;
            // 
            // txtSpecial
            // 
            this.txtSpecial.BackColor = System.Drawing.Color.Black;
            this.txtSpecial.ForeColor = System.Drawing.Color.Yellow;
            this.txtSpecial.Location = new System.Drawing.Point(293, 222);
            this.txtSpecial.Name = "txtSpecial";
            this.txtSpecial.Size = new System.Drawing.Size(117, 20);
            this.txtSpecial.TabIndex = 6;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.ForeColor = System.Drawing.Color.Yellow;
            this.lblLength.Location = new System.Drawing.Point(434, 219);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(102, 23);
            this.lblLength.TabIndex = 7;
            this.lblLength.Text = "Min. Length";
            // 
            // chkCapital
            // 
            this.chkCapital.AutoSize = true;
            this.chkCapital.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCapital.Location = new System.Drawing.Point(63, 311);
            this.chkCapital.Name = "chkCapital";
            this.chkCapital.Size = new System.Drawing.Size(112, 20);
            this.chkCapital.TabIndex = 8;
            this.chkCapital.Text = "Include Capitals";
            this.chkCapital.UseVisualStyleBackColor = true;
            // 
            // chkNumber
            // 
            this.chkNumber.AutoSize = true;
            this.chkNumber.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNumber.Location = new System.Drawing.Point(293, 311);
            this.chkNumber.Name = "chkNumber";
            this.chkNumber.Size = new System.Drawing.Size(118, 20);
            this.chkNumber.TabIndex = 9;
            this.chkNumber.Text = "Include Numbers";
            this.chkNumber.UseVisualStyleBackColor = true;
            // 
            // chkSpecChar
            // 
            this.chkSpecChar.AutoSize = true;
            this.chkSpecChar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSpecChar.Location = new System.Drawing.Point(489, 311);
            this.chkSpecChar.Name = "chkSpecChar";
            this.chkSpecChar.Size = new System.Drawing.Size(171, 20);
            this.chkSpecChar.TabIndex = 10;
            this.chkSpecChar.Text = "Include Special Characters";
            this.chkSpecChar.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(289, 91);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(99, 19);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "Error Message";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(709, 461);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.chkSpecChar);
            this.Controls.Add(this.chkNumber);
            this.Controls.Add(this.chkCapital);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtSpecial);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtMaster);
            this.Controls.Add(this.lblSpecial);
            this.Controls.Add(this.lblMaster);
            this.Controls.Add(this.btnSave);
            this.MaximumSize = new System.Drawing.Size(725, 500);
            this.MinimumSize = new System.Drawing.Size(725, 500);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMaster;
        private System.Windows.Forms.Label lblSpecial;
        private System.Windows.Forms.TextBox txtMaster;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtSpecial;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.CheckBox chkCapital;
        private System.Windows.Forms.CheckBox chkNumber;
        private System.Windows.Forms.CheckBox chkSpecChar;
        private System.Windows.Forms.Label lblError;
    }
}