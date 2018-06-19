using GitData.Utilities;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitData.Storage
{
    [Obsolete]
    abstract class Entity
    {
        protected GitHubClient _GitHubClient;

        public Entity(GitHubClient githubClient)
        {
            _GitHubClient = githubClient;
        }

        public override string ToString()
        {
            string str = "";
            string propertyName = "";
            string propertyValue = "";

            foreach (var property in this.GetType().GetProperties())
            {
                propertyName = property.Name;

                if (property.GetValue(this, null) == null)
                {
                    propertyValue = "Unknown";
                }
                else
                {
                    propertyValue = property.GetValue(this, null).ToString();
                }

                str += Utility.FormatKeyValuePair(propertyName, propertyValue);
            }

            return str;
        }
    }
}
