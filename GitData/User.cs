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
                $"Name:       {Name}\n" +
                $"Followers:  {Followers}\n" +
                $"Followings: {Followings}\n" +
                $"Created On: {CreatedOn}\n" +
                $"Updated On: {UpdatedOn}\n";
        }

    }
}