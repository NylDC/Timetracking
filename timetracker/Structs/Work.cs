using System;
using System.Collections.Generic;
using System.Data;
using timetracker.Models;

namespace timetracker.Structs
{
    class Work : ModelType
    {
        public override string Table() => "Works";
        public override string PK() => "Id";

        public int ProjectId = 0;
        public int UserId = 0;
        public int WorkTypeId = 0;

        public Project Project => ProjectModel.Find(ProjectId);
        public WorkType WorkType => WorkTypeModel.Find(WorkTypeId);
        public User User => UserModel.Find(UserId);

        public string Comments = "";

        public Work() { }

        public Work(int projectId, int userId, int workTypeId, string comments, int time)
        {
            ProjectId = projectId;
            UserId = userId;
            WorkTypeId = workTypeId;
            Comments = comments;
            _time = time;
        }

        int _time = 0;
        public int Time {
            get {
                return _time;
            }
            set
            {
                // Todo save data to DB.
                _time = value;
                Save();
            }
        }

        protected override void OnApply(DataRow row)
        {
            Comments = row["Comments"].ToString();
            WorkTypeId = Int32.Parse(row["WorkTypeId"].ToString());
            ProjectId = Int32.Parse(row["ProjectId"].ToString());
            UserId = Int32.Parse(row["UserId"].ToString());
            _time = Int32.Parse(row["Time"].ToString());
        }

        protected override void OnSave(Dictionary<string, object> dict)
        {
            dict["Comments"] = Comments;
            dict["WorkTypeId"] = WorkTypeId;
            dict["ProjectId"] = ProjectId;
            dict["UserId"] = UserId;
            dict["Time"] = Time;
        }
    }
}
