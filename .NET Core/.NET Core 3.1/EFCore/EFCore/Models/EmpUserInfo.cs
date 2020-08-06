using System;
using System.Collections.Generic;

namespace EFCore.Models
{
    public partial class EmpUserInfo
    {
        public EmpUserInfo()
        {                  
            EmpUtilization = new HashSet<EmpUtilization>();              
        }

        public int ID { get; set; }
        public int EmpID { get; set; }
        public string EmpLogin { get; set; }
        public string EmpName { get; set; }
        public string TeamName { get; set; }
        public string Designation { get; set; }
        public string Process { get; set; }
        public string SubProcess { get; set; }
        public string SupervisorName { get; set; }
        public int? SupervisorID { get; set; }
        public string AccessType { get; set; }
        public string Location { get; set; }
        public string ReportAccess { get; set; }
        public int? Createdby { get; set; }
        public string Reason { get; set; }
        public bool? Isactive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }


        public virtual ICollection<EmpUtilization> EmpUtilization { get; set; }
    }
}
