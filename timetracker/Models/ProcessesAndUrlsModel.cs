using timetracker.Structs;
using System.Collections.Generic;
using timetracker.Structs;
using timetracker.Services;

namespace timetracker.Models
{
    class ProcessesAndUrlsModel : DBModel<ProcessesAndUrls>
    {
        public static List<ProcessesAndUrls> List(bool isUrl) => List(new WhereGroup { new WhereCondition("isUrl", isUrl) });

       // public static List<ProcessesAndUrls> ListProcesses(ProcessesAndUrls isUrl) => List(new WhereGroup { new WhereCondition("isUrl", false) });

    }
}
