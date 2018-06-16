using Octokit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitData.Storage;

namespace GitData
{
    public partial class GitData : Form
    {
        public GitData()
        {
            InitializeComponent();
        }

        private void GitData_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string usernameCredential = yourGitHubUsername.Text.ToString().Trim();
            string passwordCredential = yourGitHubPassword.Text.ToString().Trim();
            string usernameToSearchFor = usernameToSearch.Text.ToString().Trim();
            
            try
            {
                GitHubFactory.CreateOctokitUser(usernameCredential, passwordCredential, usernameToSearchFor);
                MessageBox.Show(GitHubFactory.CreateUser().ToString());
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
