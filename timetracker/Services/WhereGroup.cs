using System;
using System.Collections.Generic;

namespace timetracker.Services
{
    /// <summary>
    /// represents a group of WHERE SQL conditions to be later combined through AND/OR condition 
    /// </summary>
    class WhereGroup : List<WhereCondition>
    {
        public bool IsOR = false;

        public WhereGroup(bool isOr)
        {
            IsOR = isOr;
        }

        public WhereGroup() { }
        /// <summary>
        /// Build a string of conditions
        /// </summary>
        /// <returns></returns>
        public string Build()
        {
            string result = "";
            ForEach((WhereCondition item) => {
                string condCompiled = item.Build();
                if (condCompiled == "") return;
                if (result != "") result += IsOR ? " OR " : " AND ";
                result += condCompiled;
            });
            return "(" + result + ")";
        }
    }
}
