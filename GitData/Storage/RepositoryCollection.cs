using GitData.Utilities;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitData.Storage
{
    class RepositoryCollection
    {
        public List<Repository> Repositories { get; set; }


        public RepositoryCollection(GitHubClient gitHubClient, string username)
        {
            IReadOnlyList<Octokit.Repository> octokitRepos = null;
            Task.Run(async () =>
            {
                octokitRepos = await gitHubClient.Repository.GetAllForUser(username);
            }).GetAwaiter().GetResult();

            if(octokitRepos == null)
            {
                throw new Exception();
            }

            Repositories = new List<Repository>();
            foreach (var octokitRepo in octokitRepos)
            {
                Repository repository = new Repository(gitHubClient, octokitRepo);
                Repositories.Add(repository);
            }
        }


        public override string ToString()
        {
            string s = "";

            foreach(Repository repository in Repositories)
            {
                s += repository.ToString();
                s += "\r\n";
            }

            return s;
        }


        public string[] GetMostUsedLanguages()
        {
            Dictionary<string, long> allLanguageSizes = new Dictionary<string, long>();
            foreach(Repository repository in Repositories)
            {
                foreach(string key in repository.LanguageSize.Keys)
                {
                    if(allLanguageSizes.ContainsKey(key))
                    {
                        allLanguageSizes[key] += repository.LanguageSize[key];
                    }
                    else
                    {
                        allLanguageSizes.Add(key, repository.LanguageSize[key]);
                    }
                }
            }
            
            var sortedLanguageSizes = allLanguageSizes.OrderByDescending(x => x.Value);
            string[] mostUsedLanguages = (from language in sortedLanguageSizes select language.Key).ToArray();

            string[] result = { "Most Used Languages", Utility.ConvertStringArrayToString(mostUsedLanguages) };
            return result;
        }


        public string[] GetMostRecentActiveRepo()
        {
            var mostRecentActiveRepo = (from repository in Repositories
                                        where !repository.IsFolked
                                        orderby repository.UpdatedOn descending
                                        select repository).First();

            string[] result = { "Most Recent Active Repository",
                $"{mostRecentActiveRepo.Name} on {mostRecentActiveRepo.UpdatedOn.ToString()}"};
            return result;
            
        }


        public string[] GetLargestRepo()
        {
            var largestRepo = (from repository in Repositories
                               where !repository.IsFolked
                               orderby repository.Size descending
                               select repository).First();

            string[] result = { "Largest Repository", $"{largestRepo.Name} with {largestRepo.Size} KB" };
            return result;
        }


    }
}
