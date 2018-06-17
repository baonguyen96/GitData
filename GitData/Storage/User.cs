using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitData.Storage
{
    class User : Entity
    {
        public string Name { get; }
        public int Followers { get; }
        public int Followings { get; }
        public DateTime CreatedOn { get; }
        public DateTime UpdatedOn { get; }

        public User(Octokit.User octokitUser)
        {
            Name = octokitUser.Name;
            Followers = octokitUser.Followers;
            Followings = octokitUser.Following;
            CreatedOn = octokitUser.CreatedAt.LocalDateTime;
            UpdatedOn = octokitUser.UpdatedAt.LocalDateTime;
        }
        
    }
}