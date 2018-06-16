using GitData.Storage;
using System;
using System.Windows.Forms;

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
        
    }
}
