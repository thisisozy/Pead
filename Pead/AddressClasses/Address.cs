namespace Pead.AddressClasses
{
    public class Address : IPeadObj<Address>
    {
        private string _street = string.Empty;
        private string _housenumber = string.Empty;
        private string _zipcode = string.Empty;
        private string _city = string.Empty;
        private string _country = string.Empty;

        public Address() { }
        public Address(string street, string housenumber, string zipcode, string city, string country)
        {
            Street = street;
            HouseNumber = housenumber;
            ZipCode = zipcode;
            City = city;
            Country = country;
        }

        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                _street = value;
            }
        }
        public string HouseNumber
        {
            get
            {
                return _housenumber;
            }
            set
            {
                _housenumber = value;
            }
        }
        public string ZipCode
        {
            get
            {
                return _zipcode;
            }
            set
            {
                _zipcode = value;
            }
        }
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }

        public override string ToString()
            => $"Street: {Street};HouseNumber: {HouseNumber};ZipCode: {ZipCode};City: {City};Country: {Country};";

        public bool Equals(Address? other)
        {
            if (other == null)
                return false;
            if (other == this)
                return true;

            if (other.GetHashCode() != this.GetHashCode())
                return false;

            if (other.Street        == this.Street      &&
                other.HouseNumber   == this.HouseNumber &&
                other.ZipCode       == this.ZipCode     &&
                other.City          == this.City        &&
                other.Country       == this.Country)
                return true;
            return false;
        }

        public override bool Equals(object? obj)
            => Equals(obj as Address);

        public override int GetHashCode()
            => HashCode.Combine(Street, HouseNumber, ZipCode, City, Country);
    }
}
