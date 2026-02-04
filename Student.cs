using System;
using System.Collections.Generic;
using System.Text;

namespace _4_2_LMS_login
{
    internal class Student : IComparable<Student>, IComparer<Student>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float GPA { get; set; }

        public int CompareGPA(Student? x, Student? y)
        {
            return x.GPA.CompareTo(y.GPA);
        }
        public int  CompareId(Student? x, Student? y)
        {
            return x.Id.CompareTo(y.Id);
        }

        public int CompareLastName(Student? x, Student? y)
        {
            return x.LastName.CompareTo(y.LastName);
        }
        public int CompareFirstName(Student? x, Student? y)
        {
            return x.FirstName.CompareTo(y.FirstName);
        }

        // Default sort: by LastName, then FirstName
        public int CompareTo(Student? other)
        {
            if (other == null) return 1;

            int last = string.Compare(this.LastName, other.LastName, StringComparison.OrdinalIgnoreCase);
            if (last != 0) return last;

            return string.Compare(this.FirstName, other.FirstName, StringComparison.OrdinalIgnoreCase);
        }


        public int Compare(Student? x, Student? y)
        {
            return x.Id.CompareTo(y.Id);
        }



        //public int CompareTo(Student? other)
        //{
        //    int val = String.Compare(this.Name, other.Name, StringComparison.OrdinalIgnoreCase);
        //    return val;
        //}


    }
}
