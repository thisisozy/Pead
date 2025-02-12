namespace Pead.PersonClasses
{
    public class Person : IPeadObj<Person>
    {
        private string _firstname = string.Empty;
        private string _lastname = string.Empty;
        private DateOnly _birthday = new();

        public Person() { }
        public Person(string firstname, string lastname, DateOnly birthday)
        {
            FirstName = firstname;
            LastName = lastname;
            Birthday = birthday;
        }
        public Person(Person person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            Birthday = person.Birthday;
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
        public DateOnly Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                _birthday = value;
            }
        }

        public override string? ToString()
            => $"FirstName: {FirstName};LastName: {LastName};Birthday: {Birthday}";

        public bool Equals(Person? other)
        {
            if (other == null)
                return false;
            if (other == this)
                return true;

            if (other.GetHashCode() != this.GetHashCode())
                return false;

            if (other.FirstName == this.FirstName &&
                other.LastName  == this.LastName  &&
                other.Birthday  == this.Birthday)
                return true;

            return false;
        }

        public override bool Equals(object? obj)
            => Equals(obj as Person);

        public override int GetHashCode()
            => HashCode.Combine(FirstName, LastName, Birthday);
    }
}
