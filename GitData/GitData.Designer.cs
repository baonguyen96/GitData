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
            this.usernameToSearch.Location = new System.Drawing.Point(72, 113);
            this.usernameToSearch.Name = "usernameToSearch";
            this.usernameToSearch.Size = new System.Drawing.Size(538, 20);
            this.usernameToSearch.TabIndex = 0;
            this.usernameToSearch.Text = "GitHub username to search";
            this.usernameToSearch.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(626, 110);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // yourGitHubUsername
            // 
            this.yourGitHubUsername.Location = new System.Drawing.Point(72, 70);
            this.yourGitHubUsername.Name = "yourGitHubUsername";
            this.yourGitHubUsername.Size = new System.Drawing.Size(258, 20);
            this.yourGitHubUsername.TabIndex = 2;
            this.yourGitHubUsername.Text = "Your GitHub username";
            // 
            // yourGitHubPassword
            // 
            this.yourGitHubPassword.Location = new System.Drawing.Point(352, 70);
            this.yourGitHubPassword.Name = "yourGitHubPassword";
            this.yourGitHubPassword.Size = new System.Drawing.Size(258, 20);
            this.yourGitHubPassword.TabIndex = 3;
            this.yourGitHubPassword.Text = "Your GitHub Password";
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

        #endregion

        private System.Windows.Forms.TextBox usernameToSearch;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox yourGitHubUsername;
        private System.Windows.Forms.TextBox yourGitHubPassword;
    }
}

