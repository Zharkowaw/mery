using day15;


namespace day15
{
    public interface IEmployee
    {

        event GradeAddedDelegate GradeAdded;

        string Name { get; }

        string Surname { get; }

        string Sex { get; }

        int Age { get; }

        string JobPosition { get; }

        void AddGrade(float grade);

        void AddGrade(char grade);

        void AddGrade(string grade);

        void AddGrade(int grade);

        void AddGrade(double grade);

        Statistics GetStatistics();

    }
}
