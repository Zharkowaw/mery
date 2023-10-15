using System;
using System.Collections.Generic;
using System.Text;

namespace GradesApp
{
    public class StudentInMemory : StudentBase
    {
        private List<double> grades;
        private string firstName;
        private string lastName;

        public override string FirstName
        {
            get
            {
                return $"{char.ToUpper(firstName[0])}{firstName.Substring(1, firstName.Length - 1).ToLower()}";
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    firstName = value;
                }
            }
        }

        public override string LastName
        {
            get
            {
                return $"{char.ToUpper(lastName[0])}.";
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    lastName = value;
                }
            }
        }

        public StudentInMemory(string firstName, string lastName) : base(firstName, lastName)
        {
            grades = new List<double>();
        }

        public void ChangeStudentName(string newName)
        {
            string oldName = this.FirstName;
            foreach (char c in newName)
            {
                if (char.IsDigit(c))
                {
                    this.FirstName = oldName;
                    break;
                }
                else
                {
                    this.FirstName = newName;
                }
            }
        }

        public override void AddGrade(double grade)
        {
            if (grade > 0 && grade <= 6)
            {
                grades.Add(grade);
                if (grade < 3)
                {
                    CheckEventGradeUnder3();
                }
            }
            else
            {
                throw new ArgumentException($"Invalid argument: {nameof(grade)}. Only grades from 1 to 6 are allowed!");
            }
        }
    }
