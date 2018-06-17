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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GitData));
            this.UsernameToSearch = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.YourGitHubUsername = new System.Windows.Forms.TextBox();
            this.YourGitHubPassword = new System.Windows.Forms.TextBox();
            this.ResultPane = new System.Windows.Forms.TabControl();
            this.UserInfoPage = new System.Windows.Forms.TabPage();
            this.UserInfoBox = new System.Windows.Forms.TextBox();
            this.RepositoryInfoPage = new System.Windows.Forms.TabPage();
            this.RepositoryInfoBox = new System.Windows.Forms.TextBox();
            this.ResultPane.SuspendLayout();
            this.UserInfoPage.SuspendLayout();
            this.RepositoryInfoPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsernameToSearch
            // 
            this.UsernameToSearch.ForeColor = System.Drawing.Color.Gray;
            this.UsernameToSearch.Location = new System.Drawing.Point(580, 42);
            this.UsernameToSearch.Name = "UsernameToSearch";
            this.UsernameToSearch.Size = new System.Drawing.Size(227, 20);
            this.YourGitHubUsername.TabIndex = 4;
            this.UsernameToSearch.Text = "GitHub Username to Search";
            this.UsernameToSearch.Enter += new System.EventHandler(this.usernameToSearch_Enter);
            this.UsernameToSearch.Leave += new System.EventHandler(this.usernameToSearch_Leave);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(834, 42);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // YourGitHubUsername
            // 
            this.YourGitHubUsername.ForeColor = System.Drawing.Color.Gray;
            this.YourGitHubUsername.Location = new System.Drawing.Point(60, 42);
            this.YourGitHubUsername.Name = "YourGitHubUsername";
            this.YourGitHubUsername.Size = new System.Drawing.Size(227, 20);
            this.YourGitHubUsername.TabIndex = 2;
            this.YourGitHubUsername.Text = "Your GitHub Username";
            this.YourGitHubUsername.Enter += new System.EventHandler(this.yourGitHubUsername_Enter);
            this.YourGitHubUsername.Leave += new System.EventHandler(this.yourGitHubUsername_Leave);
            // 
            // YourGitHubPassword
            // 
            this.YourGitHubPassword.ForeColor = System.Drawing.Color.Gray;
            this.YourGitHubPassword.Location = new System.Drawing.Point(319, 41);
            this.YourGitHubPassword.Name = "YourGitHubPassword";
            this.YourGitHubPassword.Size = new System.Drawing.Size(227, 20);
            this.YourGitHubPassword.TabIndex = 3;
            this.YourGitHubPassword.Text = "Your GitHub Password";
            this.YourGitHubPassword.Enter += new System.EventHandler(this.yourGitHubPassword_Enter);
            this.YourGitHubPassword.Leave += new System.EventHandler(this.yourGitHubPassword_Leave);
            // 
            // ResultPane
            // 
            this.ResultPane.Controls.Add(this.UserInfoPage);
            this.ResultPane.Controls.Add(this.RepositoryInfoPage);
            this.ResultPane.Location = new System.Drawing.Point(60, 110);
            this.ResultPane.Name = "ResultPane";
            //this.ResultPane.SelectedIndex = 0;
            this.ResultPane.Size = new System.Drawing.Size(853, 498);
            //this.ResultPane.TabIndex = 0;
            // 
            // UserInfoPage
            // 
            this.UserInfoPage.Controls.Add(this.UserInfoBox);
            this.UserInfoPage.Location = new System.Drawing.Point(4, 22);
            this.UserInfoPage.Name = "UserInfoPage";
            this.UserInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserInfoPage.Size = new System.Drawing.Size(845, 472);
            this.UserInfoPage.TabIndex = 0;
            this.UserInfoPage.Text = "User Info";
            this.UserInfoPage.UseVisualStyleBackColor = true;
            // 
            // UserInfoBox
            // 
            this.UserInfoBox.BackColor = System.Drawing.Color.White;
            this.UserInfoBox.Location = new System.Drawing.Point(7, 7);
            this.UserInfoBox.Multiline = true;
            this.UserInfoBox.Name = "UserInfoBox";
            this.UserInfoBox.ReadOnly = true;
            this.UserInfoBox.Size = new System.Drawing.Size(832, 459);
            this.UserInfoBox.TabIndex = 0;
            // 
            // RepositoryInfoPage
            // 
            this.RepositoryInfoPage.Controls.Add(this.RepositoryInfoBox);
            this.RepositoryInfoPage.Location = new System.Drawing.Point(4, 22);
            this.RepositoryInfoPage.Name = "RepositoryInfoPage";
            this.RepositoryInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.RepositoryInfoPage.Size = new System.Drawing.Size(845, 472);
            this.RepositoryInfoPage.TabIndex = 1;
            this.RepositoryInfoPage.Text = "Repository Info";
            this.RepositoryInfoPage.UseVisualStyleBackColor = true;
            // 
            // RepositoryInfoBox
            // 
            this.RepositoryInfoBox.BackColor = System.Drawing.Color.White;
            this.RepositoryInfoBox.Location = new System.Drawing.Point(6, 7);
            this.RepositoryInfoBox.Multiline = true;
            this.RepositoryInfoBox.Name = "RepositoryInfoBox";
            this.RepositoryInfoBox.ReadOnly = true;
            this.RepositoryInfoBox.Size = new System.Drawing.Size(832, 459);
            this.RepositoryInfoBox.TabIndex = 1;
            // 
            // GitData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 652);
            this.Controls.Add(this.ResultPane);
            this.Controls.Add(this.YourGitHubPassword);
            this.Controls.Add(this.YourGitHubUsername);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.UsernameToSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GitData";
            this.Text = "GitData";
            this.Load += new System.EventHandler(this.GitData_Load);
            this.ResultPane.ResumeLayout(false);
            this.UserInfoPage.ResumeLayout(false);
            this.UserInfoPage.PerformLayout();
            this.RepositoryInfoPage.ResumeLayout(false);
            this.RepositoryInfoPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void yourGitHubPassword_Leave(object sender, EventArgs e)
        {
            if (YourGitHubPassword.Text == "")
            {
                YourGitHubPassword.Text = "Your GitHub Password";
                YourGitHubPassword.ForeColor = Color.Gray;
                YourGitHubPassword.PasswordChar = Char.MinValue;
            }
        }

        private void yourGitHubPassword_Enter(object sender, EventArgs e)
        {
            if (YourGitHubPassword.Text == "Your GitHub Password")
            {
                YourGitHubPassword.Text = "";
                YourGitHubPassword.ForeColor = Color.Black;
                YourGitHubPassword.PasswordChar = '*';
            }
        }

        private void yourGitHubUsername_Leave(object sender, EventArgs e)
        {
            if (YourGitHubUsername.Text == "")
            {
                YourGitHubUsername.Text = "Your GitHub Username";
                YourGitHubUsername.ForeColor = Color.Gray;
            }
        }

        private void yourGitHubUsername_Enter(object sender, EventArgs e)
        {
            if (YourGitHubUsername.Text == "Your GitHub Username")
            {
                YourGitHubUsername.Text = "";
                YourGitHubUsername.ForeColor = Color.Black;
            }
        }

        private void usernameToSearch_Leave(object sender, EventArgs e)
        {
            if (UsernameToSearch.Text == "")
            {
                UsernameToSearch.Text = "GitHub Username to Search";
                UsernameToSearch.ForeColor = Color.Gray;
            }
        }

        private void usernameToSearch_Enter(object sender, EventArgs e)
        {
            if (UsernameToSearch.Text == "GitHub Username to Search")
            {
                UsernameToSearch.Text = "";
                UsernameToSearch.ForeColor = Color.Black;
            }
        }


        #endregion

        private System.Windows.Forms.TextBox UsernameToSearch;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox YourGitHubUsername;
        private System.Windows.Forms.TextBox YourGitHubPassword;
        private System.Windows.Forms.TabControl ResultPane;
        private System.Windows.Forms.TabPage UserInfoPage;
        private System.Windows.Forms.TabPage RepositoryInfoPage;
        private System.Windows.Forms.TextBox UserInfoBox;
        private System.Windows.Forms.TextBox RepositoryInfoBox;
    }
}

