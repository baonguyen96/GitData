using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitData.Storage
{
    abstract class Entity
    {
        public override string ToString()
        {
            string s = "";

            foreach (var property in GetType().GetProperties())
            {
                s += Utilities.Utilities.FormatKeyValuePair(
                    property.Name, property.GetValue(this, null).ToString());
            }

            return s;
        }
    }
}
