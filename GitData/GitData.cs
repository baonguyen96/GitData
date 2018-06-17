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
            ClearTables();
            string usernameCredential = YourGitHubUsername.Text.ToString().Trim();
            string passwordCredential = YourGitHubPassword.Text.ToString().Trim();
            string usernameToSearchFor = UsernameToSearch.Text.ToString().Trim();
            
            try
            {
                GitHubFactory.CreateGitHubClient(usernameCredential, passwordCredential);

                User user = GitHubFactory.CreateUser(usernameToSearchFor);
                RepositoryCollection repositoryCollection = GitHubFactory.CreateRepositoryCollection(usernameToSearchFor);

                int rowCount = 0;
                foreach (var property in user.GetType().GetProperties())
                {
                    string[] data = { property.Name, property.GetValue(user, null).ToString() };
                    PopulateTable(UserInfoTable, data, rowCount++);
                }
                
                //UserInfoBox.Text = GitHubFactory.CreateUser(usernameToSearchFor).ToString();
                //RepositoryInfoBox.Text = GitHubFactory.CreateRepositoryCollection(usernameToSearchFor).ToString();
            }
            catch(Exception ex)
            {
                Utilities.Utility.ShowErrorMessage(ex);
            }
        }
        
        private void ClearTables()
        {
            UserInfoTable.RowCount = 0;
            RepositoryInfoTable.RowCount = 0;
        }
        

        private void PopulateTable(TableLayoutPanel table, string[] rowsData, int rowID)
        {
            for (int column = 0; column < rowsData.Length; column++)
            {
                table.Controls.Add(new Label() { Text = rowsData[column] }, column, table.RowCount);
            }
            table.RowCount += 1;
        }
        
    }
}
