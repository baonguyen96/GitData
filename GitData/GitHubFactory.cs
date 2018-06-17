using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitData.Storage
{
    class GitHubFactory
    {
        private static GitHubClient _GitHubClient { get; set; }

        public static User CreateUser(string username)
        {
            if(_GitHubClient == null)
            {
                throw new Exception();
            }

            Octokit.User octokitUser = new Octokit.User();
            Task.Run(async () =>
            {
                octokitUser = await _GitHubClient.User.Get(username);
            }).GetAwaiter().GetResult();

            return new User(octokitUser);
        }


        public static RepositoryCollection CreateRepositoryCollection(string username)
        {
            if (_GitHubClient == null)
            {
                throw new Exception();
            }

            IReadOnlyList<Octokit.Repository> octokitRepos = null;
            Task.Run(async () =>
            {
                octokitRepos = await _GitHubClient.Repository.GetAllForUser(username);
            }).GetAwaiter().GetResult();

            return new RepositoryCollection(octokitRepos);
        }


        public static void CreateGitHubClient(string usernameCredential, string passwordCredential)
        {
            _GitHubClient = new GitHubClient(new ProductHeaderValue("GitData"));

            if (usernameCredential != "" && passwordCredential != "")
            {
                _GitHubClient.Credentials = new Credentials(usernameCredential, passwordCredential);
            }
            
        }


    }
}
