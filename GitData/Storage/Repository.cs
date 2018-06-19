using GitData.Utilities;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitData.Storage
{
    class Repository
    {
        public string Name { get; private set; }
        public bool IsFolked { get; private set; }
        public string URL { get; private set; }
        public DateTime CreatedOn { get; private set; }
        public DateTime UpdatedOn { get; private set; }
        public long Size { get; private set; }
        public int ForksCount { get; private set; }
        public Dictionary<string, long> LanguageSize { get; private set; }


        public Repository(GitHubClient githubClient, Octokit.Repository octokitRepository)
        {
            Name = octokitRepository.Name;
            IsFolked = octokitRepository.Fork;
            URL = octokitRepository.HtmlUrl;
            CreatedOn = octokitRepository.CreatedAt.LocalDateTime;
            UpdatedOn = octokitRepository.UpdatedAt.LocalDateTime;
            Size = octokitRepository.Size;
            ForksCount = octokitRepository.ForksCount;
            SetLanguageSize(githubClient, octokitRepository);
        }
        

        private void SetLanguageSize(GitHubClient githubClient, Octokit.Repository octokitRepository)
        {
            IReadOnlyList<Octokit.RepositoryLanguage> languages = null;
            Task.Run(async () =>
            {
                languages = await githubClient.Repository.GetAllLanguages(octokitRepository.Owner.Login, Name);
            }).GetAwaiter().GetResult();

            LanguageSize = new Dictionary<string, long>();
            foreach (var lang in languages)
            {
                LanguageSize.Add(lang.Name, lang.NumberOfBytes);
            }
        }

        
    }
}
