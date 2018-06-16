using System;
using System.Drawing;

namespace GitData
{
    partial class GitData
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
            this.usernameToSearch = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.yourGitHubUsername = new System.Windows.Forms.TextBox();
            this.yourGitHubPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameToSearch
            // 
            this.usernameToSearch.Location = new System.Drawing.Point(597, 41);
            this.usernameToSearch.Name = "usernameToSearch";
            this.usernameToSearch.Size = new System.Drawing.Size(227, 20);
            this.usernameToSearch.TabIndex = 0;
            this.usernameToSearch.Text = "GitHub Username to Search";
            this.usernameToSearch.ForeColor = Color.Gray;
            this.usernameToSearch.Enter += new System.EventHandler(this.usernameToSearch_Enter);
            this.usernameToSearch.Leave += new System.EventHandler(this.usernameToSearch_Leave);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(856, 39);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // yourGitHubUsername
            // 
            this.yourGitHubUsername.Location = new System.Drawing.Point(60, 42);
            this.yourGitHubUsername.Name = "yourGitHubUsername";
            this.yourGitHubUsername.ForeColor = Color.Gray;
            this.yourGitHubUsername.Size = new System.Drawing.Size(227, 20);
            this.yourGitHubUsername.TabIndex = 2;
            this.yourGitHubUsername.Text = "Your GitHub Username";
            this.yourGitHubUsername.Enter += new System.EventHandler(this.yourGitHubUsername_Enter);
            this.yourGitHubUsername.Leave += new System.EventHandler(this.yourGitHubUsername_Leave);
            // 
            // yourGitHubPassword
            // 
            this.yourGitHubPassword.Location = new System.Drawing.Point(332, 41);
            this.yourGitHubPassword.Name = "yourGitHubPassword";
            this.yourGitHubPassword.Size = new System.Drawing.Size(227, 20);
            this.yourGitHubPassword.TabIndex = 3;
            this.yourGitHubPassword.Text = "Your GitHub Password";
            this.yourGitHubPassword.ForeColor = Color.Gray;
            this.yourGitHubPassword.Enter += new System.EventHandler(this.yourGitHubPassword_Enter);
            this.yourGitHubPassword.Leave += new System.EventHandler(this.yourGitHubPassword_Leave);
            // 
            // GitData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 652);
            this.Controls.Add(this.yourGitHubPassword);
            this.Controls.Add(this.yourGitHubUsername);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.usernameToSearch);
            this.Name = "GitData";
            this.Text = "GitData";
            this.Load += new System.EventHandler(this.GitData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void yourGitHubPassword_Leave(object sender, EventArgs e)
        {
            if (yourGitHubPassword.Text == "")
            {
                yourGitHubPassword.Text = "Your GitHub Password";
                yourGitHubPassword.ForeColor = Color.Gray;
                yourGitHubPassword.PasswordChar = Char.MinValue;
            }
        }

        private void yourGitHubPassword_Enter(object sender, EventArgs e)
        {
            if (yourGitHubPassword.Text == "Your GitHub Password")
            {
                yourGitHubPassword.Text = "";
                yourGitHubPassword.ForeColor = Color.Black;
                yourGitHubPassword.PasswordChar = '*';
            }
        }

        private void yourGitHubUsername_Leave(object sender, EventArgs e)
        {
            if (yourGitHubUsername.Text == "")
            {
                yourGitHubUsername.Text = "Your GitHub Username";
                yourGitHubUsername.ForeColor = Color.Gray;
            }
        }

        private void yourGitHubUsername_Enter(object sender, EventArgs e)
        {
            if (yourGitHubUsername.Text == "Your GitHub Username")
            {
                yourGitHubUsername.Text = "";
                yourGitHubUsername.ForeColor = Color.Black;
            }
        }

        private void usernameToSearch_Leave(object sender, EventArgs e)
        {
            if (usernameToSearch.Text == "")
            {
                usernameToSearch.Text = "GitHub Username to Search";
                usernameToSearch.ForeColor = Color.Gray;
            }
        }

        private void usernameToSearch_Enter(object sender, EventArgs e)
        {
            if (usernameToSearch.Text == "GitHub Username to Search")
            {
                usernameToSearch.Text = "";
                usernameToSearch.ForeColor = Color.Black;
            }
        }


        #endregion

        private System.Windows.Forms.TextBox usernameToSearch;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox yourGitHubUsername;
        private System.Windows.Forms.TextBox yourGitHubPassword;
    }
}

