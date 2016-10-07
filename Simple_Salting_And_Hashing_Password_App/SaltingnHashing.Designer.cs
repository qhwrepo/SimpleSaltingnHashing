namespace Simple_Salting_And_Hashing_Password_App
{
    partial class SaltingnHashing
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblSalt = new System.Windows.Forms.Label();
            this.lblHashed = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxSalt = new System.Windows.Forms.TextBox();
            this.txtBoxHashed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(327, 27);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(67, 119);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Salt SHA256";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblSalt
            // 
            this.lblSalt.AutoSize = true;
            this.lblSalt.Location = new System.Drawing.Point(20, 70);
            this.lblSalt.Name = "lblSalt";
            this.lblSalt.Size = new System.Drawing.Size(65, 12);
            this.lblSalt.TabIndex = 1;
            this.lblSalt.Text = "Salt Value";
            // 
            // lblHashed
            // 
            this.lblHashed.AutoSize = true;
            this.lblHashed.Location = new System.Drawing.Point(20, 110);
            this.lblHashed.Name = "lblHashed";
            this.lblHashed.Size = new System.Drawing.Size(77, 12);
            this.lblHashed.TabIndex = 2;
            this.lblHashed.Text = "Hashed Value";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 30);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 12);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(113, 27);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(183, 21);
            this.txtBoxPassword.TabIndex = 4;
            // 
            // txtBoxSalt
            // 
            this.txtBoxSalt.Location = new System.Drawing.Point(113, 67);
            this.txtBoxSalt.Name = "txtBoxSalt";
            this.txtBoxSalt.ReadOnly = true;
            this.txtBoxSalt.Size = new System.Drawing.Size(183, 21);
            this.txtBoxSalt.TabIndex = 5;
            // 
            // txtBoxHashed
            // 
            this.txtBoxHashed.Location = new System.Drawing.Point(113, 107);
            this.txtBoxHashed.Multiline = true;
            this.txtBoxHashed.Name = "txtBoxHashed";
            this.txtBoxHashed.ReadOnly = true;
            this.txtBoxHashed.Size = new System.Drawing.Size(183, 39);
            this.txtBoxHashed.TabIndex = 6;
            // 
            // SaltingnHashing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 170);
            this.Controls.Add(this.txtBoxHashed);
            this.Controls.Add(this.txtBoxSalt);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblHashed);
            this.Controls.Add(this.lblSalt);
            this.Controls.Add(this.btnGenerate);
            this.Name = "SaltingnHashing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salting and Hashing Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblSalt;
        private System.Windows.Forms.Label lblHashed;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxSalt;
        private System.Windows.Forms.TextBox txtBoxHashed;
    }
}

