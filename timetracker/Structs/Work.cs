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

        private Project _Project = null;
        public Project Project
        {
            get { return _Project ?? (_Project = ProjectModel.Find(ProjectId)); }
            set { ProjectId = (_Project = value) == null ? 0 : value.Id; }
        }

        private WorkType _WorkType = null;
        public WorkType WorkType
        {
            get { return _WorkType ?? (_WorkType = WorkTypeModel.Find(WorkTypeId)); }
            set { WorkTypeId = (_WorkType = value) == null ? 0 : value.Id; }
        }

        private User _User = null;
        public User User {
            get { return _User ?? (_User = UserModel.Find(UserId)); }
            set { UserId = (_User = value) == null ? 0 : value.Id; }
        }

        public string Comment { get; set; } = "";

        public string VisibleTitle {
            get
            {
                string projectName = ProjectId != 0 ? Project.Name : "---";
                string workTypeName = WorkTypeId != 0 ? WorkType.Name : "---";
                return Id == 0 ? Comment : "[" + projectName + "/" + workTypeName + "] " + Comment + " (" + TimeFormatted + ")";
            }
        }

        public Work() { }

        public Work(int projectId, int userId, int workTypeId, string comment, int time)
        {
            ProjectId = projectId;
            UserId = userId;
            WorkTypeId = workTypeId;
            Comment = comment;
            _time = time;
        }

        public Work(int projectId, int userId, int workTypeId, string comment)
        {
            ProjectId = projectId;
            UserId = userId;
            WorkTypeId = workTypeId;
            Comment = comment;
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

        public string TimeFormatted => Services.Timer.FormatTime(Time);

        protected override void OnApply(DataRow row)
        {
            Comment = row["Comment"].ToString();
            WorkTypeId = Int32.Parse(row["WorkTypeId"].ToString());
            ProjectId = Int32.Parse(row["ProjectId"].ToString());
            UserId = Int32.Parse(row["UserId"].ToString());
            _time = Int32.Parse(row["Time"].ToString());
        }

        protected override void OnSave(Dictionary<string, object> dict)
        {
            dict["Comment"] = Comment;
            dict["WorkTypeId"] = WorkTypeId;
            dict["ProjectId"] = ProjectId;
            dict["UserId"] = UserId;
            dict["Time"] = Time;
        }
        public override void SetName(string name)
        {
            Comment = name;
        }
    }
}
