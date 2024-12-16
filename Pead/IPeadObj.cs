namespace Pead
{
    internal interface IPeadObj<T> : IEquatable<T>
    {
        public string? ToString();
        public int GetHashCode();
    }
}
