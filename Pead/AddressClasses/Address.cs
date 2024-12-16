namespace Pead.AddressClasses
{
    public class Address : IPeadObj<Address>
    {
        private string street = string.Empty;
        private string housenumber = string.Empty;
        private string zipcode = string.Empty;
        private string city = string.Empty;
        private string country = string.Empty;

        public Address() { }
        public Address(string _street, string _housenumber, string _zipcode, string _city, string _country)
        {
            Street = _street;
            HouseNumber = _housenumber;
            ZipCode = _zipcode;
            City = _city;
            Country = _country;
        }

        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public string HouseNumber
        {
            get
            {
                return housenumber;
            }
            set
            {
                housenumber = value;
            }
        }
        public string ZipCode
        {
            get
            {
                return zipcode;
            }
            set
            {
                zipcode = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
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
