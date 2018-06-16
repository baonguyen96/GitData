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

            User user = new User
            {
                Name = octokitUser.Name,
                Followers = octokitUser.Followers,
                Followings = octokitUser.Following,
                CreatedOn = octokitUser.CreatedAt.LocalDateTime,
                UpdatedOn = octokitUser.UpdatedAt.LocalDateTime
            };

            return user;
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
