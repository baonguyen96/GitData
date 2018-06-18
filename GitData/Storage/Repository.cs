using GitData.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitData.Storage
{
    class Repository : Entity
    {
        public string Name { get; }
        public bool IsFolked { get; }
        public string Language { get; }
        public string URL { get; }
        public DateTime CreatedOn { get; }
        public DateTime UpdatedOn { get; }
        public long Size { get; }
        public int ForksCount { get; }


        public Repository(Octokit.Repository octokitRepository)
        {
            Name = octokitRepository.Name;
            IsFolked = octokitRepository.Fork;
            Language = octokitRepository.Language;
            URL = octokitRepository.HtmlUrl;
            CreatedOn = octokitRepository.CreatedAt.LocalDateTime;
            UpdatedOn = octokitRepository.UpdatedAt.LocalDateTime;
            Size = octokitRepository.Size;
            ForksCount = octokitRepository.ForksCount;
        }
        
    }
}
