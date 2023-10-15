using day15;

namespace day15
{
    public class SupervisorInMemory : EmployeeBase
    {

        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();

        public SupervisorInMemory(string name, string surname, string sex, int age, string jobPosition)
            : base(name, surname, sex, age, jobPosition)
        {

        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Sex { get; private set; }

        public int Age { get; private set; }

        public string JobPosition { get; private set; }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value! \n");
            }
        }

        public override void AddGrade(string grade)
        {
            var gradeInput = grade switch
            {
                "6" => 100,
                "-6" or "6-" => 95,
                "5" => 80,
                "+5" or "5+" => 85,
                "-5" or "5-" => 75,
                "4" => 60,
                "+4" or "4+" => 65,
                "-4" or "4-" => 55,
                "3" => 40,
                "+3" or "3+" => 45,
                "-3" or "3-" => 35,
                "2" => 20,
                "+2" or "2+" => 25,
                "-2" or "2-" => 15,
                "1" => 0,
                _ => throw new Exception("Invalid rating value! \n"),
            };

            {
                this.AddGrade(gradeInput);
            }

        }

        public override void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(int grade)
        {
            float gradeInInt = (float)grade;
            this.AddGrade(gradeInInt);
        }

        public override void AddGrade(double grade)
        {
            float gradeInDouble = (float)grade;
            this.AddGrade(gradeInDouble);
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}