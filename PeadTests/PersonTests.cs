using AutoFixture;
using Pead.PersonClasses;

namespace PeadTests
{
	public class PersonTests {
	
		private static readonly Fixture fixture = new Fixture();

		private static readonly Person person1 = fixture.Create<Person>();
		private static readonly Person person2 = fixture.Create<Person>();
		private static readonly Person person1Copy = new Person(person1);

		[Fact]
		public void PersonEquals_WithEqualReference()
		{
			Assert.True(person1.Equals(person1));
		}

		[Fact]
		public void PersonEquals_WithPersonWithEqualAttributes()
		{
			Assert.True(person1.Equals(person1Copy));
		}

		[Fact]
		public void PersonEquals_WithPersonWithUnequalAttributes()
		{
			Assert.False(person1.Equals(person2));
		}

		[Fact]
		public void PersonEquals_WithNullCastedAsPerson()
		{
			Assert.False(person1.Equals(null));
		}

		[Fact]
		public void PersonEquals_WithPersonWithEqualAttributesCastedAsObject()
		{
			Assert.True(person1.Equals((object)person1Copy));
		}
	}
}