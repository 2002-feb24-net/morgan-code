using System;
using System.Collections.Generic;

namespace StudentApp.Data.Model
{
    public partial class Student
    {
        public Student()
        {
            StudentClass = new HashSet<StudentClass>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<StudentClass> StudentClass { get; set; }
    }
}
