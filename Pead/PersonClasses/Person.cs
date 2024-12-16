using Pead.Logger;

namespace Pead.PersonClasses
{
    public class Person : IPeadObj<Person>
    {
        private string _firstname = string.Empty;
        private string _lastname = string.Empty;
        private readonly ILogger _logger = new ConsoleLogger();

        public Person() { }
        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;

            _logger.LogWithDate("Person Created", this.ToString()!);
        }
        public Person(string firstname, string lastname, ILogger logger)
        {
            FirstName = firstname;
            LastName = lastname;

            this._logger = logger;
            this._logger.LogWithDate("Person Created", this.ToString()!);
        }
        public Person(Person person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;

            _logger = person._logger;
            _logger.LogWithDate("Person Copied", this.ToString()!);
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
