using GitData.Utilities;
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
        
        public static GitHubClient CreateGitHubClient(string usernameCredential, string passwordCredential)
        {
            GitHubClient githubClient = new GitHubClient(new ProductHeaderValue("GitData"));

            if (usernameCredential != Prompts.UsernameCredentialPrompt && passwordCredential != Prompts.PasswordCredentialPrompt)
            {
                githubClient.Credentials = new Credentials(usernameCredential, passwordCredential);
            }

            return githubClient;
        }


    }
}
