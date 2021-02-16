﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {

        private List<Student> students;

        public Classroom(int capacity)
        {
            Capacity = capacity;

            students = new List<Student>();
        }

        public int Capacity { get; set; }

        public int Count { get { return students.Count; } }

        public string RegisterStudent(Student student)
        {
            if (students.Count < Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }

            return "No seats in the classroom";
        }
            
        public string DismissStudent(string firstName, string lastName)
        {
            Student student = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

            if (student != null)
            {
                students.Remove(student);
                return $"Dismissed student {firstName} {lastName}" ;
            }

            return "Student not found";
        }

        public string GetSubjectInfo(string subject)
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"Subject: {subject}");
            output.AppendLine($"Students:");

            bool haveStudents = false;
            foreach (var student in students)
            {
                if (student.Subject.ToLower() == subject.ToLower())
                {
                    output.AppendLine($"{student.FirstName} {student.LastName}");
                    haveStudents = true;
                }
            }

            if (haveStudents)
            {
                return output.ToString().Trim();
            }

            return "No students enrolled for the subject";
        }

        public int GetStudentsCount()
        {
            return Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            Student student = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

            return student;
        }
    }
}
