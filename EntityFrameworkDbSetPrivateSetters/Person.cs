namespace EntityFrameworkDbSetPrivateSetters
{
    public class Person
    {
        protected Person() { }

        public Person(string name)
        {
            Name = name;
        }

        public int PersonId { get; protected set; }
        public string Name { get; protected set; }
    }
}
