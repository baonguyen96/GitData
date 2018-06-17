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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string usernameCredential = YourGitHubUsername.Text.ToString().Trim();
            string passwordCredential = YourGitHubPassword.Text.ToString().Trim();
            string usernameToSearchFor = UsernameToSearch.Text.ToString().Trim();
            
            try
            {
                GitHubFactory.CreateGitHubClient(usernameCredential, passwordCredential);
                UserInfoBox.Text = GitHubFactory.CreateUser(usernameToSearchFor).ToString();
                RepositoryInfoBox.Text = GitHubFactory.CreateRepositoryCollection(usernameToSearchFor).ToString();
            }
            catch(Exception ex)
            {
                Utilities.Utilities.ShowErrorMessage(ex);
            }
        }
        
    }
}
