using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitData.Storage
{
    class User
    {
        public string Name { get; }
        public int Followers { get; }
        public int Followings { get; }
        public DateTime CreatedOn { get; }
        public DateTime UpdatedOn { get; }

        public User(GitHubClient gitHubClient, string username)
        {
            Octokit.User octokitUser = null;
            Task.Run(async () =>
            {
                octokitUser = await gitHubClient.User.Get(username);
            }).GetAwaiter().GetResult();

            if(octokitUser == null)
            {
                throw new Exception();
            }

            Name = octokitUser.Name;
            Followers = octokitUser.Followers;
            Followings = octokitUser.Following;
            CreatedOn = octokitUser.CreatedAt.LocalDateTime;
            UpdatedOn = octokitUser.UpdatedAt.LocalDateTime;
        }
        
    }
}