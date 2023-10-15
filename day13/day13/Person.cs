namespace day13
{
    public abstract class Person
    {

        public Person(string name, string surname, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }


        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }

    }
}