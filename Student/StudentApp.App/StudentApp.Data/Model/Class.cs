using System;
using System.Collections.Generic;

namespace StudentApp.Data.Model
{
    public partial class Class
    {
        public Class()
        {
            StudentClass = new HashSet<StudentClass>();
        }

        public int Id { get; set; }
        public string CourseNumber { get; set; }

        public virtual ICollection<StudentClass> StudentClass { get; set; }
    }
}
