using Pead.AddressClasses;

namespace Pead.PersonClasses
{
    public class Client : Person, IPeadObj<Client>
    {
        private Address billingAddress = new();

        public Client() { }
        public Client(string _firstname, string _lastname, Address _billingAddress)
            : base(_firstname, _lastname)
        {
            BillingAddress = _billingAddress;
        }
        public Client(Client client)
            : base(client)
        {
            BillingAddress = client.BillingAddress;
        }

        public Address BillingAddress
        {
            get
            {
                return billingAddress;
            }
            set
            {
                billingAddress = value;
            }
        }

        public override string ToString()
            => base.ToString() + $"BillingAddress: {{{BillingAddress}}};";

        public bool Equals(Client? other)
        {
            if (!base.Equals(other) ||
                other.GetHashCode() != this.GetHashCode())
                return false;

            if (other!.BillingAddress.Equals(this.BillingAddress))
                return true;

            return false;
        }

        public override bool Equals(object? obj)
            => Equals(obj as Client);

        public override int GetHashCode()
            => HashCode.Combine(base.GetHashCode(), BillingAddress.GetHashCode());
    }
}
