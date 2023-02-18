using day10;

namespace day10
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public Employee(string Name, string Surname)

        {
            this.Name = Name;
            this.Surname = Surname;

        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;

            return statistics;
        }

        public void AddGrades(double grade)
        {
            if (grade <= float.MaxValue)
            {
                this.AddGrades((float)grade);
            }
            else
            {
                Console.WriteLine("Wprowadzony double wykracza poza skalę float -");
            }
        }
        public void AddGrades(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrades(result);
            }
            else
            {
                Console.WriteLine("String nie jest liczbą -");
            }
        }
        public void AddGrades(float grade)
        {
            int valueInInt = (int)grade;
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"Ocena nie może być powyżej sto ani niżej niż 0 - {grade}");
            }
        }
      
        public void AddGrades(int grade)
        {
            this.AddGrades((float)grade);
        }
    }
}
