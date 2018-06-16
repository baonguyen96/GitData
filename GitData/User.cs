using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitData.Storage
{
    public class User
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public int Followers { get; set; }
        public int Followings { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        //public RepositoryCollection Repositories { get; set; }

                
        public override string ToString()
        {
            return 
                $"{"Name:".PadRight(30, ' ')}{Name}\r\n" +
                $"{"Followers:".PadRight(30, ' ')}{Followers}\r\n" +
                $"{"Followings:".PadRight(30, ' ')}{Followings}\r\n" +
                $"{"CreatedOn:".PadRight(30, ' ')}{CreatedOn}\r\n" +
                $"{"UpdatedOn:".PadRight(30, ' ')}{UpdatedOn}";
        }

    }
}