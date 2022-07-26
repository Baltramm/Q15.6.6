﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Q15._6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var students = classes.SelectMany(s => s.Students).ToArray();
            return students;
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}
