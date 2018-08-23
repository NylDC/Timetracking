using timetracker.Structs;
using System.Collections.Generic;
using timetracker.Services;

namespace timetracker.Models
{
    public class ProcessesAndUrlsModel : DBModel<ProcessesAndUrls>
    {
        public static List<ProcessesAndUrls> List(bool isUrl) => List(new WhereGroup { new WhereCondition("isUrl", isUrl) });
        public static List<ProcessesAndUrls> List(bool isUrl, bool isAllowed) => List(new WhereGroup { new WhereCondition("isUrl", isUrl), new WhereCondition("isAllowed", isAllowed) });
    }
}
