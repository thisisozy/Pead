namespace Pead.PersonClasses
{
    public class Person : IPeadObj<Person>
    {
        private string _firstname = string.Empty;
        private string _lastname = string.Empty;

        public Person() { }
        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
        public Person(Person person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
        }

        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }

        public override string? ToString()
            => $"FirstName: {FirstName};LastName: {LastName};";

        public bool Equals(Person? other)
        {
            if (other == null)
                return false;
            if (other == this)
                return true;

            if (other.GetHashCode() != this.GetHashCode())
                return false;

            if (other.FirstName == this.FirstName &&
                other.LastName  == this.LastName)
                return true;

            return false;
        }

        public override bool Equals(object? obj)
            => Equals(obj as Person);

        public override int GetHashCode()
            => HashCode.Combine(FirstName, LastName);
    }
}
