using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitData.Storage
{
    class Repository
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
            URL = octokitRepository.Url;
            CreatedOn = octokitRepository.CreatedAt.LocalDateTime;
            UpdatedOn = octokitRepository.UpdatedAt.LocalDateTime;
            Size = octokitRepository.Size;
            ForksCount = octokitRepository.ForksCount;
        }

        //public override string ToString()
        //{
        //    string s = "";

        //    foreach (var property in this.GetType().GetProperties())
        //    {
        //        s += String.Format($"{property.Name.PadRight(30, ' ')}{property.GetValue(this, null).ToString()}\r\n");
        //    }

        //    return s;
        //}

        //public override string ToString()
        //{
        //    int paddingLength = 30;
        //    return
        //        $"{"Name:".PadRight(paddingLength, ' ')}{Name}\r\n" +
        //        $"{"IsFolked:".PadRight(paddingLength, ' ')}{IsFolked}\r\n" +
        //        $"{"Language:".PadRight(paddingLength, ' ')}{Language}\r\n" +
        //        $"{"CreatedOn:".PadRight(paddingLength, ' ')}{CreatedOn}\r\n" +
        //        $"{"UpdatedOn:".PadRight(paddingLength, ' ')}{UpdatedOn}";
        //}

    }
}
