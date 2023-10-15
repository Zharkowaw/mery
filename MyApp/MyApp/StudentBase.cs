using System;

namespace MyApp
{
    public abstract class StudentBase : Person, IStudent
    {
        public delegate void GradeAddedUnder3Delegade(object sender, EventArgs args);
        public event GradeAddedUnder3Delegade GradeUnder3;
        public override string FirstName { get; set; }
        public override string LastName { get; set; }

        public StudentBase(string firstName, string lastName) : base(firstName, lastName)
        {

        }
        


        public abstract void AddGrade(double grade);

        public void AddGrade(string grade)
        {
            double convertedGradeToDouble = char.GetNumericValue(grade[0]);
            if (grade.Length == 2 && char.IsDigit(grade[0]) && grade[0] <= '6' && (grade[1] == '+' || grade[1] == '-'))
        }
               
        switch (grade[1])
            { 
         case '+':
                        double gradePlus = convertedGradeToDouble + 0.50;
        if (grande100>grande00)
        