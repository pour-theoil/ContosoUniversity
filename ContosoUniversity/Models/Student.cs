using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        //In entity the Id becomes the key
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //eates a Student instance, the model binder would pick up that Secret form value and use it to create the Student entity instance
        public string Secret { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}