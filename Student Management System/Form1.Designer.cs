namespace Student_Management_System
{
    partial class loginSite
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboUsername = new System.Windows.Forms.TextBox();
            this.tboPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btoLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // tboUsername
            // 
            this.tboUsername.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboUsername.Location = new System.Drawing.Point(45, 186);
            this.tboUsername.Name = "tboUsername";
            this.tboUsername.Size = new System.Drawing.Size(325, 31);
            this.tboUsername.TabIndex = 2;
            // 
            // tboPassword
            // 
            this.tboPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboPassword.Location = new System.Drawing.Point(45, 299);
            this.tboPassword.Name = "tboPassword";
            this.tboPassword.Size = new System.Drawing.Size(325, 31);
            this.tboPassword.TabIndex = 3;
            this.tboPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // btoLogin
            // 
            this.btoLogin.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoLogin.Location = new System.Drawing.Point(117, 361);
            this.btoLogin.Name = "btoLogin";
            this.btoLogin.Size = new System.Drawing.Size(192, 41);
            this.btoLogin.TabIndex = 5;
            this.btoLogin.Text = "Login";
            this.btoLogin.UseVisualStyleBackColor = true;
            this.btoLogin.Click += new System.EventHandler(this.btoLogin_Click);
            // 
            // loginSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(417, 481);
            this.Controls.Add(this.btoLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboPassword);
            this.Controls.Add(this.tboUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(435, 528);
            this.MinimumSize = new System.Drawing.Size(435, 528);
            this.Name = "loginSite";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboUsername;
        private System.Windows.Forms.TextBox tboPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btoLogin;
    }
}

