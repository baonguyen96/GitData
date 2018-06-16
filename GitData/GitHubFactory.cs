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
        private static Octokit.User OctokitUser { get; set; }


        public static User CreateUser()
        {
            if(OctokitUser == null)
            {
                throw new Exception();
            }

            User user = new User
            {
                Name = OctokitUser.Name,
                Followers = OctokitUser.Followers,
                Followings = OctokitUser.Following,
                CreatedOn = OctokitUser.CreatedAt.LocalDateTime,
                UpdatedOn = OctokitUser.UpdatedAt.LocalDateTime
            };

            return user;
        }

        public static void CreateOctokitUser(string usernameCredential, string passwordCredential, string usernameToSearchFor)
        {
            var githubClient = new GitHubClient(new ProductHeaderValue("GitData"));

            if (usernameCredential != "" && passwordCredential != "")
            {
                githubClient.Credentials = new Credentials(usernameCredential, passwordCredential);
            }

            Task.Run(async () =>
            {
                OctokitUser = await githubClient.User.Get(usernameToSearchFor);
            }).GetAwaiter().GetResult();
        }


    }
}
