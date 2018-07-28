using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timetracker.Structs
{
    class Work
    {
        public int Id = 1;
        public Project Project;
        public WorkType WorkType;
        public string Comments = "";

        int _time = 0;
        public int Time {
            get {
                return _time;
            }
            set
            {
                // Todo save data to DB.
                _time = value;
            }
        }
    }
}
