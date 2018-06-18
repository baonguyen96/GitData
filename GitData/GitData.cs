using GitData.Storage;
using GitData.Utilities;
using System;
using System.Linq;
using System.Reflection;
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
            if(UsernameToSearch.Text.ToString() == Prompts.UsernameToSearchPrompt)
            {
                Utility.ShowErrorMessage("Please enter a GitHub account to search.");
                return;
            }

            ClearTables();
            string usernameCredential = YourGitHubUsername.Text.ToString().Trim();
            string passwordCredential = YourGitHubPassword.Text.ToString().Trim();
            string usernameToSearchFor = UsernameToSearch.Text.ToString().Trim();

            try
            {
                GitHubFactory.CreateGitHubClient(usernameCredential, passwordCredential);

                User user = GitHubFactory.CreateUser(usernameToSearchFor);
                RepositoryCollection repositoryCollection = GitHubFactory.CreateRepositoryCollection(usernameToSearchFor);

                // user info
                foreach (var property in user.GetType().GetProperties())
                {
                    string[] data = { property.Name, property.GetValue(user, null).ToString() };
                    PopulateTable(UserInfoTable, data);
                }

                Console.WriteLine(repositoryCollection.ToString());

                // repositories info
                PopulateTable(RepositoryInfoTable, repositoryCollection.GetMostUsedLanguages());
                PopulateTable(RepositoryInfoTable, repositoryCollection.GetLargestRepo());
                PopulateTable(RepositoryInfoTable, repositoryCollection.GetMostRecentActiveRepo());

            }
            catch (Exception ex)
            {
                if (ex is Octokit.RateLimitExceededException)
                {
                    Utility.ShowErrorMessage("Already hit access rate limit of GitHub API. " +
                        "Please consider login with your GitHub credentials to continue, or come back later.");
                }
                else
                {
                    Utility.ShowErrorMessage(ex.ToString());
                }
            }
        }
        
        
        private void ClearTables()
        {
            UserInfoTable.Controls.Clear();
            UserInfoTable.RowCount = 0;

            RepositoryInfoTable.Controls.Clear();
            RepositoryInfoTable.RowCount = 0;
        }
        

        private void PopulateTable(TableLayoutPanel table, string[] rowsData)
        {
            for (int column = 0; column < rowsData.Length; column++)
            {
                Control control = new Label() { Text = rowsData[column] };

                //control.Dock = DockStyle.Fill;

                //if (table.RowCount % 2 == 0)
                //{
                //    control.BackColor = System.Drawing.Color.LightGray;
                //}

                table.Controls.Add(control, column, table.RowCount);
            }
            

            table.RowCount += 1;
        }
        
    }
}
