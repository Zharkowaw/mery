namespace day15
{
    public class Statistics
    {


        public float Max { get; private set; }

        public float Min { get; private set; }

        public float Sum { get; private set; }

        public float Count { get; private set; }

        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }

        public char AverageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var average when average >= 81:
                        return 'A';
                    case var average when average >= 61:
                        return 'B';
                    case var average when average >= 41:
                        return 'C';
                    case var average when average >= 21:
                        return 'D';
                    case var average when average >= 1:
                        return 'E';
                    default:
                        return 'F';
                }
            }
        }

        public Statistics()
        {
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
            this.Sum = 0;
            this.Count = 0;
        }

        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Min = Math.Min(grade, this.Min);
            this.Max = Math.Max(grade, this.Max);
        }
    }

}