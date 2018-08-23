
using System.Collections.Generic;
using timetracker.Structs;
using timetracker.Services;

namespace timetracker.Models
{
    public class WorkModel : DBModel<Work>
    {
        public static List<Work> List(User user) => List(new WhereGroup { new WhereCondition("UserId",user.Id) });

        public static List<Work> ListWithBlank(string blank, User user) => ListWithBlank(blank, new WhereGroup { new WhereCondition("UserId",user.Id) });
       
    }
}
