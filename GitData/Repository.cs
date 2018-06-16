using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitData.Storage
{
    class Repository
    {
        public string Name { get; set; }
        public bool IsFolked { get; set; }
        public string Language { get; set; }
        public string URL { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int Size { get; set; }
        public int ForkCount { get; set; }

    }
}
