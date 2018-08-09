using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timetracker.Structs;

namespace timetracker.Services
{
    class Auth
    {
        public static User CurrentUser { get; set; } = null;
    }
}
