using System;
using System.Collections.Generic;

namespace EFCore.Models
{
    public partial class EmpUtilization
    {
        public int ID { get; set; }
        public int? EmpID { get; set; }
        public DateTime? LoggedIN { get; set; }
        public DateTime? LoggedOut { get; set; }
        public int? StaffedDuration { get; set; }
        public int? Production { get; set; }
        public int? Quality { get; set; }
        public int? Snacks { get; set; }
        public int? Meals { get; set; }
        public int? Meeting { get; set; }
        public int? Training { get; set; }
        public int? Clarification { get; set; }
        public int? Downtime { get; set; }
        public int? Report { get; set; }
        public int? Active { get; set; }
        public int? Idle { get; set; }
        public int? CurrentDuration { get; set; }
        public string CurrentTask { get; set; }
        public string ActiveWindow { get; set; }
        public DateTime? LoggedDate { get; set; }
        public int? Healthissue { get; set; }
        public int? Target { get; set; }
        public string SecondStatus { get; set; }
        public string Version { get; set; }
        public string SubTeam { get; set; }
        public string Timesheet { get; set; }
        public string Attendance { get; set; }
        public string LeaveCreated { get; set; }
        public DateTime? Leavedate { get; set; }

        public virtual EmpUserInfo Emp { get; set; }
    }
}
