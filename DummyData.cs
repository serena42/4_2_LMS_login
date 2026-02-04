using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _4_2_LMS_login
{
    internal static class DummyStudentData
    {
        private static readonly List<string> FirstNames = new List<string>
        {
            "Ava","Benjamin","Charlotte","Daniel","Elena","Felix","Grace","Henry","Isla","Jacob",
            "Kara","Liam","Maya","Noah","Olivia","Parker","Quinn","Riley","Sophia","Theo",
            "Uma","Violet","Wyatt","Xavier","Yara","Zane"
        };

        private static readonly List<string> LastNames = new List<string>
        {
            "Anderson","Bennett","Carter","Diaz","Edwards","Foster","Garcia","Hughes","Iverson","Johnson",
            "Kim","Lopez","Mitchell","Nguyen","Owens","Patel","Quintero","Reed","Sullivan","Turner",
            "Underwood","Vasquez","Walker","Xiong","Young","Zimmerman"
        };

        private static readonly Random Rand = new Random();

        public static BindingList<Student> GenerateStudents(int count)
        {
            var list = new BindingList<Student>();

            for (int i = 0; i < count; i++)
            {
                string first = FirstNames[Rand.Next(FirstNames.Count)];
                string last = LastNames[Rand.Next(LastNames.Count)];

                list.Add(new Student
                {
                    Id = i + 1,
                    FirstName = first,
                    LastName = last,
                    GPA = (float)Math.Round(2.0 + Rand.NextDouble() * 2.0, 2), 

                });
            }

            return list;
        }
    }
}