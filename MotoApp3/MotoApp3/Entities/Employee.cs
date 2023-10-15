namespace MotoApp3.Entities
{
    public class Employee : EntitiBase
    {

        public string? FirstName { get; set; }

        public override string ToString() => $"Id: {Id}, First Name: {FirstName}";


    }
}
