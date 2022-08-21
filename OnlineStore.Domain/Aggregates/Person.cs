namespace OnlineStore.Domain.Aggregates
{
    public class Person : Frameworks.Bases.Entity
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
