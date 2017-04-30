using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scouting
{
    static class Functions
    {
        static public void CreateAddColumns(Dictionary<Type, string> categories, DataTable table)
        {
            foreach(KeyValuePair<Type, string> category in categories)
            {
                table.Columns.Add(category.Value, category.Key);
            }
        }
    }
}
