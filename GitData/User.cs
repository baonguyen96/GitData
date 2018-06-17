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
        public string UserName { get; }
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


        //public override string ToString()
        //{
        //    string s = "";

        //    foreach (var property in this.GetType().GetProperties())
        //    {
        //        s += String.Format($"{property.Name.PadRight(30, ' ')}{property.GetValue(this, null).ToString()}\r\n");
        //    }

        //    return s;
        //}


        public override string ToString()
        {
            int paddingLength = 40;
            return
                $"{"Name".PadRight(paddingLength, ' ')}{Name}\r\n" +
                $"{"Followers".PadRight(paddingLength, ' ')}{Followers}\r\n" +
                $"{"Followings".PadRight(paddingLength, ' ')}{Followings}\r\n" +
                $"{"CreatedOn".PadRight(paddingLength, ' ')}{CreatedOn}\r\n" +
                $"{"UpdatedOn".PadRight(paddingLength, ' ')}{UpdatedOn}";
        }

    }
}