using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;
using System.Linq;

namespace GitData.Storage
{
    class RepositoryCollection
    {
        public List<Repository> Repositories { get; set; }


        public RepositoryCollection(IReadOnlyList<Octokit.Repository> octokitRepos)
        {
            Repositories = new List<Repository>();

            foreach (var octokitRepo in octokitRepos)
            {
                Repository repository = new Repository(octokitRepo);
                Repositories.Add(repository);
            }
        }

        public override string ToString()
        {
            string[] mostUsedLanguages = GetMostUsedLanguages();
            string[] mostRecentActiveRepo = GetMostRecentActiveRepo();
            string[] largestRepo = GetLargestRepo();
            
            string s = "";

            s += Utilities.Utilities.FormatKeyValuePair(
                "Most Used Languages", Utilities.Utilities.ConvertStringArrayToString(mostUsedLanguages));
            s += Utilities.Utilities.FormatKeyValuePair(
                "Most Recent Active Repository", $"{mostRecentActiveRepo[0]} on {mostRecentActiveRepo[1]}");
            s += Utilities.Utilities.FormatKeyValuePair(
                "Largest Repository", $"{largestRepo[0]} with {largestRepo[1]} KB");

            return s;
        }

        /*
         * public string Name { get; }
        public bool IsFolked { get; }
        public string Language { get; }
        public string URL { get; }
        public DateTime CreatedOn { get; }
        public DateTime UpdatedOn { get; }
        public long Size { get; }
        public int ForksCount { get; }
         *
         */


        private string[] GetMostUsedLanguages()
        {
            return (from repository in Repositories
                    where !repository.IsFolked
                    group repository by repository.Language into languageGroups
                    orderby languageGroups.Count() descending
                    select languageGroups.Key).ToArray();
        }


        private string[] GetMostRecentActiveRepo()
        {
            var mostRecentActiveRepo = (from repository in Repositories
                                        where !repository.IsFolked
                                        orderby repository.UpdatedOn descending
                                        select repository).First();
            return new string[] { mostRecentActiveRepo.Name, mostRecentActiveRepo.UpdatedOn.ToString() };
        }


        private string[] GetLargestRepo()
        {
            var largestRepo = (from repository in Repositories
                               where !repository.IsFolked
                               orderby repository.Size descending
                               select repository).First();
            return new string[] { largestRepo.Name, largestRepo.Size.ToString() };
        }


    }
}
