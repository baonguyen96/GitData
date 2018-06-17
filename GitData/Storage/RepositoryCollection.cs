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

        //public override string ToString()
        //{
        //    string[] mostUsedLanguages = GetMostUsedLanguages();
        //    string[] mostRecentActiveRepo = GetMostRecentActiveRepo();
        //    string[] largestRepo = GetLargestRepo();

        //    string s = "";
            
            
        //    s += Utility.FormatKeyValuePair(
        //        "Most Used Languages", Utility.ConvertStringArrayToString(mostUsedLanguages));
        //    s += Utility.FormatKeyValuePair(
        //        "Most Recent Active Repository", $"{mostRecentActiveRepo[0]} on {mostRecentActiveRepo[1]}");
        //    s += Utility.FormatKeyValuePair(
        //        "Largest Repository", $"{largestRepo[0]} with {largestRepo[1]} KB");

        //    return s;
        //}
        

        public string[] GetMostUsedLanguages()
        {
            string[] mostUsedLanguages = (from repository in Repositories
                    where !repository.IsFolked
                    group repository by repository.Language into languageGroups
                    orderby languageGroups.Count() descending
                    select languageGroups.Key).ToArray();
            
            return new string[] { "Most Used Languages", Utility.ConvertStringArrayToString(mostUsedLanguages) };
        }


        public string[] GetMostRecentActiveRepo()
        {
            var mostRecentActiveRepo = (from repository in Repositories
                                        where !repository.IsFolked
                                        orderby repository.UpdatedOn descending
                                        select repository).First();
            
            return new string[] { "Most Recent Active Repository",
                $"{mostRecentActiveRepo.Name} on {mostRecentActiveRepo.UpdatedOn.ToString()}"};
            
        }


        public string[] GetLargestRepo()
        {
            var largestRepo = (from repository in Repositories
                               where !repository.IsFolked
                               orderby repository.Size descending
                               select repository).First();

            return new string[] { "Largest Repository", $"{largestRepo.Name} with {largestRepo.Size} KB"};
        }


    }
}
