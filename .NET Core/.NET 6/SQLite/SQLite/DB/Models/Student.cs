using System;
using System.Collections.Generic;

namespace SQLite.DB.Models
{
    public partial class Student
    {
        public long ID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
