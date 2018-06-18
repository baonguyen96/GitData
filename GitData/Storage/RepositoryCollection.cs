using GitData.Utilities;
using System.Collections.Generic;
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
            string[] mostUsedLanguages = (from repository in Repositories
                    where !repository.IsFolked
                    group repository by repository.Language into languageGroups
                    orderby languageGroups.Count() descending
                    select languageGroups.Key).ToArray();
            
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
